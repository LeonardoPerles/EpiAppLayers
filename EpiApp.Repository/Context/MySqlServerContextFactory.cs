using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EpiApp.Repository.Context
{
    public class MySqlServerContextFactory : IDesignTimeDbContextFactory<MySqlServerContext>
    {
        public MySqlServerContext CreateDbContext(string[] args)
        {
            // Criar a instância do DbContextOptionsBuilder
            var optionsBuilder = new DbContextOptionsBuilder<MySqlServerContext>();

            // Lê a configuração do banco de dados de um arquivo
            var strConfig = File.ReadAllText("../EpiApp.App/Config/ConfigBanco.txt"); // Certifique-se de que o caminho esteja correto

            // Configura o MySQL no DbContextOptionsBuilder
            optionsBuilder.UseSqlServer(strConfig, opt =>
            {
                opt.CommandTimeout(180);
                opt.EnableRetryOnFailure();
            });

            // Retorna uma instância do DbContext configurada
            return new MySqlServerContext(optionsBuilder.Options);
        }
    }
}
