using System.Collections.Generic;
using SmartCity.Core.Entities;

namespace SmartCity.Business.Abstract
{
    public interface IServices<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int entityId);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}