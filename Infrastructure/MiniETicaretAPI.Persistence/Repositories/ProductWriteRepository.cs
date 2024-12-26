using MiniETicaretAPI.Application.Repositories.Product;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.Persistence.Repositories;

public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(MiniETicaretCaseAPIDbContext context) : base(context)
    {
    }
}