using System.Collections.Generic;
using System.Linq;
using FrontDeveloper.Pages.Models;

namespace FrontDeveloper.Pages.Services;

public class CoordenadorAcademicoService
{
    // Lista que armazena os coordenadores cadastrados
    private List<CoordenadorAcademico> coordenadores = new();

    // Retorna a lista de coordenadores
    public List<CoordenadorAcademico> GetCoordenadores() => coordenadores;

    // Adiciona um novo coordenador à lista
    public void AdicionarCoordenador(CoordenadorAcademico coordenador)
    {
        coordenador.CoordenadorId = coordenadores.Count + 1; // Define um ID único para o coordenador
        coordenadores.Add(coordenador); // Adiciona o coordenador à lista
    }

    // Edita um coordenador existente na lista
    public void EditarCoordenador(CoordenadorAcademico coordenador)
    {
        // Busca o coordenador pelo ID
        var existente = coordenadores.Find(c => c.CoordenadorId == coordenador.CoordenadorId);
        if (existente != null)
        {
            // Atualiza os dados do coordenador
            existente.Nome = coordenador.Nome;
            existente.Genero = coordenador.Genero;
            existente.DataContratacao = coordenador.DataContratacao;
            existente.Departamento = coordenador.Departamento;
            existente.CursoResponsavel = coordenador.CursoResponsavel;
            existente.Usuario = coordenador.Usuario;
            existente.Senha = coordenador.Senha;
            existente.Ativo = coordenador.Ativo;
            existente.Telefone = coordenador.Telefone;
            existente.Morada = coordenador.Morada;
            existente.Email = coordenador.Email;
        }
    }

    // Remove um coordenador da lista com base no ID
    public void RemoverCoordenador(int id)
    {
        coordenadores.RemoveAll(c => c.CoordenadorId == id); // Remove o coordenador pelo ID
    }
    
    // Método para buscar coordenadores pelo nome (ignora maiúsculas e minúsculas)
    public List<CoordenadorAcademico> BuscarCoordenadorPorNome(string nome)
    {
        // Retorna todos os coordenadores cujo nome contenha o termo informado (case insensitive)
        return coordenadores
            .Where(c => c.Nome.Contains(nome, System.StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
