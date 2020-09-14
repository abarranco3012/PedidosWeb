using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public double ValorTotal { get; set; }
        public string FormaEntrega { get; set; }
        public string EnderecoEntrega { get; set; }
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
