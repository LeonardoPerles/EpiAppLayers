using EpiApp.App.Base;
using EpiApp.App.Infra;

namespace EpiApp.App;
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfigureServices();
            ApplicationConfiguration.Initialize();        
            Application.Run(new FormPrincipal());
    }
}


