using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParserAvito
{
    //author Magomed Dadagov
    public class SelectorsRepository
    {

        public UserCollection<string, string> Locations { get; set; } = new UserCollection<string, string>();
        public UserCollection<string, string> SubLocations { get; set; } = new UserCollection<string, string>();
        public UserCollection<string, string> Catalogs { get; set; } = new UserCollection<string, string>();
        public UserCollection<string, string> SubCatalogs { get; set; } = new UserCollection<string, string>();



        public void LoadLocations()
        {
            try
            {
                FileStream FS = new FileStream(@"Location\Regions.xml", FileMode.Open);
                XmlSerializer XMLDeser = new XmlSerializer(typeof(UserCollection<string, string>));
                Locations = (UserCollection<string, string>)XMLDeser.Deserialize(FS);
                FS.Close();
            }
            catch (Exception)
            {

                
            }            
        }


        public void LoadSubLocations(string fileName)
        {
            try
            {
                string path;
                if (!Locations.ContainsKey(fileName))
                {
                    path = @"Location\SubLoc\Empty.xml";
                }
                else
                {
                    path = string.Format(@"Location\SubLoc\{0}.xml", fileName.Replace(" ", string.Empty));
                }
                if (path == "Location\\SubLoc\\ПовсейРоссии.xml")
                {
                    path = @"Location\SubLoc\Empty.xml";
                }
                FileStream FS = new FileStream(path, FileMode.Open);
                XmlSerializer XMLDeser = new XmlSerializer(typeof(UserCollection<string, string>));
                SubLocations = (UserCollection<string, string>)XMLDeser.Deserialize(FS);
                FS.Close();
            }
            catch (Exception)
            {

            }  
        }



        public void LoadCatalogs()
        {
            try
            {
                FileStream FS = new FileStream(@"Catalog\Catalogs.xml", FileMode.Open);
                XmlSerializer XMLDeser = new XmlSerializer(typeof(UserCollection<string, string>));
                Catalogs = (UserCollection<string, string>)XMLDeser.Deserialize(FS);
                FS.Close();
            }
            catch (Exception)
            {

            }
                  
              
        }


        public void LoadSubCatalogs(string fileName)
        {
            try
            {
                string path;
                if (!Catalogs.ContainsKey(fileName))
                {
                    path = @"Catalog\SubCat\Empty.xml";
                }
                else
                {
                    path = string.Format(@"Catalog\SubCat\{0}.xml", fileName.Replace(" ", string.Empty));
                }
                if (path == "Catalog\\SubCat\\Всеобъявления.xml")
                {
                    path = @"Catalog\SubCat\Empty.xml";
                }

                FileStream FS = new FileStream(path, FileMode.Open);
                XmlSerializer XMLDeser = new XmlSerializer(typeof(UserCollection<string, string>));
                SubCatalogs = (UserCollection<string, string>)XMLDeser.Deserialize(FS);
                FS.Close();
            }
            catch (Exception)
            {

            }
                  
             
        }




















        #region Singlot

        private SelectorsRepository() { }

        private static SelectorsRepository _instace;

        public static SelectorsRepository Instance
        {

            get
            {
                if (_instace==null)
                {
                    _instace = new SelectorsRepository();
                }
                return _instace;
            }

            private set { }
        }
        #endregion

    }
}
