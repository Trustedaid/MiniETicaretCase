﻿using MiniETicaretAPI.Domain.Entities.Common;

namespace MiniETicaretAPI.Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> data);
    bool Remove(T model);
    bool RemoveRange(List<T> data);
    Task<bool> RemoveAsync(string id);
    bool Update(T model);
    Task<int> SaveAsync();
}