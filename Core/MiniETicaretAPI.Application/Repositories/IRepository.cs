using MiniETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace MiniETicaretAPI.Application.Repositories;

public interface IRepository<T> where T: BaseEntity
{
    DbSet<T> Table { get; }
}