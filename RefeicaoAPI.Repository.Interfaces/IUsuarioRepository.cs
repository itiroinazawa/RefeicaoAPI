using RefeicaoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefeicaoAPI.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> GetAllUsuarios();

        Usuario GetUsuarioByID(int idUsuario_);

        bool CreateUsuario(Usuario usuario_);

        bool UpdateUsuario(Usuario usuario_);

        bool DeleteUsuario(int idUsuario_);
    }
}
