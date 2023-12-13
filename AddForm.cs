using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class AddForm : Form
    {
        Controlador controlador;
        Database database;
        public AddForm()
        {
            InitializeComponent();
            controlador = new Controlador(this.TextBoxNombre, this.TextBoxApellido, this.TextBoxEmpresa, this.TextBoxTelefono, this.TextBoxCorreo);
            database = new Database();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BotonActualizar_Click(object sender, EventArgs e)
        {
            Contacto contacto = controlador.Capturar();
            contacto.Validar();
            await database.CreateContact(contacto);
            MessageBox.Show("¡Contacto creado con exito!", "Tu contacto fue creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
