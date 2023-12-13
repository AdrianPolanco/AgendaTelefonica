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

        public void Rellenar(Contacto contacto)
        {
            string[] valores = new string[] { contacto.Nombre, contacto.Apellido, contacto.Empresa, contacto.Telefono, contacto.Correo };
            int index = 0;
            foreach(TextBox t in listaValores)
            {
                t.Text = valores[index];
                index += 1;
            }
        }

        public static void RellenarLabels(Label[] labels, Contacto contacto)
        {
            int index = 0;
            string[] valores = new string[] { contacto.Nombre, contacto.Apellido, contacto.Empresa, contacto.Telefono, contacto.Correo };
            foreach (Label l in labels)
            {
                l.Text = valores[index];
                index += 1;
            }
        }

        public static void LimpiarTextBox(TextBox[] textBoxes)
        {
            foreach(TextBox t in textBoxes)
            {
                t.Text = "";
            }
        }
    }
}
