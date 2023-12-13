using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    public class EntityConfiguration
    {

        private EntityConfiguration(EntityTypeBuilder<Contacto> entityTypeBuilder) {
            entityTypeBuilder.HasKey(e => e.ID);
            entityTypeBuilder.Property(e => e.Nombre).IsRequired();
            entityTypeBuilder.Property(e => e.Apellido).IsRequired();
            entityTypeBuilder.Property(e => e.Correo).IsRequired();
            entityTypeBuilder.Property(e => e.Telefono).IsRequired();
            entityTypeBuilder.Property(e => e.Empresa).IsRequired();
        }

        private static EntityConfiguration? instance;
      

        //Propiedad que representa la tabla Contactos en la BD, en donde se guardara la informacion
        public DbSet<Contacto> Contactos { get; set; }

        //Metodo para obtener una instancia de esta clase, si no existe ninguna instancia te creara una y si no te devuelve la ya existente
        //para evitar tener varias instancias de la base de datos de forma innecesaria
        public static EntityConfiguration GetInstance(EntityTypeBuilder<Contacto> entityTypeBuilder)
        {
            if (instance == null) { instance = new EntityConfiguration(entityTypeBuilder); }
            return instance;
        }
    }
}
