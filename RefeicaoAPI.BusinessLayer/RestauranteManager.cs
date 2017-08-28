using RefeicaoAPI.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using RefeicaoAPI.Entities;
using RefeicaoAPI.Repository.Interfaces;

namespace RefeicaoAPI.Business
{
    public class RestauranteManager : IRestauranteManager
    {
        IRestauranteRepository _restauranteRepository;

        public RestauranteManager(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        public bool CreateRestaurante(Restaurante restaurante_)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRestaurante(int idRestaurante_)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurante> GetAllRestaurantes()
        {
            return _restauranteRepository.GetAllRestaurantes();            
        }

        public Restaurante GetRestauranteByID(int idRestaurante_)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRestaurante(Restaurante restaurante_)
        {
            throw new NotImplementedException();
        }
    }
}
