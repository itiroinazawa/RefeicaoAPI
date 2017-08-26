using RefeicaoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefeicaoAPI.Repository.Interfaces
{
    public interface IRestauranteRepository
    {
        IEnumerable<Restaurante> GetAllRestaurantes();

        Restaurante GetRestauranteByID(int idRestaurante_);

        bool CreateRestaurante(Restaurante restaurante_);

        bool UpdateRestaurante(Restaurante restaurante_);

        bool DeleteRestaurante(int idRestaurante_);
    }
}
