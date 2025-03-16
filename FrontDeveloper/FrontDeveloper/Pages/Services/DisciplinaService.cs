using System.Collections.Generic;
using System.Linq;
using FrontDeveloper.Pages.Models;

namespace FrontDeveloper.Pages.Services;

public class DisciplinaService
{
    // Lista que armazena as disciplinas cadastradas
    private List<Disciplina> disciplinas = new();

    // Retorna a lista de disciplinas
    public List<Disciplina> GetDisciplinas() => disciplinas;

    // Adiciona uma nova disciplina à lista
    public void AdicionarDisciplina(Disciplina disciplina)
    {
        disciplina.DisciplinaId = disciplinas.Count + 1; // Define um ID único para a disciplina
        disciplinas.Add(disciplina); // Adiciona a disciplina à lista
    }

    // Edita uma disciplina existente na lista
    public void EditarDisciplina(Disciplina disciplina)
    {
        // Busca a disciplina pelo ID
        var existente = disciplinas.Find(d => d.DisciplinaId == disciplina.DisciplinaId);
        if (existente != null)
        {
            // Atualiza os dados da disciplina
            existente.Nome = disciplina.Nome;
            existente.CargaHoraria = disciplina.CargaHoraria;
            existente.Semestre = disciplina.Semestre;
            existente.Descricao = disciplina.Descricao;
        }
    }

    // Remove uma disciplina da lista com base no ID
    public void RemoverDisciplina(int id)
    {
        disciplinas.RemoveAll(d => d.DisciplinaId == id); // Remove a disciplina pelo ID
    }

    // Método para buscar disciplinas pelo nome (ignora maiúsculas e minúsculas)
    public List<Disciplina> BuscarDisciplinaPorNome(string nome)
    {
        // Retorna todas as disciplinas cujo nome contenha o termo informado (case insensitive)
        return disciplinas
            .Where(d => d.Nome.Contains(nome, System.StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}