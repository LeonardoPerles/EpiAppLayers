using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using EpiApp.Repository.Context;
using EpiApp.Domain.Entities;
using EpiApp.App.Models;
using Microsoft.VisualBasic.Logging;
using EpiApp.App.Cadastro;
using EpiApp.App.Consulta;
using EpiApp.Domain.Base;
using EpiApp.Services.Services;
using EpiApp.Repository.Repository;

namespace EpiApp.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;
        
        public static void ConfigureServices()
        {            
            Services = new ServiceCollection();
            #region Banco de dados
            var strConfig = File.ReadAllText("Config/ConfigBanco.txt");
            Services.AddDbContext<MySqlServerContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseSqlServer(strConfig, opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Mappings
            // Mapper Configurantion
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Epi, EpiModel>();
                config.CreateMap<Funcionario, FuncionarioModel>();
                config.CreateMap<Setor, SetorModel>();

            }).CreateMapper());
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Setor>, BaseRepository<Setor>>();
            Services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario>>();
            Services.AddScoped<IBaseRepository<Epi>, BaseRepository<Epi>>();
            Services.AddScoped<IBaseRepository<FuncionarioSetor>, BaseRepository<FuncionarioSetor>>();
            Services.AddScoped<IBaseRepository<EpiSetor>, BaseRepository<EpiSetor>>();
            Services.AddScoped<IBaseRepository<FuncionarioEpi>, BaseRepository<FuncionarioEpi>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Setor>, BaseService<Setor>>();
            Services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();
            Services.AddScoped<IBaseService<Epi>, BaseService<Epi>>();
            Services.AddScoped<IBaseService<FuncionarioSetor>, BaseService<FuncionarioSetor>>();
            Services.AddScoped<IBaseService<EpiSetor>, BaseService<EpiSetor>>();
            Services.AddScoped<IBaseService<FuncionarioEpi>, BaseService<FuncionarioEpi>>();
            #endregion

            #region Forms
            Services.AddTransient<SetorCadastro, SetorCadastro>();
            Services.AddTransient<SetorConsulta, SetorConsulta>();
            Services.AddTransient<FuncionarioCadastro, FuncionarioCadastro>();
            Services.AddTransient<FuncionarioConsulta, FuncionarioConsulta>();
            Services.AddTransient<EpiCadastro, EpiCadastro>();
            Services.AddTransient<EpiConsulta, EpiConsulta>();
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
