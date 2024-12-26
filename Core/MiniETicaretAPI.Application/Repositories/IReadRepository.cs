using System.Linq.Expressions;
using MiniETicaretAPI.Domain.Entities.Common;

namespace MiniETicaretAPI.Application.Repositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll(bool tracking = true);
    IQueryable<T> GetWhere(Expression method, bool tracking = true);
    Task<T?> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
    Task<T> GetByIdAsync(string id, bool tracking = true);
}