using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly MiniETicaretCaseAPIDbContext _context;

        public CartController(MiniETicaretCaseAPIDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCart()
        {
            var cart =await _context.Carts.ToListAsync();
            return Ok(cart);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartById(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            return Ok(cart);
        }

        [HttpPost("{userId}/add")]
        public async Task<IActionResult> AddToCart(Guid userId, [FromBody] Guid productId)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(c => c.UserId == userId);
            if (cart == null)
            {
                cart = new Cart() { UserId = userId };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            var cartItems = await _context.CartItems.FirstOrDefaultAsync(ci => ci.CartId == cart.Id && ci.ProductId == productId);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCartItem(Guid userId, [FromBody] Guid productId)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(b => b.UserId == userId);

            var basketItem = await _context.CartItems.FirstOrDefaultAsync(ci => ci.CartId == cart.Id && ci.ProductId == productId);
            
            if (basketItem.Quantity > 1)
            {
                basketItem.Quantity--;
            }
            else
            {
                _context.CartItems.Remove(basketItem);
            }

            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
