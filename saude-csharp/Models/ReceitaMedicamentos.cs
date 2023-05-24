using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_csharp.Models
{
    internal class ReceitaMedicamentos
    {
        public int ReceitaID { get; set; }
        public int MedicamentoID { get; set; }
        public int Quantidade { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedByUtilizadorId { get; set; }
        public int CreatedByUtilizadorId { get; set; }

        public ReceitaMedicamentos(int receita_id, int medicamento_id, int qtd, DateTime createdAt, DateTime updatedAt, int createdBy, int updatedBy) { 
            ReceitaID = receita_id;
            MedicamentoID = medicamento_id;
            Quantidade = qtd;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UpdatedByUtilizadorId = updatedBy;
            CreatedByUtilizadorId = createdBy;
        }
    }
}
