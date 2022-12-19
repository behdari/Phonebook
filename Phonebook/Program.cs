using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Phonebook
{
    static class Program
    {
        /// <summary>
        /// The code is take from here:
        /// https://www.codeproject.com/Articles/38246/Phone-Book-in-C
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
