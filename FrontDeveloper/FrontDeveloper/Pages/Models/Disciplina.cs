namespace FrontDeveloper.Pages.Models;

public class Disciplina
{
    public int DisciplinaId { get; set; }
    public string Nome { get; set; }
    public int CargaHoraria { get; set; } // Alterado para int
    public int Semestre { get; set; } // Alterado para int
    public string Descricao { get; set; } // Opcional
   
}
