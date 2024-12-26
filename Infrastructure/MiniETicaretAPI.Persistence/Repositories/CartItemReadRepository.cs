using MiniETicaretAPI.Application.Repositories.CartItem;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.Persistence.Repositories;

public class CartItemReadRepository : ReadRepository<CartItem>, ICartItemReadRepository
{
    public CartItemReadRepository(MiniETicaretCaseAPIDbContext context) : base(context)
    {
    }
}