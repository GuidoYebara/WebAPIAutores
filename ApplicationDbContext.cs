using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPIAutores.Entidades
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //Aca hago la traduccion de una clase a una entidad (tabla).
        //Le digo que cree una tabla a partir del esquema de Autor. La tabla se llama autores.
        public DbSet<Autor> Autores { get; set; }
    }

}