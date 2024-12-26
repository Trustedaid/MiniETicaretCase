using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniETicaretAPI.Application.Abstractions.Services;
using MiniETicaretAPI.Application.Repositories.Product;

namespace MiniETicaretAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IProductWriteRepository _productWriteRepository;
    private readonly IProductReadRepository _productReadRepository;

    public TestController(IProductService productService, IProductWriteRepository productWriteRepository,
        IProductReadRepository productReadRepository)
    {
        _productService = productService;
        _productWriteRepository = productWriteRepository;
        _productReadRepository = productReadRepository;
    }

    // [HttpGet]
    // public IActionResult GetProducts()
    // {
    //     var products = _productService.GetAllProducts();
    //     return Ok(products);
    // }


    [HttpGet]
    public async Task Get()
    {
        await _productWriteRepository.AddRangeAsync(new()
        {
            new()
            {
                Id = Guid.NewGuid(), Name = "Product1", Price = 100, Stock = 10, Description = "Description1",
                Image = "ImageUrl", CategoryId = 1, CreatedDate = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(), Name = "Product2", Price = 200, Stock = 10, Description = "Description2",
                Image = "ImageUrl", CategoryId = 2, CreatedDate = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(), Name = "Product3", Price = 300, Stock = 10, Description = "Description3",
                Image = "ImageUrl", CategoryId = 3, CreatedDate = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(), Name = "Product4", Price = 400, Stock = 10, Description = "Description4",
                Image = "ImageUrl", CategoryId = 4, CreatedDate = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(), Name = "Product5", Price = 500, Stock = 10, Description = "Description5",
                Image = "ImageUrl", CategoryId = 5, CreatedDate = DateTime.UtcNow
            }
        });

        var products = await _productWriteRepository.SaveAsync();
    }
}