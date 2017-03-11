using DapperAPI.Model;
using DapperAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DapperAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IRepository<Product> productRepository;
        public ProductController(IRepository<Product> repository)
        {
            productRepository = repository;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productRepository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return productRepository.GetByID(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Product prod)
        {
            if (ModelState.IsValid)
            {
                productRepository.Add(prod);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product prod)
        {
            prod.ProductId = id;
            if (ModelState.IsValid)
            {
                productRepository.Update(prod);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            productRepository.Delete(id);
        }
    }
}
