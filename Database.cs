using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgendaTelefonica
{
    public class Database: DbContext
    {
        private static Database? instance;
        private Database()
        {

        }

        public DbSet<Contacto> Contactos { get; set; }

        public static Database GetInstance()
        {
            if(instance == null) { instance = new Database(); }
            return instance;
        }

        public async Task<bool> SaveAsync()
        {
            //DbContext.SaveChangesSaveChangesAsyncAsync() verifica si han habido cambios en el DbContext y lo guarda de forma asincrona
            return await SaveChangesAsync() > 0;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                string connectionString = configuration.GetConnectionString("CadenaConexion"); 

                optionsBuilder.UseSqlServer(connectionString);
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            EntitySetConfiguration(modelBuilder);
        }

        private void EntitySetConfiguration(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Contacto>(entity =>
            {
                EntityConfiguration.GetInstance(entity);
            });
        }
    }
}
