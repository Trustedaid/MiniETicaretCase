﻿using System.Linq.Expressions;
using MiniETicaretAPI.Application.Repositories;
using MiniETicaretAPI.Domain.Entities.Common;
using MiniETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
namespace MiniETicaretAPI.Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly MiniETicaretCaseAPIDbContext _context;

    public ReadRepository(MiniETicaretCaseAPIDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
        {
            query = query.AsNoTracking();
        }

        return query;
    }

    public IQueryable<T> GetWhere(Expression method, bool tracking = true)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.Where(method);
        if (!tracking)
        {
            query = query.AsNoTracking();
        }

        return query;
    }

    public async Task<T?> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
        {
            query = query.AsNoTracking();
        }

        return await query.FirstOrDefaultAsync();
    }

    public async Task<T> GetByIdAsync(string id, bool tracking = true)
       

    {
        var query = Table.AsQueryable();
        if (!tracking)
        {
            query = Table.AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }
}