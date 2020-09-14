using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Models
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        
        public Tipo()
        {

        }

        public Tipo(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }


    }
}
