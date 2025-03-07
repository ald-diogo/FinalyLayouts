using System;
using System.Collections.Generic;
using FrontDeveloper.Models;

namespace FrontDeveloper.Pages.Admin
{
    public class EstudanteService
    {
        public List<Estudante> Estudantes { get; private set; } = new List<Estudante>();
        public event Action? OnChange;

        public void AdicionarEstudante(Estudante estudante)
        {
            Estudantes.Add(estudante);
            OnChange?.Invoke(); // Notifica mudanças
        }

        public void RemoverEstudante(Estudante estudante)
        {
            Estudantes.Remove(estudante);
            OnChange?.Invoke(); // Notifica mudanças após remoção
        }
    }
}