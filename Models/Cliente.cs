using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf{ get; set; }
        public  string Rg { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public int Número { get; set; }
        public bool Status { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Observacoes { get; set; }

        public Cliente(int id, string nome, string cpf, string rg, string telefone, string endereco, string complemento, int número, bool status, DateTime dtNascimento, string cep, string pais, string cidade, string bairro, string observacoes)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Endereco = endereco;
            Complemento = complemento;
            Número = número;
            Status = status;
            DtNascimento = dtNascimento;
            Cep = cep;
            Pais = pais;
            Cidade = cidade;
            Bairro = bairro;
            Observacoes = observacoes;
        }

        public Cliente()
        {

        }

        public Cliente(string nome, string cpf, string rg, string telefone, string endereco, bool status, string bairro)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Endereco = endereco;
            Status = status;
            Bairro = bairro;
        }
    }
}
