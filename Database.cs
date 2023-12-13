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

    //Clase que se encargara de la conexion y las operaciones CRUD de la base de datos
    public class Database: DbContext
    {
       /* private static Database? instance;
        private Database()
        {

        }*/

        //Propiedad que representa la tabla Contactos en la BD, en donde se guardara la informacion
        public DbSet<Contacto> Contactos { get; set; }

        //Metodo para obtener una instancia de esta clase, si no existe ninguna instancia te creara una y si no te devuelve la ya existente
        //para evitar tener varias instancias de la base de datos de forma innecesaria
        /*public static Database GetInstance()
        {
            if(instance == null) { instance = new Database(); }
            return instance;
        }*/

        //Metodo para insertar guardar los cambios hechos en la BD tras un Create, Update o Delete
        private async Task<bool> SaveAsync()
        {
            //DbContext.SaveChangesSaveChangesAsyncAsync() verifica si han habido cambios en el DbContext y lo guarda de forma asincrona
            return await SaveChangesAsync() > 0;
        }

        //Metodo para crear un contacto
        public async Task CreateContact(Contacto contacto)
        {
            try
            {   
                //EnsureCreated te crea la BD con su tabla si no existe
                this.Database.EnsureCreated();
                contacto.Validar();
                await this.Contactos.AddAsync(contacto);
                await this.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Metodo para obtener todos los contactos
        public async Task<List<Contacto>> ReadAllContacts()
        {
            try
            {
                List<Contacto> lista = await this.Contactos.ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Metodo para obtener un contacto por Id
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

        //Metodo para obtener un contacto por nombre
        public async Task<List<Contacto>> ReadContactByName(string name)
        {
            try
            {
                //Retorna los contactos que contengan ese nombre, ej: Si introduzco "adr" y hay un contacto que se llama "adrian" me lo dara
                //sin necesidad de escribir todo el nombre
                return await this.Contactos.Where(c => c.Nombre.Contains(name)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Metodo para obtener un contacto por numero telefonico
        public async Task<List<Contacto>> ReadContactByPhoneNumber(string phoneNumber)
        {
            try
            {
                //Retorna los contactos que contengan parte de ese numero telefonico
                return await this.Contactos.Where(c => c.Telefono.Contains(phoneNumber)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Metodo para actualizar un contacto existente
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

        //Metodo para borrar un contacto existente
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

        //Configuracion para leer la cadena de conexion escrita en el appsettings.json y conectarse a la BD
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                string connectionString = configuration.GetConnectionString("CadenaConexion"); 

                //Conectandose a la BD
                optionsBuilder.UseSqlServer(connectionString);
            }

        }

        //Creando tabla
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            EntitySetConfiguration(modelBuilder);
        }

        //Configurando los campos de la tabla
        private void EntitySetConfiguration(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Contacto>(entity =>
            {
               EntityConfiguration.GetInstance(entity);
            });
        }
    }
}
