using System.Text.Json;
using System.Collections;
using Core.Entities;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedASync(StoreContext context)
    {
        if (!context.ProductBrands.Any())
        {
            var brandsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/brands.json");
            var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
            if (brands != null) context.ProductBrands.AddRange(brands);
            await context.SaveChangesAsync();
        }
        if (!context.Categories.Any())
        {
            var categoriesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/categories.json");
            var categories = JsonSerializer.Deserialize<List<Category>>(categoriesData);
            if (categories != null) context.Categories.AddRange(categories);
            await context.SaveChangesAsync();
        }
        if (!context.Colors.Any())
        {
            var colorsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/colors.json");
            var colors = JsonSerializer.Deserialize<List<Colors>>(colorsData);
            if (colors != null) context.Colors.AddRange(colors);
            await context.SaveChangesAsync();
        }
        if (!context.Sizes.Any())
        {
            var sizesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/sizes.json");
            var sizes = JsonSerializer.Deserialize<List<Size>>(sizesData);
            if (sizes != null) context.Sizes.AddRange(sizes);
            await context.SaveChangesAsync();
        }
        if (!context.ProductTypes.Any())
        {
            var typesData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/types.json");
            var productTypes = JsonSerializer.Deserialize<List<ProductType>>(typesData);
            if (productTypes != null) context.ProductTypes.AddRange(productTypes);
            await context.SaveChangesAsync();
        }

        if (!context.Products.Any())
        {
            var productsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(productsData);
            if (products != null)
            {
                foreach (var product in products)
                {
                    product.Id = Guid.NewGuid();
                }
                context.Products.AddRange(products);

            }
            await context.SaveChangesAsync();
        }
        if (!context.Tags.Any())
        {
            var tagsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/tags.json");
            var tags = JsonSerializer.Deserialize<List<Tag>>(tagsData);
            if (tags != null) context.Tags.AddRange(tags);
            await context.SaveChangesAsync();
        }

        if (context.ChangeTracker.HasChanges())
        {
            await context.SaveChangesAsync();
        }
    }
}