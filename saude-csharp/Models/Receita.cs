using System;
using System.Collections.Generic;

namespace pcsharp_saude.Models
{
    public class Receita
    {
        private Int32 _id;
        private Consulta _consulta;

        //metadata
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Utilizador? _createdBy;
        private Utilizador? _updatedBy;
         public List<Medicamento>? Medicamentos { get; set; }
        public Int32 Id
        {
            get => _id;
            set => _id = value;
        }

        public Consulta Consulta
        {
            get => _consulta;
            set => _consulta = value ?? throw new ArgumentNullException(nameof(value));
        }
        public DateTime CreatedAt
        {
            get => _createdAt;
            set => _createdAt = value;
        }

        public DateTime UpdatedAt
        {
            get => _updatedAt;
            set => _updatedAt = value;
        }

        public Utilizador CreatedBy
        {
            get => _createdBy;
            set => _createdBy = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Utilizador UpdatedBy
        {
            get => _updatedBy;
            set => _updatedBy = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
