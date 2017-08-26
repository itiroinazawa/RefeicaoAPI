using RefeicaoAPI.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using RefeicaoAPI.Entities;
using RefeicaoAPI.Repository.Interfaces;

namespace RefeicaoAPI.Business
{
    public class UsuarioManager : IUsuarioManager
    {
        IUsuarioRepository _usuarioRepository;

        public UsuarioManager(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool CreateUsuario(Usuario usuario_)
        {
            return _usuarioRepository.CreateUsuario(usuario_);
        }

        public bool DeleteUsuario(int idUsuario_)
        {
            return _usuarioRepository.DeleteUsuario(idUsuario_);
        }

        public IEnumerable<Usuario> GetAllUsuarios()
        {
            return _usuarioRepository.GetAllUsuarios();
        }

        public Usuario GetUsuarioByID(int idUsuario_)
        {
            return _usuarioRepository.GetUsuarioByID(idUsuario_);
        }

        public bool UpdateUsuario(Usuario usuario_)
        {
            return _usuarioRepository.UpdateUsuario(usuario_);
        }
    }
}
