using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Valor Unitário")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double ValorUnit { get; set; }
        public string Obs { get; set; }
        public int Durabilidade { get; set; }

        [Display(Name = "")]
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
