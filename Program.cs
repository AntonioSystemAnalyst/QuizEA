using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizEA
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        public static string Key = " ";
        public static string  path  = "resources\\perguntas\\N1.txt";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            inicio abertura = new inicio();
            abertura.ShowDialog();
            abertura = null;

            if (Key == "open")
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }
    }
}
