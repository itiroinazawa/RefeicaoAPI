using System;
using System.Collections.Generic;
using System.Text;

namespace RefeicaoAPI.Entities
{
    public class Restaurante
    {
        public String Nome { get; set; }

        public String Endereco { get; set; }

        public String CEP { get; set; }

        public String Telefone { get; set; }

        public Localizacao MapsLocalizacao { get; set; }
    }

    public class Localizacao
    {
        public String Latitude { get; set; }

        public String Longitude { get; set; }
    }
}
