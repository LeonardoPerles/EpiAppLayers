using EpiApp.App.Base;
using EpiApp.App.Infra;
using Microsoft.Extensions.DependencyInjection;

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

            var formPrincipal = ConfigureDI.ServicesProvider!.GetService<FormPrincipal>();

            if (formPrincipal != null)
            {
                // Executa o aplicativo com a instância de FormPrincipal
                Application.Run(formPrincipal);
            }
            else
            {
                // Caso o FormPrincipal não tenha sido resolvido, você pode lançar uma exceção ou lidar com isso de outra maneira
                throw new InvalidOperationException("FormPrincipal não foi resolvido corretamente.");
            }
    }
}


