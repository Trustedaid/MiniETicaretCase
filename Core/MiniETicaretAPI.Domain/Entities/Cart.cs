using MiniETicaretAPI.Domain.Entities.Common;

namespace MiniETicaretAPI.Domain.Entities;

public class Cart: BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public ICollection<CartItem> CartItems { get; set; }
 }