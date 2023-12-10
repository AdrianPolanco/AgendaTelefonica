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

        private async Task<bool> SaveAsync()
        {
            //DbContext.SaveChangesSaveChangesAsyncAsync() verifica si han habido cambios en el DbContext y lo guarda de forma asincrona
            return await SaveChangesAsync() > 0;
        }

        public async Task CreateContact(Contacto contacto)
        {
            try
            {   this.Database.EnsureCreated();
                contacto.Validar();
                await this.Contactos.AddAsync(contacto);
                await this.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Contacto>> ReadAllContacts()
        {
            try
            {
                return await this.Contactos.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Contacto> ReadContactById(int id)
        {
            try
            {
                return await this.Contactos.FirstOrDefaultAsync(c => c.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Contacto>> ReadContactByName(string name)
        {
            try
            {
                return await this.Contactos.Where(c => c.Nombre.Contains(name)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
      public async Task<List<Contacto>> ReadContactByPhoneNumber(string phoneNumber)
        {
            try
            {
                return await this.Contactos.Where(c => c.Telefono.Contains(phoneNumber)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Contacto> UpdateContact(int id, Contacto contactoActualizado)
        {
            try
            {
                contactoActualizado.Validar();
                Contacto? contacto = await this.ReadContactById(id);

                if (contacto != null)
                {
                    contacto.Nombre = contactoActualizado.Nombre;
                    contacto.Apellido = contactoActualizado.Apellido;
                    contacto.Telefono = contactoActualizado.Telefono;
                    contacto.Correo = contactoActualizado.Correo;
                    contacto.Empresa = contactoActualizado.Empresa;

                    this.Update<Contacto>(contacto);
                    await this.SaveAsync();

                    return contacto;
                }
                else
                {
                    throw new Exception("No se encontró el contacto con el id especificado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteContact(int id)
        {
            try
            {
                Contacto contacto = await this.ReadContactById(id);

                if(contacto != null) { 
                this.Contactos.Remove(contacto);
                await this.SaveAsync();
                }
                else
                {
                    throw new Exception("No se encontró el contacto con el id especificado.");
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
