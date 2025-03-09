using System;
using System.Collections.Generic;
using FrontDeveloper.Context;
using FrontDeveloper.Models;
using System.Linq;
using FrontDeveloper.Pages.Admin.Cadastro;

namespace FrontDeveloper.Pages.Admin
{
    public class EstudanteService  : IEstudanteService
    {
        //Aplicando o CRUD
        private readonly DataBaseContext _context;

        public EstudanteService(DataBaseContext context)
        {
            _context = context;
        }
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
        
        //Outros Metodos
        public List<ListaEstudantes.Estudante> GetEstudantes()
        {
            return _context.Estudantes.ToHashSet();
        }

        public  Estudante GetById(int estudanteId)
        {
            throw new NotImplementedException();
        }

        public void Save(Estudante estudante)
        {
            if(estudante.EstudanteId == 0) _context.Estudantes.Add(estudante);
            else _context.Estudantes.Update(estudante);
            _context.SaveChanges();
        }

        public string Delete(int EstudanteId)
        {
            throw new NotImplementedException();
        }
    }
}