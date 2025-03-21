using System;
using System.Collections.Generic;
using System.Linq;
using BlazorAppReserva.Models;

namespace BlazorAppReserva.Pages.Services;

public class HotelService
{
    // Lista que armazena os hotéis cadastrados
    private List<Hotel> hoteis = new();

    // Retorna a lista de hotéis
    public List<Hotel> GetHoteis() => hoteis;

    // Adiciona um novo hotel à lista
    public void AdicionarHotel(Hotel hotel)
    {
        hotel.Id = hoteis.Count + 1; // Define um ID único para o hotel
        hoteis.Add(hotel); // Adiciona o hotel à lista
    }

    // Edita um hotel existente na lista
    public void EditarHotel(Hotel hotel)
    {
        // Busca o hotel pelo ID
        var existente = hoteis.Find(h => h.Id == hotel.Id);
        if (existente != null)
        {
            // Atualiza os dados do hotel
            existente.Nome = hotel.Nome;
            existente.Categoria = hotel.Categoria;
            existente.Endereco = hotel.Endereco;
            existente.Cidade = hotel.Cidade;
            existente.Pais = hotel.Pais;
            existente.Telefone = hotel.Telefone;
            existente.Email = hotel.Email;
            existente.Descricao = hotel.Descricao;
            existente.PrecoPorNoite = hotel.PrecoPorNoite;
            existente.Wifi = hotel.Wifi;
            existente.Estacionamento = hotel.Estacionamento;
            existente.Piscina = hotel.Piscina;
            existente.Restaurante = hotel.Restaurante;
        }
    }

    // Remove um hotel da lista com base no ID
    public void RemoverHotel(int id)
    {
        hoteis.RemoveAll(h => h.Id == id); // Remove o hotel pelo ID
    }

    // Método para buscar hotéis pelo nome (ignora maiúsculas e minúsculas)
    public List<Hotel> BuscarHotelPorNome(string nome)
    {
        return hoteis
            .Where(h => h.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
