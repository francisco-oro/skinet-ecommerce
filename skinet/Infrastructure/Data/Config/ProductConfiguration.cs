using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Id).IsRequired();
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Description).IsRequired().HasMaxLength(380);
        builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
        builder.Property(p => p.PictureUrl).IsRequired();
        builder.HasOne(p => p.ProductBrand).WithMany()
            .HasForeignKey(p => p.ProductBrandId);
        builder.HasOne(p => p.ProductType).WithMany()
            .HasForeignKey(p => p.ProductTypeId);
        builder.HasOne(p => p.Category).WithMany()
            .HasForeignKey(p => p.CategoryId);
        builder.HasMany(p => p.Tags)
            .WithMany(tag => tag.Products);
        builder.HasMany(p => p.Colors)
            .WithMany(color => color.Products);
        builder.HasMany(p => p.Sizes)
            .WithMany(size => size.Products);
    }
}