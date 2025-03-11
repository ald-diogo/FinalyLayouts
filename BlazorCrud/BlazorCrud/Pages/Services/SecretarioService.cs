using System;
using System.Collections.Generic;
using System.Linq;
using BlazorCrud.Pages.Models;

namespace BlazorCrud.Pages.Services;

public class SecretarioService
{
    // Lista que armazena os secretários cadastrados
    private List<Secretario> secretarios = new();

    // Retorna a lista de secretários
    public List<Secretario> GetSecretarios() => secretarios;

    // Adiciona um novo secretário à lista
    public void AdicionarSecretario(Secretario secretario)
    {
        secretario.Id = secretarios.Count + 1; // Define um ID único
        secretario.UltimoAcesso = DateTime.UtcNow; // Define o último acesso como a data atual
        secretarios.Add(secretario); // Adiciona à lista
    }

    // Edita um secretário existente na lista
    public void EditarSecretario(Secretario secretario)
    {
        var existente = secretarios.Find(s => s.Id == secretario.Id);
        if (existente != null)
        {
            // Atualiza os dados do secretário
            existente.NomeCompleto = secretario.NomeCompleto;
            existente.Genero = secretario.Genero;
            existente.DataAdmissao = secretario.DataAdmissao;
            existente.CpfNif = secretario.CpfNif;
            existente.Rg = secretario.Rg;
            existente.Salario = secretario.Salario;
            existente.HorarioTrabalho = secretario.HorarioTrabalho;
            existente.NomeUsuario = secretario.NomeUsuario;
            existente.SenhaHash = secretario.SenhaHash;
            existente.Telefone = secretario.Telefone;
            existente.Endereco = secretario.Endereco;
            existente.Email = secretario.Email;
            existente.StatusConta = secretario.StatusConta;
        }
    }

    // Remove um secretário da lista pelo ID
    public void RemoverSecretario(int id)
    {
        secretarios.RemoveAll(s => s.Id == id);
    }

    // Busca secretários pelo nome (ignora maiúsculas e minúsculas)
    public List<Secretario> BuscarSecretarioPorNome(string nome)
    {
        return secretarios
            .Where(s => s.NomeCompleto.Contains(nome, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
