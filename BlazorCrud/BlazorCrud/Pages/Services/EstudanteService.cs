using System.Collections.Generic;
using System.Linq;
using BlazorCrud.Pages.Models;

namespace BlazorCrud.Pages.Services
{
    // Classe responsável pelo gerenciamento dos estudantes
    public class EstudanteService
    {
        // Lista privada que armazena os estudantes
        private List<Estudante> estudantes = new();

        // Método que retorna a lista de estudantes cadastrados
        public List<Estudante> GetEstudantes() => estudantes;

        // Método para adicionar um novo estudante à lista
        public void AdicionarEstudante(Estudante estudante)
        {
            // Define um ID único para o estudante baseado no tamanho da lista
            estudante.Id = estudantes.Count + 1;
            
            // Adiciona o estudante à lista
            estudantes.Add(estudante);
        }

        // Método para editar os dados de um estudante existente
        public void EditarEstudante(Estudante estudante)
        {
            // Procura o estudante na lista pelo ID
            var existente = estudantes.Find(e => e.Id == estudante.Id);
            
            // Se o estudante existir, atualiza seus dados
            if (existente != null)
            {
                existente.Nome = estudante.Nome;
                existente.Genero = estudante.Genero;
                existente.DataNascimento = estudante.DataNascimento;
                existente.Curso = estudante.Curso;
                existente.Periodo = estudante.Periodo;
                existente.Sala = estudante.Sala;
                existente.Turma = estudante.Turma;
                existente.Classe = estudante.Classe;
                existente.AnoFrequencia = estudante.AnoFrequencia;
                existente.Telefone = estudante.Telefone;
                existente.Morada = estudante.Morada;
                existente.Email = estudante.Email;
            }
        }

        // Método para remover um estudante da lista pelo ID
        public void RemoverEstudante(int id)
        {
            // Remove todos os estudantes que tenham o ID fornecido
            estudantes.RemoveAll(e => e.Id == id);
        }

        // Método para buscar estudantes pelo nome (ignora maiúsculas e minúsculas)
        public List<Estudante> BuscarEstudantePorNome(string nome)
        {
            // Retorna todos os estudantes cujo nome contenha o termo informado (case insensitive)
            return estudantes
                .Where(e => e.Nome.Contains(nome, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}


