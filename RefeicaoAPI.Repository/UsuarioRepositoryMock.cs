using RefeicaoAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using RefeicaoAPI.Entities;

namespace RefeicaoAPI.Repository
{
    public class UsuarioRepositoryMock : IUsuarioRepository
    {
        public bool CreateUsuario(Usuario usuario_)
        {
            return true;
        }

        public bool DeleteUsuario(int idUsuario_)
        {
            return true;
        }

        public IEnumerable<Usuario> GetAllUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            Usuario usuario = GerarUsuario(1, "Mock1", "Empresa1");
            usuarios.Add(usuario);

            usuario = GerarUsuario(2, "Mock2", "Empresa2");
            usuarios.Add(usuario);

            usuario = GerarUsuario(3, "Mock3", "Empresa3");
            usuarios.Add(usuario);

            return usuarios;
        }

        public Usuario GetUsuarioByID(int idUsuario_)
        {
            Usuario usuario = new Usuario();

            usuario = GerarUsuario(1, "Mock1", "Empresa1");

            return usuario;
        }

        public bool UpdateUsuario(Usuario usuario_)
        {
            return true;
        }

        private Usuario GerarUsuario(int ID, string nome, string empresa)
        {
            Usuario usuario = new Usuario();

            usuario.Id = ID;
            usuario.Nome = nome;
            usuario.Empresa = empresa;

            return usuario;
        }
    }
}
