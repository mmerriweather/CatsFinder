using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cats.API
{
    [Route("api/[controller]")]
    public class CatsController : Cats
    {
        private CatsRepository repository;

        public CatsController()
        {
            repository = new CatsRepository();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Cats> Get()
        {
            return repository.GetAll();

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Cats Cats)
        {
            CatsRepository.Insert(Cats);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
