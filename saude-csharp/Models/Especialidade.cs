using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_csharp.Models
{
    internal class Especialidade
    {
        public int Id { get; }
        public string Designacao { get; }
        public Especialidade(int id, string designacao)
        {
            Id = id;
            Designacao = designacao;
        }
    }
}
