using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    Task<Product?> GetProductByIdAsync(Guid id);
    Task<IReadOnlyList<Product?>> GetProductsAsync();
    Task<IReadOnlyList<ProductBrand?>> GetProductBrandsAsync();
    Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    Task<IReadOnlyList<Category>> GetProductCategoriesAsync();
    Task<IReadOnlyList<Tag>> GetProductTagsAsync();
    Task<IReadOnlyList<Size>> GetProductSizesAsync();
    Task<IReadOnlyList<Colors>> GetProductColorsAsync();
}