using EpiApp.Domain.Entities;
using EpiApp.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace EpiApp.Repository.Context
{
    public class MySqlServerContext : DbContext
    {
        public MySqlServerContext(DbContextOptions<MySqlServerContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Setor> Setores { get; set; }
        public DbSet<Epi> Epis { set; get; }
        public DbSet<EpiSetor> EpiSetores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioSetor> FuncionarioSetores{ get; set; }
        public DbSet<FuncionarioEpi> FuncionarioEpis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Epi>(new EpiMap().Configure);
            modelBuilder.Entity<Setor>(new SetorMap().Configure);
            modelBuilder.Entity<EpiSetor>(new EpiSetorMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
            modelBuilder.Entity<FuncionarioSetor>(new FuncionarioSetorMap().Configure);
            modelBuilder.Entity<FuncionarioEpi>(new FuncionarioEpiMap().Configure);
        }
    }
}