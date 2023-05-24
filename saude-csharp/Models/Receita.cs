using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace saude_csharp.Models
{
    internal class Receita
    {
        public int Id { get; set; }
        public int ConsultaId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedByUtilizadorId { get; set; }
        public int CreatedByUtilizadorId { get; set; }
        public Receita(int id, int consultaId, DateTime createdAt, DateTime updatedAt, int createdBy, int updatedBy) {
            Id = id;
            ConsultaId = consultaId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UpdatedByUtilizadorId = updatedBy;
            CreatedByUtilizadorId = createdBy;
        }
    }
}
