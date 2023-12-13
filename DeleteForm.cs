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
    public partial class DeleteForm : Form
    {
        Database database;
        SearchEngine _searchEngine;
        int id = 0;
        MainForm _mainForm;
        TextBox[] textBoxes;
        public DeleteForm(MainForm mainForm)
        {
            InitializeComponent();
            database = new Database();
            _mainForm = mainForm;
            _searchEngine = new SearchEngine(database);
            textBoxes = new TextBox[] { DeleteTextBox };
      
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private async void SearchDeleteButton_Click(object sender, EventArgs e)
        {
            Contacto contacto = await _searchEngine.SearchById(DeleteTextBox.Text);
            id = contacto.ID;
            Label[] labels = new Label[] { LabelNombre, LabelApellido, LabelEmpresa, LabelTelefono, LabelCorreo };
            Controlador.RellenarLabels(labels, contacto);
            Controlador.LimpiarTextBox(textBoxes);
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este contacto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    await database.DeleteContact(id);
                    List<Contacto> lista = await database.ReadAllContacts();
                    Data.Update(lista, _mainForm);
                    MessageBox.Show("¡Contacto eliminado con exito!", "Tu contacto fue eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
