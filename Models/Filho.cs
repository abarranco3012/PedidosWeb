using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Models
{
    public class Filho
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DtNasc { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public Filho()
        {

        }

        public Filho(int id, string nome, DateTime dtNasc, Cliente cliente, int clienteId)
        {
            Id = id;
            Nome = nome;
            DtNasc = dtNasc;
            Cliente = cliente;
            ClienteId = clienteId;
        }
    }
}
