using System;
using System.ComponentModel.DataAnnotations;

namespace FrontDeveloper.Pages.Models
{
    public class Consultor
    {
        [Key]
        public int ConsultorId { get; set; }

        // Dados Pessoais
        [Required, StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime? DataContratacao { get; set; }
        
        // Dados Profissionais
        [Required]
        public string Cargo { get; set; } = "Consultor Financeiro";

        [Required]
        public string Especializacao { get; set; }

        [Required]
        public string Departamento { get; set; } = "Financeiro";
        
        [Required, Range(0, double.MaxValue)]
        public decimal Salario { get; set; }

        [Required]
        public string RegimeTrabalho { get; set; } // CLT, Freelancer, etc.
        
        // Permissões no Sistema
        public string UsuarioSistema { get; set; }
        public string NivelAcesso { get; set; } = "Financeiro";

        [Required, Phone]
        public string Telefone { get; set; }
        
        [Required, StringLength(200)]
        public string Endereco { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}