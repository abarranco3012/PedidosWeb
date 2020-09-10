using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string Obs { get; set; }
        public int Durabilidade { get; set; }
        public string Arquivo { get; set; }
        public Tipos Tipos { get; set; }
        public int TiposId { get; set; }

        public Produtos()
        {

        }

        public Produtos(int id, string nome, string descricao, double valorUnit, string obs, int durabilidade,
            string arquivo, int tiposId)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            ValorUnit = valorUnit;
            Obs = obs;
            Durabilidade = durabilidade;
            Arquivo = arquivo;
            TiposId = tiposId;

        }

    }
}
