using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications;

public class ProductsWIthTypesAndBrandsSpecification : BaseSpecification<Product>
{
    public ProductsWIthTypesAndBrandsSpecification(string sort, Guid? brandId, Guid? typeId) : base(x =>
        (!brandId.HasValue || x.ProductBrandId == brandId) && 
            (!typeId.HasValue || x.ProductTypeId == typeId)
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