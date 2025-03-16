using System.Collections.Generic;
using System.Linq;
using FrontDeveloper.Pages.Models;

namespace FrontDeveloper.Pages.Services;

public class ConsultorService
{
    // Lista que armazena os consultores cadastrados
    private List<Consultor> consultores = new();

    // Retorna a lista de consultores
    public List<Consultor> GetConsultores() => consultores;

    // Adiciona um novo consultor à lista
    public void AdicionarConsultor(Consultor consultor)
    {
        consultor.ConsultorId = consultores.Count + 1; // Define um ID único para o consultor
        consultores.Add(consultor); // Adiciona o consultor à lista
    }

    // Edita um consultor existente na lista
    public void EditarConsultor(Consultor consultor)
    {
        // Busca o consultor pelo ID
        var existente = consultores.Find(c => c.ConsultorId == consultor.ConsultorId);
        if (existente != null)
        {
            // Atualiza os dados do consultor
            existente.Nome = consultor.Nome;
            existente.Genero = consultor.Genero;
            existente.DataContratacao = consultor.DataContratacao;
            existente.Cargo = consultor.Cargo;
            existente.Especializacao = consultor.Especializacao;
            existente.Departamento = consultor.Departamento;
            existente.Salario = consultor.Salario;
            existente.RegimeTrabalho = consultor.RegimeTrabalho;
            existente.UsuarioSistema = consultor.UsuarioSistema;
            existente.NivelAcesso = consultor.NivelAcesso;
            existente.Telefone = consultor.Telefone;
            existente.Endereco = consultor.Endereco;
            existente.Email = consultor.Email;
        }
    }

    // Remove um consultor da lista com base no ID
    public void RemoverConsultor(int id)
    {
        consultores.RemoveAll(c => c.ConsultorId == id); // Remove o consultor pelo ID
    }
    
    // Método para buscar consultores pelo nome (ignora maiúsculas e minúsculas)
    public List<Consultor> BuscarConsultorPorNome(string nome)
    {
        // Retorna todos os consultores cujo nome contenha o termo informado (case insensitive)
        return consultores
            .Where(c => c.Nome.Contains(nome, System.StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}