using FrontDeveloper.Context;
using FrontDeveloper.Models;
using FrontDeveloper.Pages.Admin.Cadastro;
using FrontDeveloper.Pages.Admin.Cadastro.Usuarios;

namespace FrontDeveloper.Pages.Admin;

public interface  IEstudanteService
{ 
    List<ListaEstudantes.Estudante> GetEstudantes();
   
    Estudante GetById(int estudanteId);
   
   void Save(Estudante estudante);
   string Delete(int EstudanteId);
   
}

