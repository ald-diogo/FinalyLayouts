namespace BlazorCrud.Pages.Models;

public class Coordenador
{
    public int CoordenadorId { get; set; }
    public string NomeCompleto { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Morada { get; set; } = string.Empty;
    public string Matricula { get; set; } = string.Empty;
    public string Departamento { get; set; } = string.Empty;
    public List<string> CursosCoordenados { get; set; } = new();
    public DateTime? DataAdmissao { get; set; }
    public string Status { get; set; } = "Ativo";
    public string Cargo { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public DateTime? UltimoLogin { get; set; }
    public int Id { get; set; }
}