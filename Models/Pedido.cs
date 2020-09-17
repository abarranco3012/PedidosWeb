using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Display(Name = "Data do Pedido")]
        [DataType(DataType.Date)]
        public DateTime DataPedido { get; set; }

        [Display(Name = "Valor Total")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double ValorTotal { get; set; }

        [Display(Name = "Forma de Entrega")]
        public string FormaEntrega { get; set; }

        [Display(Name = "Endereço de Entrega")]
        public string EnderecoEntrega { get; set; }

        [Display(Name = "Data da Entrega")]
        public DateTime DataEntrega { get; set; }
        public string Obs { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();

        public Pedido()
        {

        }

        public Pedido(int id, DateTime dataPedido, double valorTotal, string formaEntrega, string enderecoEntrega, 
            DateTime dataEntrega, string obs, ICollection<Produto> produtos)
        {
            Id = id;
            DataPedido = dataPedido;
            ValorTotal = valorTotal;
            FormaEntrega = formaEntrega;
            EnderecoEntrega = enderecoEntrega;
            DataEntrega = dataEntrega;
            Obs = obs;
            Produtos = produtos;
        }

        public void AddProdutos(Produto p)
        {
            Produtos.Add(p);
        }

        public void RemoveProdutos(Produto p)
        {
            Produtos.Remove(p);
        }
    }
}
