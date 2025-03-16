using System.Collections.Generic;
using System.Linq;
using FrontDeveloper.Pages.Models;

namespace FrontDeveloper.Pages.Services;

public class SecretarioService
{
    // Lista que armazena os secretários cadastrados
    private List<Secretario> secretarios = new();

    // Retorna a lista de secretários
    public List<Secretario> GetSecretarios() => secretarios;

    // Adiciona um novo secretário à lista
    public void AdicionarSecretario(Secretario secretario)
    {
        secretario.Id = secretarios.Count + 1; // Define um ID único para o secretário
        secretarios.Add(secretario); // Adiciona o secretário à lista
    }

    // Edita um secretário existente na lista
    public void EditarSecretario(Secretario secretario)
    {
        // Busca o secretário pelo ID
        var existente = secretarios.Find(s => s.Id == secretario.Id);
        if (existente != null)
        {
            // Atualiza os dados do secretário
            existente.NomeCompleto = secretario.NomeCompleto;
            existente.Genero = secretario.Genero;
            existente.DataAdmissao = secretario.DataAdmissao;
            existente.Cargo = secretario.Cargo;
            existente.Departamento = secretario.Departamento;
            existente.CpfNif = secretario.CpfNif;
            existente.Rg = secretario.Rg;
            existente.Salario = secretario.Salario;
            existente.HorarioTrabalho = secretario.HorarioTrabalho;
            existente.NomeUsuario = secretario.NomeUsuario;
            existente.SenhaHash = secretario.SenhaHash;
            existente.StatusConta = secretario.StatusConta;
            existente.Telefone = secretario.Telefone;
            existente.Endereco = secretario.Endereco;
            existente.Email = secretario.Email;
        }
    }

    // Remove um secretário da lista com base no ID
    public void RemoverSecretario(int id)
    {
        secretarios.RemoveAll(s => s.Id == id); // Remove o secretário pelo ID
    }

    // Método para buscar secretários pelo nome (ignora maiúsculas e minúsculas)
    public List<Secretario> BuscarSecretarioPorNome(string nome)
    {
        // Retorna todos os secretários cujo nome contenha o termo informado (case insensitive)
        return secretarios
            .Where(s => s.NomeCompleto.Contains(nome, System.StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // Método para buscar um secretário pelo CPF/NIF
    public Secretario BuscarPorCpfNif(string cpfNif)
    {
        return secretarios.FirstOrDefault(s => s.CpfNif == cpfNif);
    }
}
