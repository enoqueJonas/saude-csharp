using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_csharp.Models
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telefone_1 { get; set; }
        public string Telefone_2 { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime ModifiedBy { get; set; }
        public DateTime CreatedBy { get; set; }

        public Pessoa(
            int id,
            string name,
            string telefone_1,
            string telefone_2,
            string endereco,
            string email,
            string sexo,
            DateTime dataDeNascimento
        )
        {
            Id = id;
            Name = name;
            Telefone_1 = telefone_1;
            Telefone_2 = telefone_2;
            Endereco = endereco;
            Email = email;
            Sexo = sexo;
            DataDeNascimento = dataDeNascimento;
        }
    }
}
