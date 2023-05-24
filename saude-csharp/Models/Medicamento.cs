using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_csharp.Models
{
    internal class Medicamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeValidade { get; set; }
        public string Descricao { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedByUtilizadorId { get; set; }
        public int CreatedByUtilizadorId { get; set; }
        public Medicamento(int id, string nome, DateTime dataDeValidade, string descricao, DateTime createdAt, DateTime updatedAt, int createdBy, int updatedBy) {
            Id = id;
            Nome = nome;
            DataDeValidade = dataDeValidade;
            Descricao = descricao;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UpdatedByUtilizadorId = updatedBy;
            CreatedByUtilizadorId = createdBy;
        }
    }
}
