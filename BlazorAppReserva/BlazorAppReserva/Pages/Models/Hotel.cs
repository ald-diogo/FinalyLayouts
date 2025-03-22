using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppReserva.Models;

public class Hotel
{
    [Key]
    public int Id { get; set; } // Identificador único do hotel

    [Required, StringLength(100)]
    public string Nome { get; set; } // Nome do hotel

    [Range(1, 5)]
    public int Categoria { get; set; } // Quantidade de estrelas (1 a 5)
    

    [Required, StringLength(50)]
    public string Cidade { get; set; } // Cidade onde o hotel está localizado

    [Required, StringLength(50)]
    public string Pais { get; set; } // País onde o hotel está localizado

    [Phone]
    public string Telefone { get; set; } // Telefone de contato
    
    [Required, StringLength(200)]
    public string Endereco { get; set; } // Endereço completo

    [EmailAddress]
    public string Email { get; set; } // E-mail para reservas e contato

    public string Descricao { get; set; } // Breve descrição sobre o hotel

    [Column(TypeName = "decimal(10,2)")]
    public decimal PrecoPorNoite { get; set; } // Preço médio por noite

    public bool Wifi { get; set; } // Indica se o hotel oferece Wi-Fi gratuito
    public bool Estacionamento { get; set; } // Indica se há estacionamento disponível
    public bool Piscina { get; set; } // Indica se há piscina no hotel
    public bool Restaurante { get; set; } // Indica se há restaurante no hotel
}





