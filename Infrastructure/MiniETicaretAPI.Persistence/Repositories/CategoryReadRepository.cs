using MiniETicaretAPI.Application.Repositories;
using MiniETicaretAPI.Application.Repositories.Category;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.Persistence.Repositories;

public class CategoryReadRepository :  ReadRepository<Category>, ICategoryReadRepository
{
    public CategoryReadRepository(MiniETicaretCaseAPIDbContext context) : base(context)
    {
    }
}