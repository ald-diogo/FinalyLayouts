using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlazorCrud.Pages.Models;

public enum NivelAcesso
{
    Admin,
    Professor,
    Secretaria
}

public enum TipoContrato
{
    Efetivo,
    Temporario,
    Estagiario
}

public class Beneficio
{
    [Key]
    public int BeneficioId { get; set; }
    
    [Required, StringLength(100)]
    public string Nome { get; set; }
}


public class Funcionario
{
    [Key]
    public int FuncionarioId { get; set; }

    [Required, StringLength(100)]
    public string Nome { get; set; }

    [Required, StringLength(20)]
    public string Genero { get; set; }

    // Informações profissionais
    [Required, StringLength(50)]
    public string Cargo { get; set; }

    [Required, StringLength(100)]
    public string Departamento { get; set; }

    [Required]
    public DateTime? DataAdmissao { get; set; }

    [Required]
    public TipoContrato TipoContrato { get; set; }

    [Required]
    public TimeOnly HoraEntrada { get; set; }

    [Required]
    public TimeOnly HoraSaida { get; set; }

    [StringLength(50)]
    public string EstadoCivil { get; set; }

    [Required, StringLength(50)]
    public string Nacionalidade { get; set; }

    [Required, StringLength(20)]
    public string DocumentoIdentificacao { get; set; } // Implementar validação adicional

    [Column(TypeName = "decimal(18,2)")]
    public decimal Salario { get; set; }

    public List<Beneficio> Beneficios { get; set; } = new List<Beneficio>();

    public bool Ativo { get; set; } = true;

    // Credenciais de acesso
    [Required, StringLength(50)]
    public string NomeUsuario { get; set; }

    [Required]
    public byte[] SenhaHash { get; set; }

    public byte[] SenhaSalt { get; set; }

    [Required]
    public NivelAcesso NivelAcesso { get; set; }

    public DateTime? UltimoLogin { get; set; }

    [Required, StringLength(20)]
    [RegularExpression(@"^\d{9,15}$", ErrorMessage = "Número de telefone inválido")]
    public string Telefone { get; set; }

    [StringLength(200)]
    public string Endereco { get; set; }

    [Required, EmailAddress, StringLength(100)]
    public string Email { get; set; }
}

