using FrontDeveloper.Context;
using FrontDeveloper.Models;
using FrontDeveloper.Pages.Admin.Cadastro.Usuarios;

namespace FrontDeveloper.Pages.Admin;

public partial class EstudanteService : IEstudanteService
{
   private readonly DataBaseContext dataBaseContext;

   public HashSet<Estudante> GetEstudantes()
   {
      throw new NotImplementedException();
   }

   public Estudante GetById(int estudanteId)
   {
      throw new NotImplementedException();
   }

   public void Save(Estudante estudante)
   {
      throw new NotImplementedException();
   }
}

public interface IEstudanteService
{
}