using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RefeicaoAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RefeicaoAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {        
        [HttpGet]
        public IEnumerable<Usuario> GetAll()
        {
            List<Usuario> lista = new List<Usuario>();

            Usuario usuario = new Usuario();

            usuario.Name = "Rodrigo Itiro";
            usuario.Empresa = "Refeitex";
            usuario.Id = 1;
            lista.Add(usuario);

            usuario.Name = "Felipe Martinelli";
            usuario.Empresa = "Refeitex";
            usuario.Id = 2;
            lista.Add(usuario);            

            return lista;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            if (usuario == null) { return BadRequest(); }

            usuario.Id = 3;

            return CreatedAtRoute("GetUsuario", new { id = usuario.Id }, usuario);
        }


        // GET api/values/5
        [HttpGet("{id}", Name = "GetUsuario")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

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
