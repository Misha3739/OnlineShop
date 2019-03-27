using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShop.Controllers
{
 
    public class CategoryController : Controller
    {
        private readonly IRepository<Category> _repository;

        public CategoryController(IRepository<Category> repository) {
            this._repository = repository;
        }

        // TODO: Вставку новой категории, чтобы прилетала новая категория, через пост и объявить методы в репозиторе чтобы они редактировались 

        // GET: api/values
        [HttpGet("/api/categories")]
        public IEnumerable<Category> Get()
        {
            return _repository.GetAll();
        }


        // GET api/values/5
        [HttpGet("api/categories/get/{id}")]
        public Category Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut("api/categories/update")]
        public IActionResult Update([FromBody]Category value)
        {
            return Ok(_repository.Update(value)); //_repository.Update(value);


            // TODO:  Если не обновился нужно возвращать bad request; 
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
