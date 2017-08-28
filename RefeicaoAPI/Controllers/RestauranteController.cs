using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RefeicaoAPI.Business.Interfaces;
using RefeicaoAPI.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RefeicaoAPI.Controllers
{
    [Route("api/[controller]")]
    public class RestauranteController : Controller
    {
        IRestauranteManager _restauranteManager;

        public RestauranteController(IRestauranteManager restauranteManager)
        {
            _restauranteManager = restauranteManager;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Restaurante> Get()
        {
            return _restauranteManager.GetAllRestaurantes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        [HttpPost]
        public IEnumerable<Restaurante> PesquisarRestaurantes([FromBody] string nome)
        {
            List<Restaurante> lista = new List<Restaurante>();


            return lista;
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
