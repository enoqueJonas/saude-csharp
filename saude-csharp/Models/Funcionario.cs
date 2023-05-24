﻿using System;

namespace saude_csharp.Models { 

    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Especialidade { get; set; }
        public string Prefixo { get; set; }
        public int Pessoa_id { get; set; }
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

        public Funcionario(
            int id,
            int pessoa_id,
            int especialidade,
            string prefixo
        )
        {
            Id = id;
            Pessoa_id = pessoa_id;
            Prefixo = prefixo;
            Especialidade = especialidade;
        }

        public Funcionario(
                int id,
                int pessoa_id,
                string name,
                string telefone_1,
                string telefone_2,
                string endereco,
                string email,
                string sexo,
                DateTime dataDeNascimento,
                int especialidade,
                string prefixo
            )
        {
            Id = id;
            Pessoa_id = pessoa_id;
            Prefixo = prefixo;
            Especialidade = especialidade;
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