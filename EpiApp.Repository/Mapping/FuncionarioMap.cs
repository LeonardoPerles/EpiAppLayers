using EpiApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EpiApp.Repository.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .IsRequired();
            builder.Property(prop => prop.Documento)
                .IsRequired();
            builder.Property(prop => prop.Ativo)
                .IsRequired();
            builder.Property(prop => prop.DataNascimento)
                .IsRequired();
            builder.HasMany(prop => prop.Setores)
                .WithOne(prop => prop.Funcionario)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(prop => prop.Epis)
                .WithOne(prop => prop.Funcionario)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }

    public class FuncionarioSetorMap : IEntityTypeConfiguration<FuncionarioSetor>
    {
        public void Configure(EntityTypeBuilder<FuncionarioSetor> builder)
        {
            builder.ToTable("FuncionarioSetor");
            builder.HasKey(prop => prop.Id);
            builder.HasOne(prop => prop.Funcionario)
                .WithMany(prop => prop.Setores)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(prop => prop.Setor)
                 .WithMany(prop => prop.Funcionarios)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FuncionarioEpiMap : IEntityTypeConfiguration<FuncionarioEpi>
    {
        public void Configure(EntityTypeBuilder<FuncionarioEpi> builder)
        {
            builder.ToTable("FuncionarioEpi");
            builder.HasKey(prop => prop.Id);
            builder.HasOne(prop => prop.Funcionario)
                .WithMany(prop => prop.Epis)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(prop => prop.Epi)
                 .WithMany(prop => prop.Funcionarios)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}