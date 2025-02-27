using EpiApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EpiApp.Repository.Mapping
{
    public class SetorMap : IEntityTypeConfiguration<Setor>
    {
        public void Configure(EntityTypeBuilder<Setor> builder)
        {
            builder.ToTable("Setor");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .IsRequired();
            builder.HasMany(prop => prop.Epis)
                .WithOne(prop => prop.Setor)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(prop => prop.Funcionarios)
                .WithOne(prop => prop.Setor)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}