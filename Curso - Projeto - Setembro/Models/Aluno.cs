﻿namespace Curso___Projeto___Setembro.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; } 
        public string Telefone { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
    }
}