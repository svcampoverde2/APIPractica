using APIPractica.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPractica.Data
{
    public class PracticaContex: DbContext
    {
     public PracticaContex(DbContextOptions<PracticaContex> options) : base(options)
     { 
     
     }
        public DbSet<Cliente> cliente { get; set; }
        //public DbSet<Ciudad> ciudad { get; set; }
    }
}

