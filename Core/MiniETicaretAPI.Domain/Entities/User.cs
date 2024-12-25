using MiniETicaretAPI.Domain.Entities.Common;

namespace MiniETicaretAPI.Domain.Entities;

public class User : BaseEntity
{
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
    public string ProfilePhotoUrl { get; set; }
    
    
}

// TODO : Identity kütüphanesi kullanılabilir. Zamanım olursa yapılacak.