using System.Collections.Generic;
using FrontDeveloper.Pages.Models;

namespace FrontDeveloper.Pages.Services;

public class EstudanteService
{
    // Lista que armazena os estudantes cadastrados
    private List<Estudante> estudantes = new();

    // Retorna a lista de estudantes
    public List<Estudante> GetEstudantes() => estudantes;

    // Adiciona um novo estudante à lista
    public void AdicionarEstudante(Estudante estudante)
    {
        estudante.Id = estudantes.Count + 1; // Define um ID único para o estudante
        estudantes.Add(estudante); // Adiciona o estudante à lista
    }

    // Edita um estudante existente na lista
    public void EditarEstudante(Estudante estudante)
    {
        // Busca o estudante pelo ID
        var existente = estudantes.Find(e => e.Id == estudante.Id);
        if (existente != null)
        {
            // Atualiza os dados do estudante
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

    // Remove um estudante da lista com base no ID
    public void RemoverEstudante(int id)
    {
        estudantes.RemoveAll(e => e.Id == id); // Remove o estudante pelo ID
    }
}

