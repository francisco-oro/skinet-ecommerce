using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications;

public class ProductsWIthTypesAndBrandsSpecification : BaseSpecification<Product>
{
    public ProductsWIthTypesAndBrandsSpecification(ProductSpecParams productSpecParams) : 
        base(BuildCriteria(productSpecParams)
    )
    
    {
        AddInclude(x => x.ProductType);
        AddInclude(x => x.ProductBrand);
        AddInclude(x => x.Category);
        AddInclude(x => x.Tags);
        AddOrderBy(x => x.Name);
        ApplyPaging(productSpecParams.PageSize * (productSpecParams.PageIndex - 1), productSpecParams.PageSize);

        if (!string.IsNullOrEmpty(productSpecParams.Sort))
        {
            switch (productSpecParams.Sort)       
            {
                case "priceAsc":
                    AddOrderBy(p => p.Price);
                    break;
                case "priceDesc":
                    AddOrderByDescending(p => p.Price);
                    break;
                case "categoryAsc":
                    AddOrderBy(p => p.Category.CategoryName);
                    break;
                case "categoryDesc":
                    AddOrderByDescending(p => p.Category.CategoryName);
                    break;
                case "typeAsc":
                    AddOrderBy(p => p.ProductType.Name);
                    break;
                case "typeDesc":
                    AddOrderByDescending(p => p.ProductType.Name);
                    break;
                case "brandAsc":
                    AddOrderBy(p => p.ProductBrand.Name);
                    break;
                case "brandDesc":
                    AddOrderByDescending(p => p.ProductBrand.Name);
                    break;
                default:
                    AddOrderBy(p => p.Name);
                    break;
            }
        }
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

    public ProductsWIthTypesAndBrandsSpecification(Guid id) : base(x => x.Id == id)
    {
        AddInclude(x => x.ProductType);
        AddInclude(x => x.ProductBrand);
        AddInclude(x => x.Category);
        AddInclude(x => x.Colors);
        AddInclude(x => x.Sizes);
        AddInclude(x => x.Tags);
    }
}