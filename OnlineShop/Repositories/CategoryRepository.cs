using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShop.Data;
using System.Linq;

namespace OnlineShop.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {

        private List<Category> _retList = new List<Category>();

        public CategoryRepository()
        {
            Category category = new Category();

            category.Id = 1;

            category.Name = "Категория Продукты";

            Product product = new Product();

            product.Name = "Простой продукт";

            category.Products.Add(product);

            _retList.Add(category);
        }


        public void Create(Category value)
        {
            throw new NotImplementedException();
        }


        public void Delete(Category value)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            // TODO: Захордкодить данные и вывести список с продуктами, должна вернуть категорий и у каждый должен быть свой продукт



            return _retList;

        }

        public Category Get(int id)
        {


            return _retList.FirstOrDefault(item => item.Id == id);

            //   throw new NotImplementedException();
        }

        public Category GetWithDependencie(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category value)
        {

            Category updated = _retList.FirstOrDefault(item => item.Id == value.Id );

            if (updated != null)
            {
                updated.Name = value.Name;
                return updated;
            }

            return null;

            // TODO: Нужно перенести метод поиска в гет а

        }
    }
}

