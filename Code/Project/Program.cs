using DoAnCuoiKi;
using System;
using System.Windows.Forms;

namespace Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_DangNhap());
            //Application.Run(new main_NV());
            //Application.Run(new Form_DangKy());
            //Application.Run(new Form_Admin());
            //Application.Run(new Form_DoiTac_Main());
        }
    }
}