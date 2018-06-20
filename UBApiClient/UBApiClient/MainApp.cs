using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UBApiClient
{
    static class MainApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string Version = "UB Api Client V. 1.00";
        public static string userName = string.Empty;
        public static string password = string.Empty;
        public static string departmentCode = string.Empty;
        public static string departmentName = string.Empty;
        public static int departmentID = 1;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UBApiClient.Forms.LazadaOP());            
        }
    }
}
