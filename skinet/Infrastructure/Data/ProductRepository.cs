using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ProductRepository : IProductRepository
{
    private readonly StoreContext _storeContext;

    public ProductRepository(StoreContext storeContext)
    {
        _storeContext = storeContext;
    }

    public async Task<Product?> GetProductByIdAsync(Guid id)
    {
        return await _storeContext.Products
            .Include(p => p.ProductBrand)
            .Include(p => p.ProductType)
            .Include(p => p.Colors)
            .Include(p => p.Sizes)
            .Include(p => p.Category)
            .Include(p => p.Tags)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IReadOnlyList<Product?>> GetProductsAsync()
    {
        return await _storeContext.Products
            .Include(p => p.ProductBrand)
            .Include(p => p.ProductType)
            .Include(p => p.Colors)
            .Include(p => p.Sizes)
            .Include(p => p.Category)
            .Include(p => p.Tags)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<ProductBrand?>> GetProductBrandsAsync()
    {
        return await _storeContext.ProductBrands.ToListAsync();
    }

    public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
    {
        return await _storeContext.ProductTypes.ToListAsync();
    }

    public async Task<IReadOnlyList<Category>> GetProductCategoriesAsync()
    {
        return await _storeContext.Categories.ToListAsync();
    }

    public async Task<IReadOnlyList<Tag>> GetProductTagsAsync()
    {
        return await _storeContext.Tags
            .Include(t => t.Products)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Size>> GetProductSizesAsync()
    {
        return await _storeContext.Sizes
            .Include(t => t.Products)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Colors>> GetProductColorsAsync()
    {
        return await _storeContext.Colors
            .Include(t => t.Products)
            .ToListAsync();
    }
}