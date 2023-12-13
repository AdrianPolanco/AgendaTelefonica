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
        SearchEngine searchEngine;
        int id = 0;
        public DeleteForm()
        {
            InitializeComponent();
            database = new Database();
            searchEngine = new SearchEngine(database);
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private async void SearchDeleteButton_Click(object sender, EventArgs e)
        {
            Contacto contacto = await searchEngine.SearchById(DeleteTextBox.Text);
            id = contacto.ID;
            Label[] labels = new Label[] { LabelNombre, LabelApellido, LabelEmpresa, LabelTelefono, LabelCorreo };
            Controlador.RellenarLabels(labels, contacto);
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este contacto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    await database.DeleteContact(id);
                    MessageBox.Show("¡Contacto eliminado con exito!", "Tu contacto fue eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
