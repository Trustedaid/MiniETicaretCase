using MiniETicaretAPI.Application.Repositories.CartItem;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.Persistence.Repositories;

public class CartItemWriteRepository : WriteRepository<CartItem>, ICartItemWriteRepository
{
    public CartItemWriteRepository(MiniETicaretCaseAPIDbContext context) : base(context)
    {
    }
}