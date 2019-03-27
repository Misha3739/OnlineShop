using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T Update(T value);

        T Get(int id);

        T GetWithDependencie(int id);

        void Create(T value);

        void Delete(T value);
    }
}
