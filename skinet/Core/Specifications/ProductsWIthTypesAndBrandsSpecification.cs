using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications;

public class ProductsWIthTypesAndBrandsSpecification : BaseSpecification<Product>
{
    public ProductsWIthTypesAndBrandsSpecification()
    {
        AddInclude(x => x.ProductType);
        AddInclude(x => x.ProductBrand);
        AddInclude(x => x.Category);
        AddInclude(x => x.Tags);
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