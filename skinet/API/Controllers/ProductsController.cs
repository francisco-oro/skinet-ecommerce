using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]/")]
public class ProductsController: ControllerBase
{
    private readonly ProductRepository _productRepository;

    public ProductsController(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }


    [HttpGet("[action]")]
    public async  Task<ActionResult<List<Product>>> GetProducts()
    {
        var products = await _productRepository.GetProductsAsync();
        
        return Ok(products); 
    }

    [HttpGet("[action]/{id}")]
    public async Task<ActionResult<Product>> GetProduct(Guid id)
    {
        return await _productRepository.GetProductByIdAsync(id);
    }
}