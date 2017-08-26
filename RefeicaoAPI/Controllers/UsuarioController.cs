using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RefeicaoAPI.Entities;
using RefeicaoAPI.Business.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RefeicaoAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        IUsuarioManager _usuarioManager;

        public UsuarioController(IUsuarioManager usuarioManager)
        {
            _usuarioManager = usuarioManager;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetAll()
        {
            IEnumerable<Usuario> lista = _usuarioManager.GetAllUsuarios();
            return lista;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            if (usuario == null) { return BadRequest(); }

            _usuarioManager.CreateUsuario(usuario);

            return CreatedAtRoute("GetUsuario", new { id = usuario.Id }, usuario);
        }


        // GET api/values/5
        [HttpGet("{id}", Name = "GetUsuario")]
        public Usuario Get(int id)
        {
            return _usuarioManager.GetUsuarioByID(id);
        }        

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Usuario usuario)
        {
            _usuarioManager.UpdateUsuario(usuario);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _usuarioManager.DeleteUsuario(id);
        }
    }
}
