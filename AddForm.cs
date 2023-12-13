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
        MainForm _mainForm;
        TextBox[] textBoxes;
        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            controlador = new Controlador(this.TextBoxNombre, this.TextBoxApellido, this.TextBoxEmpresa, this.TextBoxTelefono, this.TextBoxCorreo);
            database = new Database();
            _mainForm = mainForm;
            textBoxes = new TextBox[] {TextBoxNombre, TextBoxApellido, TextBoxEmpresa, TextBoxTelefono, TextBoxCorreo};
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
            List<Contacto> lista = await database.ReadAllContacts();
            Data.Update(lista, _mainForm);
            MessageBox.Show("¡Contacto creado con exito!", "Tu contacto fue creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Controlador.LimpiarTextBox(textBoxes);
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
