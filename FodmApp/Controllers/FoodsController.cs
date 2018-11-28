using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FodmApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FodmApp.Controllers
{
    [Route("api/[controller]")]
    public class FoodsController : Controller
    {
        private readonly FodmAppContext _context;
        public FoodsController(FodmAppContext context)
        {
            _context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public List<Food> Get()
        {
            using (_context)
            {
                return _context.Foods.ToList();
            }
        }
        [HttpGet("{id}")]
        public Food Get(int id)
        {
            using (_context)
            {
                return _context.Foods.Where(food => food.Id == id)
                                     .First();
            }
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
    }
}
