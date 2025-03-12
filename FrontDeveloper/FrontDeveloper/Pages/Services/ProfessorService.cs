using System.Collections.Generic;
using System.Linq;
using FrontDeveloper.Pages.Models;

namespace FrontDeveloper.Pages.Services;

public class ProfessorService
{
    // Lista que armazena os professores cadastrados
    private List<Professor> professores = new();

    // Retorna a lista de professores
    public List<Professor> GetProfessores() => professores;

    // Adiciona um novo professor à lista
    public void AdicionarProfessor(Professor professor)
    {
        professor.ProfessorId = professores.Count + 1; // Define um ID único para o professor
        professores.Add(professor); // Adiciona o professor à lista
    }

    // Edita um professor existente na lista
    public void EditarProfessor(Professor professor)
    {
        // Busca o professor pelo ID
        var existente = professores.Find(p => p.ProfessorId == professor.ProfessorId);
        if (existente != null)
        {
            // Atualiza os dados do professor
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
        professores.RemoveAll(p => p.ProfessorId == id); // Remove o professor pelo ID
    }
    
    // Método para buscar professores pelo nome (ignora maiúsculas e minúsculas)
    public List<Professor> BuscarProfessorPorNome(string nome)
    {
        // Retorna todos os professores cujo nome contenha o termo informado (case insensitive)
        return professores
            .Where(p => p.NomeCompleto.Contains(nome, System.StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}