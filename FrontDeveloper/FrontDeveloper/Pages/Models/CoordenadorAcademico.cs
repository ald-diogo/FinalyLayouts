namespace FrontDeveloper.Pages.Models;

public class CoordenadorAcademico
{
    public int CoordenadorId { get; set; } 
    
    public string Nome { get; set; } = string.Empty; 
    
    public string Genero { get; set; } = string.Empty;
    
    public DateTime? DataContratacao { get; set; } 
    
    public string Departamento { get; set; } = string.Empty; 
    
    public string CursoResponsavel { get; set; } = string.Empty; 
    
    public string Usuario { get; set; } = string.Empty; 
    
    public string Senha { get; set; } = string.Empty; 
    
    public bool Ativo { get; set; } = true;
    
    public string Telefone { get; set; } = string.Empty; 
    
    public string Morada { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty; 
}