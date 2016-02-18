using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserAvito
{
    //author Magomed Dadagov
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


           // Test();
            Console.WriteLine("End");
            Console.Read();
        }



        public   static void Test()
        {
            Parser parser = Parser.Instance;
            parser.ParseAll("https://m.avito.ru/urus-martan/oborudovanie_dlya_biznesa", 0);
            

        }
    }
}
