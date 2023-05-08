using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Microsoft.EntityFrameworkCore;

namespace CONSOLA
{
    class ClaseDBcontext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-MOUFH7RA\SQLEXPRESS; Initial Catalog=CLASE24;Integrated Security=True");


        }
        public DbSet<Personas> Persona { set; get; }
    }
}
