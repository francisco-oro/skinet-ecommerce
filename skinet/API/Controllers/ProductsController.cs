using API.DTO;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

// [ApiController]
[Route("api/[controller]/")]
public class ProductsController: ControllerBase
{
    private readonly IGenericRepository<Product> _productsRepo;
    private readonly IGenericRepository<ProductBrand> _productBrandRepo;
    private readonly IGenericRepository<ProductType> _productTypeRepo;
    private readonly IGenericRepository<Category> _productCategoryRepo;
    private readonly IGenericRepository<Colors> _productColorRepo;
    private readonly IGenericRepository<Size> _productSizeRepo;
    private readonly IGenericRepository<Tag> _productTagRepo;
    private readonly IMapper _mapper;

    public ProductsController(IGenericRepository<Product> productsRepo, IGenericRepository<ProductBrand> productBrandRepo, IGenericRepository<ProductType> productTypeRepo, IGenericRepository<Category> productCategoryRepo, IGenericRepository<Colors> productColorRepo, IGenericRepository<Size> productSizeRepo, IGenericRepository<Tag> productTagRepo, IMapper mapper)
    {
        _productsRepo = productsRepo;
        _productBrandRepo = productBrandRepo;
        _productTypeRepo = productTypeRepo;
        _productCategoryRepo = productCategoryRepo;
        _productColorRepo = productColorRepo;
        _productSizeRepo = productSizeRepo;
        _productTagRepo = productTagRepo;
        _mapper = mapper;
    }

    [HttpGet("[action]")]
    public async  Task<IReadOnlyList<Product>> GetProducts()
    {
        var spec = new ProductsWIthTypesAndBrandsSpecification();
        
        var products = await _productsRepo.ListAsync(spec);
        return products;
    }

    [HttpGet("[action]/{id}")]
    public async Task<ActionResult<ProductToReturnDto>> GetProduct(Guid id)
    {
        var spec = new ProductsWIthTypesAndBrandsSpecification(id);

        var product = await _productsRepo.GetEntityWithSpec(spec);

        return _mapper.Map<Product, ProductToReturnDto>(product);

    }

    [HttpGet("brands")]
    public async Task<ActionResult<IReadOnlyList<ProductBrand?>>> GetProductBrands()
    {
        return Ok(await _productBrandRepo.ListAllAsync());
    }

    [HttpGet("types")]
    public async Task<ActionResult<IReadOnlyList<ProductType?>>> GetProductTypes()
    {
        return Ok(await _productTypeRepo.ListAllAsync());
    }

    [HttpGet("categories")]
    public async Task<ActionResult<IReadOnlyList<Category?>>> GetProductCategories()
    {
        return Ok(await _productCategoryRepo.ListAllAsync());
    }

    [HttpGet("colors")]
    public async Task<ActionResult<IReadOnlyList<Colors?>>> GetProductColors()
    {
        return Ok(await _productColorRepo.ListAllAsync());
    }

    [HttpGet("sizes")]
    public async Task<ActionResult<IReadOnlyList<Size?>>> GetProductSizes()
    {
        return Ok(await _productSizeRepo.ListAllAsync());
    }

    [HttpGet("tags")]
    public async Task<ActionResult<IReadOnlyList<Tag?>>> GetProductTags()
    {
        return Ok(await _productTagRepo.ListAllAsync());
    }
}