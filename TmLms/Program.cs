using TmLms.TM;

namespace TmLms
{
    public static class Program
    {
        public static TMEngine tmEngine;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            tmEngine = TMEngine.Instance;
            tmEngine.LoadDummyData();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}