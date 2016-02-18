using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Threading;

namespace ParserAvito
{
    //author Magomed Dadagov
    public class Parser
    {
        private AvitoContext _avitoDb = new AvitoContext();
        public AvitoContext AvitoDb
        {
            get
            {
                RWLock.EnterReadLock();
                try
                {
                    return _avitoDb;
                }
                finally
                {
                    RWLock.ExitReadLock();
                }
            }

            set
            {

                RWLock.EnterWriteLock();
                try
                {
                    _avitoDb = value;
                }
                finally
                {
                    RWLock.ExitWriteLock();
                }

            }


        }

        private ReaderWriterLockSlim RWLock = new ReaderWriterLockSlim();
        public string AvitoUrl { get; set; } = "https://m.avito.ru";

        public event Action<string> Logger;


        public async void ParseAll(string url,int pageNumber= 0)
        {
           var _refs = await ParseRefs(url, pageNumber);
            Logger("Найдено " + _refs.Length + " объявлений!");
           ParseArticles(_refs);
        }

        public void Export(string path)
        {
            var file = File.CreateText(path);
            foreach (var item in AvitoDb.Articles.ToArray())
            {
                string str = item.Numder + "\t" + item.Title + "\t" + item.Info + "\t" + item.Price + "\t" + item.Phone + "\t" + item.Address + "\t" + item.PublicDate + "\t" + item.Url+"\n";
                file.WriteLine(str);
            }
            file.Close();
        }


        public void CleanDb()
        {
            foreach (var item in AvitoDb.Articles.ToList())
            {
                AvitoDb.Articles.Remove(item);
            }
            AvitoDb.SaveChangesAsync();
            
        }

        #region Private Methods
        public async Task<string[]> ParseRefs(string url, int pageNumber=0)
        {
            List<string> _urls = new List<string>();
            int _pageNum = pageNumber > 0 ? pageNumber - 1 : pageNumber;
            bool _flag = true;
            while (_flag)
            {
                _pageNum++;
                try
                {
                    Task<HtmlDocument> _task = new Task<HtmlDocument>(() => { return new HtmlWeb().Load(url + "?p=" + _pageNum); }); _task.Start();                    
                    HtmlDocument _doc = await _task.ConfigureAwait(false);                    
                    HtmlNodeCollection _hrefs = _doc.DocumentNode.SelectNodes("//a[@class='item-link']");
                    foreach (var item in _hrefs)
                    {
                        var _url = AvitoUrl+item.Attributes["href"].Value;
                        var _ref = AvitoDb.Articles.FirstOrDefault(art => art.Url == _url);


                        if (_ref == null)
                        { 
                            _urls.Add(_url);
                        }
                    }                    
                    HtmlNodeCollection _nextPageRef = _doc.DocumentNode.SelectNodes("//li[@class='page page-next']");
                    if (_nextPageRef == null) _flag = false;
                    
                }
                catch (Exception ex)
                {
                    Logger.Invoke(ex.ToString());
                }                                
            }
            
            return _urls.ToArray();
        }

        public async void ParseArticles(params string[] refs)
        {
            foreach (var url in refs)
            {
                try
                {
                    Articles _article = AvitoDb.Articles.FirstOrDefault(art => art.Url == url);

                    if (_article != null)
                    {
                        continue;

                    }

                    //асинхронно загружаем содержание url
                    Task<HtmlDocument> _task = new Task<HtmlDocument>(() => { return new HtmlWeb().Load(url); }); _task.Start();
                    HtmlDocument _doc = await _task.ConfigureAwait(false);

                    //парсим заголовок 
                    var _title = _doc.DocumentNode.SelectSingleNode("//header[@class='single-item-header b-with-padding']").InnerText.Remove(0, 5);
                    _title = _title.Remove(_title.Length - 2, 2);
                    //парсим цену
                    var _price = _doc.DocumentNode.SelectSingleNode("//span[@class='price-value']").InnerText.Remove(0, 3);
                    _price = _price.Split('&')[0].Replace(" ", "").Replace("\n", "");

                    //парсим имя хозяина
                    // var _person = _doc.DocumentNode.SelectSingleNode("//div[@class='person-name person-contact-name']").InnerText.Remove(0, 2).Replace("\n","");
                    // _person = _person.Remove(_person.Length - 21, 21);

                    //парсим адрес
                    var _address = _doc.DocumentNode.SelectSingleNode("//div[@class='person-address padding-bottom']").InnerText.Remove(0, 10).Replace("\n", "").Replace("\t", "").Replace("     ", "");

                    //парсим содержание
                    var _info = _doc.DocumentNode.SelectSingleNode("//div[@class='description-preview-wrapper']");
                    HtmlNode _info2 = null;
                    string _infoStr = "";
                    if (_info == null)
                    {
                        _info = _doc.DocumentNode.SelectSingleNode("//div[@class='description-preview-wrapper description-with-html']");
                        _info2 = _doc.DocumentNode.SelectSingleNode("//div[@class='shop-description']");

                    }

                    _infoStr = _info.InnerText.Replace("\n", "");//.Remove(0, 1).Remove(_infoStr.Length - 3, 3);
                    if (_info2 != null) _infoStr += _info2.InnerText.Replace("\n", "");//.Remove(0, 1).Remove(_infoStr.Length - 3, 3);


                    //парсим дату размещения
                    var _publicData = _doc.DocumentNode.SelectSingleNode("//div[@class='item-add-date']").InnerText;
                    if (_publicData.Contains("сегодня"))
                    {
                        _publicData = _publicData.Replace("сегодня", DateTime.Now.ToString("dd MMMM"));
                    }
                    if (_publicData.Contains("вчера"))
                    {
                        DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1);
                        _publicData = _publicData.Replace("вчера", date.ToString("dd MMMM"));
                    }

                    //парсим номер объявления
                    var _number = _doc.DocumentNode.SelectSingleNode("//div[@class='item-id']").InnerHtml.Replace("Объявление №", "");

                    //парсим номер телефона
                    var _phone = await _parsePhone(AvitoUrl + _doc.DocumentNode.SelectSingleNode("//a[@title='Телефон продавца']").Attributes["href"].Value + "?async", url);

                    _article = new Articles();

                    _article.Url = url;
                    _article.Numder = _number;
                    _article.Title = _title;
                    _article.Info = _infoStr;
                    _article.Price = _price;
                    _article.Phone = _phone;
                    _article.Address = _address;
                    _article.PublicDate = _publicData;


                    AvitoDb.Articles.Add(_article);

                    await AvitoDb.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Logger.Invoke(ex.ToString());
                }               
            }
        }

        private async Task<string> _parsePhone( string url , string referer)
        {
           
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.103 Safari/537.36";
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Referer = referer;
           // request.Headers.Add("Accept-Charset", "windows-1251,utf-8;q=0.7,*;q=0.7");        
            request.Method = "GET";
            HttpWebResponse response;            
            string _phone ="";
            try
            {
                response = (HttpWebResponse)await request.GetResponseAsync();
                StreamReader _reader = new StreamReader(response.GetResponseStream());                
                _phone = _reader.ReadLine().Remove(0, 10);                
                _phone = _phone.Remove(_phone.Length - 4, 4).Replace(" ", "").Replace("-", "");
                Console.WriteLine(_phone);
                response.Close();
            }
            catch (Exception ex)
            {
                Logger.Invoke(ex.ToString());
            }
            return _phone;
        }
        #endregion

































        #region Singlton
        private Parser()
        {
            
        }

        

        private static Parser _instance;

        public static Parser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Parser();
                }
                return _instance;
            }
            private set { }
        }

        #endregion



    }
}
