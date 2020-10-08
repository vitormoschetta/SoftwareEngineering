using System;
using System.Collections.Generic;
using Domain.Entities;
using Shared;

namespace Domain.Contracts
{
    public interface IRepository<T>
    {
        DataResult Create(T entity);
        DataResult Update(T entity);
        DataResult Delete(Guid id);
        DataResult Exists(Guid id);
        Product GetById(Guid id);
        IList<T> GetAll();

    }
}