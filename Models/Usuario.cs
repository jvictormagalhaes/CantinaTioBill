using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }

        public Usuario(int id, string nome, string username, string senha, bool status)
        {
            Id = id;
            Nome = nome;
            Username = username;
            Senha = senha;
            Status = status;
        }
    }
}
