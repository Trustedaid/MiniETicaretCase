using MiniETicaretAPI.Domain.Entities.Common;

namespace MiniETicaretAPI.Domain.Entities;

public class Cart: BaseEntity
{
    public string UserId { get; set; }
    public ICollection<CartItem> CartItems { get; set; }
 }