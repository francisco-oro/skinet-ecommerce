using System.Linq.Expressions;
using Core.Entities;
using Core.Models;

namespace Core.Specifications;

public class ProductsWIthTypesAndBrandsSpecification : BaseSpecification<Product>
{
    public ProductsWIthTypesAndBrandsSpecification(
        string sort, ProductFilterParameters filterParameters) : 
        base(BuildCriteria(filterParameters)
    )
    
    {
        AddInclude(x => x.ProductType);
        AddInclude(x => x.ProductBrand);
        AddInclude(x => x.Category);
        AddInclude(x => x.Tags);
        AddOrderBy(x => x.Name);

        if (!string.IsNullOrEmpty(sort))
        {
            switch (sort)       
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

    private static Expression<Func<Product, bool>> BuildCriteria(ProductFilterParameters filterParameters)
    {
        return x => (!filterParameters.BrandId.HasValue || x.ProductBrandId == brandId) &&   
                    (!filterParameters.BrandId.HasValue || x.ProductTypeId == typeId) &&
                    (!filterParameters.CategoryId.HasValue || x.CategoryId == categoryId) &&
                    (!filterParameters.TagId.HasValue || x.Tags.Any(tag => tag.Id == tagId)) &&
                    (!filterParameters.ColorId.HasValue || x.Colors.Any(color => color.Id == colorId)) &&
                    (!filterParameters.SizeId.HasValue || x.Sizes.Any(size => size.Id == sizeId));
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