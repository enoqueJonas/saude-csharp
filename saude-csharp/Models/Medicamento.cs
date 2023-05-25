using System;
using System.Collections.Generic;

namespace pcsharp_saude.Models
{
    public class Medicamento
    {
        private Int32 _id;

        //metadata
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Utilizador? _createdBy;
        private Utilizador? _updatedBy;
        public List<Receita>? Receitas { get; set; } 
        public string? Nome { get; set; }
        public DateTime DataValidade { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }

        public Int32 Id
        {
            get => _id;
            set => _id = value;
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
