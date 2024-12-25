using Microsoft.Extensions.DependencyInjection;
using MiniETicaretAPI.Application.Abstractions.Services;
using MiniETicaretAPI.Persistence.Concretes;

namespace MiniETicaretAPI.Persistence;


public static class ServiceRegistration
{
    // extension functions
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
    }
}