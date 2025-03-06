using System.Collections.Generic;
using FrontDeveloper.Models;
using FrontDeveloper.Pages.Admin;

namespace FrontDeveloper.Pages.Admin;

public class EstudanteService
{
    public List<Estudante> Estudantes { get; private set; } = new List<Estudante>();

    public void AdicionarEstudante(Estudante estudante)
    {
        Estudantes.Add(estudante);
    }
}