﻿using MiniETicaretAPI.Application.Repositories.Product;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.Persistence.Repositories;

public class ProductReadRepository :  ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(MiniETicaretCaseAPIDbContext context) : base(context)
    {
    }
}