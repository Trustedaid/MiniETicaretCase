using Microsoft.Extensions.DependencyInjection;
using MiniETicaretAPI.Application.Abstractions.Services;
using MiniETicaretAPI.Persistence.Concretes;
using MiniETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using MiniETicaretAPI.Application.Repositories.Cart;
using MiniETicaretAPI.Application.Repositories.CartItem;
using MiniETicaretAPI.Application.Repositories.Category;
using MiniETicaretAPI.Application.Repositories.Product;
using MiniETicaretAPI.Persistence.Repositories;

namespace MiniETicaretAPI.Persistence;

public static class ServiceRegistration
{
    // extension functions
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<MiniETicaretCaseAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        
        services.AddSingleton<IProductService, ProductService>();
        
        
        
       
        
        services.AddScoped<ICartReadRepository, CartReadRepository>();
        services.AddScoped<ICartWriteRepository, CartWriteRepository>();
        
        services.AddScoped<ICartItemReadRepository, CartItemReadRepository>();
        services.AddScoped<ICartItemWriteRepository, CartItemWriteRepository>();

        services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
        services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();    
        
        
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        
        
        
    }
}