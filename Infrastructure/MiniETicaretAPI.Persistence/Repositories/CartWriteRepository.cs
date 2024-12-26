using MiniETicaretAPI.Application.Repositories.Cart;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.Persistence.Repositories;

public class CartWriteRepository : WriteRepository<Cart>, ICartWriteRepository
{
    public CartWriteRepository(MiniETicaretCaseAPIDbContext context) : base(context)
    {
    }
}