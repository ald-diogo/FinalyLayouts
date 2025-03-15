using System.Collections.Generic;
using System.Linq;
using FrontDeveloper.Pages.Models;

namespace FrontDeveloper.Pages.Services;

public class FuncionarioService
{
    // Lista que armazena os funcionários cadastrados
    private List<Funcionario> funcionarios = new();

    // Retorna a lista de funcionários
    public List<Funcionario> GetFuncionarios() => funcionarios;

    // Adiciona um novo funcionário à lista
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionario.FuncionarioId = funcionarios.Count + 1; // Define um ID único
        funcionarios.Add(funcionario);
    }

    // Edita um funcionário existente na lista
    public void EditarFuncionario(Funcionario funcionario)
    {
        // Busca o funcionário pelo ID
        var existente = funcionarios.Find(f => f.FuncionarioId == funcionario.FuncionarioId);
        if (existente != null)
        {
            // Atualiza os dados do funcionário
            existente.Nome = funcionario.Nome;
            existente.Genero = funcionario.Genero;
            existente.Cargo = funcionario.Cargo;
            existente.Departamento = funcionario.Departamento;
            existente.DataAdmissao = funcionario.DataAdmissao;
            existente.TipoContrato = funcionario.TipoContrato;
            existente.HoraEntrada = funcionario.HoraEntrada;
            existente.HoraSaida = funcionario.HoraSaida;
            existente.EstadoCivil = funcionario.EstadoCivil;
            existente.Nacionalidade = funcionario.Nacionalidade;
            existente.DocumentoIdentificacao = funcionario.DocumentoIdentificacao;
            existente.Salario = funcionario.Salario;
            existente.Beneficios = funcionario.Beneficios;
            existente.Ativo = funcionario.Ativo;
            existente.NomeUsuario = funcionario.NomeUsuario;
            existente.SenhaHash = funcionario.SenhaHash;
            existente.SenhaSalt = funcionario.SenhaSalt;
            existente.NivelAcesso = funcionario.NivelAcesso;
            existente.UltimoLogin = funcionario.UltimoLogin;
            existente.Telefone = funcionario.Telefone;
            existente.Endereco = funcionario.Endereco;
            existente.Email = funcionario.Email;
        }
    }

    // Remove um funcionário da lista com base no ID
    public void RemoverFuncionario(int id)
    {
        funcionarios.RemoveAll(f => f.FuncionarioId == id);
    }
    
    // Método para buscar funcionários pelo nome (ignora maiúsculas e minúsculas)
    public List<Funcionario> BuscarFuncionarioPorNome(string nome)
    {
        return funcionarios
            .Where(f => f.Nome.Contains(nome, System.StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}