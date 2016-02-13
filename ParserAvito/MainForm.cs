using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserAvito
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SelectorsRepository selectors = SelectorsRepository.Instance;
        Parser parser = Parser.Instance;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            selectors.LoadLocations();
            foreach (var item in selectors.Locations)
            {
                comboBox_loc.Items.Add(item.Key);
            }

            selectors.LoadCatalogs();
            foreach (var item in selectors.Catalogs)
            {
                comboBox_cat.Items.Add(item.Key);
            }

            //foreach (var item in parser.AvitoDb.Articles)
            //{
            //    articlesBindingSource.Add(item);
            //}

            parser.Logger += this.WriterLog;
        }

        private void comboBox_loc_TextChanged(object sender, EventArgs e)
        {
            selectors.LoadSubLocations(comboBox_loc.Text);
            comboBox_subLoc.Items.Clear();
            foreach (var item in selectors.SubLocations)
            {
                comboBox_subLoc.Items.Add(item.Key);
            }
            button_parse_Click(null, null);
        }

        private void comboBox_subLoc_TextChanged(object sender, EventArgs e)
        {
            button_parse_Click(null, null);
        }


        private void comboBox_cat_TextChanged(object sender, EventArgs e)
        {
            selectors.LoadSubCatalogs(comboBox_cat.Text);
            comboBox_subCat.Items.Clear();
            foreach (var item in selectors.SubCatalogs)
            {
                comboBox_subCat.Items.Add(item.Key);
            }
            button_parse_Click(null, null);
        }
        

        private void comboBox_subCat_TextChanged(object sender, EventArgs e)
        {
            button_parse_Click(null, null);
        }








        private void button_refresh_Click(object sender, EventArgs e)
        {
            articlesBindingSource.Clear();
            foreach (var item in parser.AvitoDb.Articles)
            {
                articlesBindingSource.Add(item);
            }
        }

        private void button_parse_Click(object sender, EventArgs e)
        {
            
            

            //локация
            string loc = "";
            
            if (selectors.SubLocations.ContainsKey(comboBox_subLoc.Text))
            {
                loc += selectors.SubLocations[comboBox_subLoc.Text];
            }
            else if (selectors.Locations.ContainsKey(comboBox_loc.Text))
            {
                loc += selectors.Locations[comboBox_loc.Text];
            }




            //каталог
            string cat = "";

            if (selectors.SubCatalogs.ContainsKey(comboBox_subCat.Text))
            {
                cat += selectors.SubCatalogs[comboBox_subCat.Text];
            }
            else if (selectors.Catalogs.ContainsKey(comboBox_cat.Text))
            {
                cat += selectors.Catalogs[comboBox_cat.Text];
            }


            string Url = parser.AvitoUrl + loc + cat;
           // textBox_loger.Text = Url;



            if (sender!=null)
            {
                Task _task = new Task(() =>
                  {

                      parser.ParseAll(Url);

                  });
                _task.Start();
            }













        }


        public void WriterLog(string text)
        {

            Action _action = new Action(() =>
            {
                textBox_loger.Text +=text+Environment.NewLine;
            });

            if (textBox_loger.InvokeRequired)
            {
                textBox_loger.BeginInvoke(_action);
            }
            else
            {
                _action.Invoke();
            }
            
        }

        private void button_cleanDb_Click(object sender, EventArgs e)
        {
            parser.CleanDb();
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_export.ShowDialog();
                string path = saveFileDialog_export.FileName;
                parser.Export(path);
            }
            catch (Exception ex)
            {

                textBox_loger.Text += ex;
            }
            

        }
    }
}
