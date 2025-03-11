using System;
using System.Collections.Generic;
using System.Linq;
using BlazorCrud.Pages.Models;

namespace BlazorCrud.Pages.Services;

public class CoordenadorService
{
    // Lista que armazena os coordenadores cadastrados
    private List<Coordenador> coordenadores = new();

    // Retorna a lista de coordenadores
    public List<Coordenador> GetCoordenadores() => coordenadores;

    // Adiciona um novo coordenador à lista
    public void AdicionarCoordenador(Coordenador coordenador)
    {
        coordenador.CoordenadorId = coordenadores.Count + 1; // Define um ID único
        coordenadores.Add(coordenador); // Adiciona o coordenador à lista
    }

    // Edita um coordenador existente na lista
    public void EditarCoordenador(Coordenador coordenador)
    {
        // Busca o coordenador pelo ID
        var existente = coordenadores.Find(c => c.CoordenadorId == coordenador.CoordenadorId);
        if (existente != null)
        {
            // Atualiza os dados do coordenador
            existente.NomeCompleto = coordenador.NomeCompleto;
            existente.Genero = coordenador.Genero;
            
            existente.Departamento = coordenador.Departamento;
            
            existente.Cargo = coordenador.Cargo;
            
            existente.Matricula = coordenador.Matricula;
            
            existente.DataAdmissao = coordenador.DataAdmissao;
            
            existente.Status = coordenador.Status;
            
            existente.Username = coordenador.Username;
            existente.UltimoLogin = coordenador.UltimoLogin;
            
            existente.Telefone = coordenador.Telefone;
            
            existente.Morada = coordenador.Morada;
            
            existente.Email = coordenador.Email;
            
            existente.CursosCoordenados = coordenador.CursosCoordenados;
        }
    }

    // Remove um coordenador da lista com base no ID
    public void RemoverCoordenador(int id)
    {
        coordenadores.RemoveAll(c => c.CoordenadorId == id); // Remove pelo ID
    }

    // Busca coordenadores pelo nome (ignora maiúsculas e minúsculas)
    public List<Coordenador> BuscarCoordenadorPorNome(string nome)
    {
        return coordenadores
            .Where(c => c.NomeCompleto.Contains(nome, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // Busca coordenadores pelo departamento
    public List<Coordenador> BuscarPorDepartamento(string departamento)
    {
        return coordenadores
            .Where(c => c.Departamento.Contains(departamento, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}