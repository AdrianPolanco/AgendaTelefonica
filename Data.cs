using AgendaTelefonica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    public static class Data
    {
        public static async void Update(List<Contacto> lista, MainForm mainForm)
        {

            BindingList<Contacto> contactos = new BindingList<Contacto>(lista);
            mainForm.TablaContactos.DataSource = contactos;
        }

    }
}
