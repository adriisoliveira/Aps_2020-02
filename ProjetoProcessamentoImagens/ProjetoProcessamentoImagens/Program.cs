using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;



namespace ProjetoProcessamentoImagens
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaLogin());
        }
    }

    public sealed class ColorMap
    {
        /*Defines a map for converting colors. Several methods of the 
        ImageAttributes class adjust image colors by using a color-remap table, 
        which is an array of ColorMap structures. Not inheritable.*/
    }
}
