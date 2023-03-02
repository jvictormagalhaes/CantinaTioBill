using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    public class Usuario
    {
        int i = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }

        public Usuario(string nome, string username, string senha, bool status)
        {
            Id = i++;
            Nome = nome;
            Username = username;
            Senha = senha;
            Status = status;
        }

        public Usuario()
        {

        }
    }
}
