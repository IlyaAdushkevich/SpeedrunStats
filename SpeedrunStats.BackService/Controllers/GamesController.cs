using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpeedrunStats.BackService.Models;

namespace SpeedrunStats.BackService.Controllers
{

    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private Repository _repository;

        public GamesController(Models.Repository repository)
        {
            _repository = repository;
        }


        // GET api/values
        [HttpGet]
        public List<Game> Get()
        {
            return _repository.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Game Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Game value)
        {
            _repository.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Game value)
        {
            _repository.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}
