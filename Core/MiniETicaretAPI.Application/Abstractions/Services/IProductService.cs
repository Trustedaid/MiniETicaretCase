using MiniETicaretAPI.Domain.Entities;

namespace MiniETicaretAPI.Application.Abstractions.Services;

public interface IProductService
{
   List<Product> GetAllProducts();
}