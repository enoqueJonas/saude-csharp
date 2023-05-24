using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_csharp.Models
{
    internal class Paciente
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedByUtilizadorId { get; set; }
        public int CreatedByUtilizadorId { get; set; }
        public Paciente(int id, int pessoa_id, DateTime createdAt, DateTime updatedAt, int createdBy, int updatedBy)
        {
            Id = id;
            PessoaId = pessoa_id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UpdatedByUtilizadorId = updatedBy;
            CreatedByUtilizadorId = createdBy;
        }
    }
}
