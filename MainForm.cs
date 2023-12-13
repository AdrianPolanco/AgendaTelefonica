using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class MainForm : Form
    {
        public Database database;
        private UpdateForm updateForm;
        private DeleteForm deleteForm;
        private AddForm addForm;
        private SearchEngine searchEngine;
        private TextBox[] textBoxes;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (RadioButtonNombre.Checked)
            {
                searchEngine.Search(RadioButtonNombre, SearchTextBox.Text, this);
            }
            else if (RadioButtonTelefono.Checked)
            {
                searchEngine.Search(RadioButtonTelefono, SearchTextBox.Text, this);
            }
            else if (RadioButtonEmpresa.Checked)
            {
                searchEngine.Search(RadioButtonEmpresa, SearchTextBox.Text, this);
            }

            Controlador.LimpiarTextBox(textBoxes);
        }


        private void TablaContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.database = new Database();
                searchEngine = new SearchEngine(database);
                List<Contacto> lista = await database.ReadAllContacts();
                Data.Update(lista, this);
                textBoxes = new TextBox[] { SearchTextBox };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar los contactos: {ex.Message}");
            }
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateForm(this);
            updateForm.ShowDialog(this);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            deleteForm = new DeleteForm(this);
            deleteForm.ShowDialog(this);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            addForm = new AddForm(this);
            addForm.ShowDialog(this);
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            List<Contacto> contactos = await database.ReadAllContacts();
            Data.Update(contactos, this);
            Controlador.LimpiarTextBox(textBoxes);
        }
    }
}
