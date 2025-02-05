using System;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
          
            AppDBContext appDbContext = new();
            appDbContext.Database.EnsureCreated();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());  // فرم اصلی
        }
    }
}