using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Compl { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Ddd { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNasc { get; set; }
        public string Conjuge { get; set; }
        public string Obs { get; set; }
        public ICollection<Filho> Filhos { get; set; } = new List<Filho>();

        public Cliente()
        {

        }

        public Cliente(int id, string nome, string endereco, string numero, string compl, string bairro, string cidade, string uf, string ddd, 
            string telefone, DateTime dtNasc, string conjuge, string obs)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Numero = numero;
            Compl = compl;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Ddd = ddd;
            Telefone = telefone;
            DtNasc = dtNasc;
            Conjuge = conjuge;
            Obs = obs;
        }

        public void AddFilhos(Filho f)
        {
            Filhos.Add(f);
        }

        public void RemoveFilhos(Filho f)
        {
            Filhos.Remove(f);
        }
    }
}
