using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications;

public class ProductsWithFiltersForCountSpecification : BaseSpecification<Product>
{
    public ProductsWithFiltersForCountSpecification(ProductSpecParams productSpecParams) : base(BuildCriteria(productSpecParams))
    {
        
    }
    
    private static Expression<Func<Product, bool>> BuildCriteria(ProductSpecParams productSpecParams)
    {
        return x => (!productSpecParams.BrandId.HasValue || x.ProductBrandId == productSpecParams.BrandId) &&   
                    (!productSpecParams.TypeId.HasValue || x.ProductTypeId == productSpecParams.TypeId) &&
                    (!productSpecParams.CategoryId.HasValue || x.CategoryId == productSpecParams.CategoryId) &&
                    (!productSpecParams.TagId.HasValue || x.Tags.Any(tag => tag.Id == productSpecParams.TagId)) &&
                    (!productSpecParams.ColorId.HasValue || x.Colors.Any(color => color.Id == productSpecParams.ColorId)) &&
                    (!productSpecParams.SizeId.HasValue || x.Sizes.Any(size => size.Id == productSpecParams.SizeId));
    }
}