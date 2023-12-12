using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    public class Controlador
    {
        private List<TextBox> listaValores = new List<TextBox>();
        public Controlador(TextBox nombre, TextBox apellido, TextBox empresa, TextBox telefono, TextBox correo)
        {
            listaValores.AddRange(new TextBox[] {nombre, apellido, empresa, telefono, correo});
        }

        public Contacto Capturar()
        {
            Contacto contacto = new Contacto()
            {
                Nombre = listaValores[0].Text,
                Apellido = listaValores[1].Text,
                Empresa = listaValores[2].Text,
                Telefono = listaValores[3].Text,
                Correo = listaValores[4].Text
            };
            contacto.Validar();
            return contacto;
        }
    }
}
