using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_csharp.Models
{
    internal class Consulta
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoFuncionarioId { get; set; }
        public DateTime Data { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedByUtilizadorId { get; set; }
        public int CreatedByUtilizadorId { get; set; }

        public Consulta(
            int id, 
            int paciente_id, 
            int medico_funcionario_id, 
            DateTime data, 
            string stintomas, 
            string diagnostico, 
            DateTime createdAt, 
            DateTime updatedAt, 
            int createdByUtilizador, 
            int updatedByUtilizador
            ) {
            Id = id;
            PacienteId = paciente_id;
            MedicoFuncionarioId = medico_funcionario_id;
            Data = data;
            Sintomas = stintomas;
            Diagnostico = diagnostico;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            CreatedByUtilizadorId = createdByUtilizador;
            UpdatedByUtilizadorId = updatedByUtilizador;
        }
    }
}
