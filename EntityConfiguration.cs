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

        private static EntityConfiguration instance;

        private EntityConfiguration(EntityTypeBuilder<Contacto> entityTypeBuilder) {
            entityTypeBuilder.HasKey(e => e.ID);
            entityTypeBuilder.Property(e => e.Nombre).IsRequired();
            entityTypeBuilder.Property(e => e.Apellido).IsRequired();
            entityTypeBuilder.Property(e => e.Correo).IsRequired();
            entityTypeBuilder.Property(e => e.Telefono).IsRequired();
            entityTypeBuilder.Property(e => e.Empresa).IsRequired();
        }

        public static EntityConfiguration GetInstance(EntityTypeBuilder<Contacto> entityTypeBuilder)
        {
            if (instance == null) { instance = new EntityConfiguration(entityTypeBuilder); }
            return instance;
        }
    }
}
