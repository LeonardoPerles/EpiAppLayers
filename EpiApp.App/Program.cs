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
                // Executa o aplicativo com a inst�ncia de FormPrincipal
                Application.Run(formPrincipal);
            }
            else
            {
                // Caso o FormPrincipal n�o tenha sido resolvido, voc� pode lan�ar uma exce��o ou lidar com isso de outra maneira
                throw new InvalidOperationException("FormPrincipal n�o foi resolvido corretamente.");
            }
    }
}


