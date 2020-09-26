using System;
using System.ComponentModel.DataAnnotations;
using PlataformaNetworking.Models.Enums;

namespace PlataformaNetworking.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        [Display(Name = "DataNascimento")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public string Curso { get; set; }
        public int CursoId { get; set; }
        public int AnoIngresso { get; set; }
        public int Semestre { get; set; }
        public string Senha { get; set; }
        public Situacao Situacao { get; set; }

        public string ProfilePictureUrl { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string nome, string sobrenome, string email, DateTime dataNascimento, string curso, int cursoId, int anoIngresso, int semestre, string senha, Situacao situacao)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            Curso = curso;
            AnoIngresso = anoIngresso;
            Semestre = semestre;
            Senha = senha;
            Situacao = situacao;
        }
    }
}
