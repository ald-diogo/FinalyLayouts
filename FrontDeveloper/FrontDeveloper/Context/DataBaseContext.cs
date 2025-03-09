using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontDeveloper.Context;
using FrontDeveloper.Models;
using FrontDeveloper.Pages.Admin.Cadastro;

namespace FrontDeveloper.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<Estudante> Estudantes { get; set; }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    public class DbSet<T>
    {
        public List<ListaEstudantes.Estudante> ToHashSet()
        {
            throw new NotImplementedException();
        }

        public Estudante SingleOrDefault(Func<object, bool> func)
        {
            throw new NotImplementedException();
        }

        public void Update(Estudante estudante)
        {
            throw new NotImplementedException();
        }

        public void Add(Estudante estudante)
        {
            throw new NotImplementedException();
        }
    }
}
public class DbContextOptions<T>
{
}

public class DbContext(DbContextOptions<DataBaseContext> options)
{
}