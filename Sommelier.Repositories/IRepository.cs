using Sommelier.Models;
using System;
using System.Collections.Generic;

namespace Sommelier.Repositories
{
    public interface IRepository<T> where T : BaseEntity                                           
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Update(T entity);
        void Delete(T entity);
        T Create(T entity);
    }
}
