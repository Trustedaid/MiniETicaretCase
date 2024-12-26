using MiniETicaretAPI.Application.Repositories.Category;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.Persistence.Repositories;

public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
{
    public CategoryWriteRepository(MiniETicaretCaseAPIDbContext context) : base(context)
    {
    }
}