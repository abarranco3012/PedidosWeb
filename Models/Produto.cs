using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string Obs { get; set; }
        public int Durabilidade { get; set; }
        public string Arquivo { get; set; }
        public Tipo Tipo { get; set; }
        public int TipoId { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, string descricao, double valorUnit, string obs, int durabilidade,
            string arquivo, int tipoId)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            ValorUnit = valorUnit;
            Obs = obs;
            Durabilidade = durabilidade;
            Arquivo = arquivo;
            TipoId = tipoId;

        }

    }
}
