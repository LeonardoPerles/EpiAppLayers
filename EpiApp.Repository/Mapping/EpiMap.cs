using EpiApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EpiApp.Repository.Mapping
{
    public class EpiMap : IEntityTypeConfiguration<Epi>
    {
        public void Configure(EntityTypeBuilder<Epi> builder)
        {
            builder.ToTable("Epi");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.Ca)   
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.ValidadeCa);
            builder.Property(prop => prop.PrazoTroca);
            builder.HasMany(prop => prop.Setores)
                .WithOne(prop => prop.Epi)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(prop => prop.Funcionarios)
                .WithOne(prop => prop.Epi)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class EpiSetorMap : IEntityTypeConfiguration<EpiSetor>
    {
        public void Configure(EntityTypeBuilder<EpiSetor> builder)
        {
            builder.ToTable("EpiSetor");
            builder.HasKey(prop => prop.Id);
            builder.HasOne(prop => prop.Epi)
                .WithMany(prop => prop.Setores)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(prop => prop.Setor)
                 .WithMany(prop => prop.Epis)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}