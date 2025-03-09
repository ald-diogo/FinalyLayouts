using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontDeveloper.Context;
using FrontDeveloper.Models;

namespace FrontDeveloper.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<Estudante> Estudantes { get; set; }
    }

    public class DbSet<T>
    {
    }
}
public class DbContextOptions<T>
{
}

public class DbContext(DbContextOptions<DataBaseContext> options)
{
}