﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }

        Task<T> GetByIdAsync(object id);

        Task<T> GetByAsync(Expression<Func<T, bool>>? filter = null, string includeProperties = "");

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetListByAsync(Expression<Func<T, bool>>? filter = null, string includeProperties = "");

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(object id);
    }
}
