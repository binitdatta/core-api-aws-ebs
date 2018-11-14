using System.Collections.Generic;
using core_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace core_api.Controllers
{
    [Route("api/cat")]
    public class CatController : Controller
    {
        [HttpGet]
        public IEnumerable<Cat> GetAll()
        {
            var list = new List<Cat>();
            list.Add(new Cat() { Name = "Lilly" });
            list.Add(new Cat() { Name = "Lucy" });
            return list;
        }

        [HttpGet("{name}")]
        public Cat Get(string name)
        {
            return new Cat() { Name = name };
        }

        [HttpPost]
        public Cat Insert([FromBody]Cat cat)
        {
            // write the new cat to database
            return cat;
        }

        [HttpPut("{name}")]
        public Cat Update(string name, [FromBody]Cat cat)
        {
            cat.Name = name;
            // write the updated cat to database
            return cat;
        }

        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            // delete the cat from the database

        }



    }
}