using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration;
public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Productos");
        builder.Property(p => p.Id)
                .IsRequired();
        builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(100);
        builder.Property(p => p.Precio)
                .HasColumnType("decimal(18,2)");

        builder.HasOne(p => p.Marca)
                .WithMany(p => p.Productos)
                .HasForeignKey(p => p.MarcaId);

        builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Productos)
                .HasForeignKey(p => p.CategoriaId);



    }

}
