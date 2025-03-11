using System.Collections.Generic;
using System.Linq;
using BlazorCrud.Pages.Models;

namespace BlazorCrud.Pages.Services;

public class ProfessorService
{
    // Lista que armazena os professores cadastrados
    private List<Professor> professores = new();

    // Retorna a lista de professores
    public List<Professor> GetProfessores() => professores;

    // Adiciona um novo professor à lista
    public void AdicionarProfessor(Professor professor)
    {
        professor.ProfessorId = professores.Count + 1; // Define um ID único
        professores.Add(professor); // Adiciona à lista
    }

    // Edita um professor existente na lista
    public void EditarProfessor(Professor professor)
    {
        var existente = professores.Find(p => p.ProfessorId == professor.ProfessorId);
        if (existente != null)
        {
            existente.NomeCompleto = professor.NomeCompleto;
            existente.Genero = professor.Genero;
            existente.DataAdmissao = professor.DataAdmissao;
            existente.NumeroIdentificacao = professor.NumeroIdentificacao;
            existente.Departamento = professor.Departamento;
            existente.DisciplinasLecionadas = professor.DisciplinasLecionadas;
            existente.Nacionalidade = professor.Nacionalidade;
            existente.EstadoCivil = professor.EstadoCivil;
            existente.GrauAcademico = professor.GrauAcademico;
            existente.NumeroFuncionario = professor.NumeroFuncionario;
            existente.RegimeTrabalho = professor.RegimeTrabalho;
            existente.ExperienciaAnos = professor.ExperienciaAnos;
            existente.NomeUsuario = professor.NomeUsuario;
            existente.Senha = professor.Senha;
            existente.Ativo = professor.Ativo;
            existente.Telefone = professor.Telefone;
            existente.Endereco = professor.Endereco;
            existente.Email = professor.Email;
        }
    }

    // Remove um professor da lista com base no ID
    public void RemoverProfessor(int id)
    {
        professores.RemoveAll(p => p.ProfessorId == id);
    }
    
    // Método para buscar professores pelo nome (ignora maiúsculas e minúsculas)
    public List<Professor> BuscarProfessorPorNome(string nome)
    {
        return professores
            .Where(p => p.NomeCompleto.Contains(nome, System.StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
