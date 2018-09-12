using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication2
{
    static class Program
    {

        private static Mutex mutex = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //const string appName = "MyAppName";
            bool createdNew;

            mutex = new Mutex(true, "21212322323", out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("bhupendra" + " is already running! Exiting the application.");
                //Console.ReadKey();
                return;
            }  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            GC.KeepAlive(mutex);

        }
    }
}
