using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etf.nim.ma150129d
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int[] arr = new int[10];
            int a = 5;
            int b = 3;
            State st = new State(arr, a, b);
            State st1 = st;
            Application.Run(new Form1());
        }
    }
}
