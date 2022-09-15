using Microsoft.EntityFrameworkCore;
using RemoteCare.App.Dominio;

namespace RemoteCare.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet <Persona> personas {get;set;}
        public DbSet <Historia_Clinica> HisClinic {get;set;}
        public DbSet <Oveja> oveja {get;set;}
        public DbSet <Propietario> propietario {get;set;}
        public DbSet <Veterinario> veterinario {get;set;}
        public DbSet <Visita> visita {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = RemoteCareData");
            }
        }
     
}
}

//dbContextOptionsBuilder
//DbContextOptionsBuilder