using MiniETicaretAPI.Application.Repositories.Cart;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.Persistence.Repositories;

public class CartReadRepository : ReadRepository<Cart>, ICartReadRepository
{
    public CartReadRepository(MiniETicaretCaseAPIDbContext context) : base(context)
    {
    }
}