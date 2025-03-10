namespace BlazorCrud.Pages.Models;

public class Estudante
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Genero { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string Curso { get; set; }
    public string Periodo { get; set; }
    public string Sala { get; set; }
    public string Turma { get; set; }
    public string Classe { get; set; }
    public int AnoFrequencia { get; set; }
    public string Telefone { get; set; }
    public string Morada { get; set; }
    public string Email { get; set; }
}
