using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CodBarras { get; set; }
        public double ValCompra { get; set; }
        public double ValVenda { get; set; }
        public int Estoque { get; set; }
        public string Referencia { get; set; }
        public string Observacoes { get; set; }

        public Produto(int id, string descricao, int codBarras, double valCompra, double valVenda, int estoque, string referencia, string observacoes)
        {
            Id = id;
            Descricao = descricao;
            CodBarras = codBarras;
            ValCompra = valCompra;
            ValVenda = valVenda;
            Estoque = estoque;
            Referencia = referencia;
            Observacoes = observacoes;
        }
        public Produto(int id, string descricao, double valCompra, double valVenda, int estoque)
        {
            Id = id;
            Descricao = descricao;
            ValCompra = valCompra;
            ValVenda = valVenda;
            Estoque = estoque;
        }

        public Produto()
        {

        }
    }
}
