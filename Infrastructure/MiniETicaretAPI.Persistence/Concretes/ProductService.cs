using MiniETicaretAPI.Application.Abstractions.Services;
using MiniETicaretAPI.Domain.Entities;

namespace MiniETicaretAPI.Persistence.Concretes;

public class ProductService : IProductService
{
    public List<Product> GetAllProducts()
        => new()
        {
            new() { Id = Guid.NewGuid(), Name = "Product1", Price = 100, Stock = 10, Description = "Description1" , Image = "ImageUrl", CategoryId = 1 },
            new() { Id = Guid.NewGuid(), Name = "Product2", Price = 200, Stock = 10, Description = "Description2" , Image = "ImageUrl", CategoryId = 2 },
            new() { Id = Guid.NewGuid(), Name = "Product3", Price = 300, Stock = 10 , Description = "Description3" , Image = "ImageUrl", CategoryId = 3 },
            new() { Id = Guid.NewGuid(), Name = "Product4", Price = 400, Stock = 10, Description = "Description4" , Image = "ImageUrl", CategoryId = 4 },
            new() { Id = Guid.NewGuid(), Name = "Product5", Price = 500, Stock = 10, Description = "Description5" , Image = "ImageUrl", CategoryId = 5 }
        };
}