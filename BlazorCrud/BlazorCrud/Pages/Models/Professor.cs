using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Pages.Models;

public class Professor
{
    [Key]
    public int ProfessorId { get; set; }

    [Required, StringLength(100)]
    public string NomeCompleto { get; set; }

    [Required]
    public string Genero { get; set; }

    [Required, DataType(DataType.Date)]
    public DateTime? DataAdmissao { get; set; }

    [Required, StringLength(20)]
    public string NumeroIdentificacao { get; set; } // BI/Passaporte
    
    [Required]
    public string Departamento { get; set; }

    [Required]
    public string DisciplinasLecionadas { get; set; }

    [Required, StringLength(50)]
    public string Nacionalidade { get; set; }

    public string EstadoCivil { get; set; }
    
    [Required]
    public string GrauAcademico { get; set; }
    
    [Required, StringLength(50)]
    public string NumeroFuncionario { get; set; }
    
    [Required]
    public string RegimeTrabalho { get; set; } // Tempo Integral, Parcial, Horista

    public int ExperienciaAnos { get; set; }
    
    [Required, StringLength(50)]
    public string NomeUsuario { get; set; }

    [Required, DataType(DataType.Password)]
    public string Senha { get; set; }

    public bool Ativo { get; set; } = true;
    
    [Required, Phone]
    public string Telefone { get; set; }
    
    public string Endereco { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }
}