using System.Collections.Generic;
using FrontDeveloper.Pages.Models;

namespace FrontDeveloper.Pages.Services;

public class EstudanteService
{
    private List<Estudante> estudantes = new();

    public List<Estudante> GetEstudantes() => estudantes;

    public void AdicionarEstudante(Estudante estudante)
    {
        estudante.Id = estudantes.Count + 1;
        estudantes.Add(estudante);
    }

    public void EditarEstudante(Estudante estudante)
    {
        var existente = estudantes.Find(e => e.Id == estudante.Id);
        if (existente != null)
        {
            existente.Nome = estudante.Nome;
            existente.Genero = estudante.Genero;
            existente.DataNascimento = estudante.DataNascimento;
            existente.Curso = estudante.Curso;
            existente.Periodo = estudante.Periodo;
            existente.Sala = estudante.Sala;
            existente.Turma = estudante.Turma;
            existente.Classe = estudante.Classe;
            existente.AnoFrequencia = estudante.AnoFrequencia;
            existente.Telefone = estudante.Telefone;
            existente.Morada = estudante.Morada;
            existente.Email = estudante.Email;
        }
    }

    public void RemoverEstudante(int id)
    {
        estudantes.RemoveAll(e => e.Id == id);
    }
    
}
