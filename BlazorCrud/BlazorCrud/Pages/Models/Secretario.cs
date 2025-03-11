using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Pages.Models;

public class Secretario
{
     [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome completo é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
    public string NomeCompleto { get; set; }

    [Required(ErrorMessage = "O gênero é obrigatório.")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A data de admissão é obrigatória.")]
    [DataType(DataType.Date)]
    public DateTime? DataAdmissao { get; set; }
    
    [Required]
    public string Cargo { get; set; } = "Secretário Acadêmico";
    
    [Required(ErrorMessage = "O departamento é obrigatório.")]
    public string Departamento { get; set; } = "Secretaria Acadêmica";

    [Required(ErrorMessage = "O CPF/NIF é obrigatório.")]
    [StringLength(14, ErrorMessage = "CPF/NIF inválido.")]
    public string CpfNif { get; set; }

    [StringLength(20, ErrorMessage = "RG inválido.")]
    public string Rg { get; set; }
    
    [Required(ErrorMessage = "O salário é obrigatório.")]
    [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser positivo.")]
    public decimal Salario { get; set; }
    
    [Required(ErrorMessage = "O horário de trabalho é obrigatório.")]
    public string HorarioTrabalho { get; set; }
    
    [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
    [StringLength(50, ErrorMessage = "O nome de usuário deve ter no máximo 50 caracteres.")]
    public string NomeUsuario { get; set; }

    [Required(ErrorMessage = "A senha é obrigatória.")]
    public string SenhaHash { get; set; } // Armazena a senha criptografada

    public DateTime UltimoAcesso { get; set; }

    public bool StatusConta { get; set; } = true; // Conta ativa por padrão

    [Required(ErrorMessage = "O telefone é obrigatório.")]
    [Phone(ErrorMessage = "Número de telefone inválido.")]
    public string Telefone { get; set; }
    
    [Required(ErrorMessage = "O endereço é obrigatório.")]
    public string Endereco { get; set; }

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "E-mail inválido.")]
    public string Email { get; set; }
}