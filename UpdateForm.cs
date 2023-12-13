namespace AgendaTelefonica
{
    public partial class UpdateForm : Form
    {
        Database database;
        Controlador controlador;
        SearchEngine _searchEngine;
        MainForm _mainForm;
        TextBox[] textBoxes;
        int id = 0;

        public UpdateForm(MainForm mainForm)
        {
            InitializeComponent();
            database = new Database();
            _mainForm = mainForm;
            _searchEngine = new SearchEngine(database); 
            controlador = new Controlador(this.TextBoxNombre, this.TextBoxApellido, this.TextBoxEmpresa, this.TextBoxTelefono, this.TextBoxCorreo);
            textBoxes = new TextBox[] { TextBoxNombre, TextBoxApellido, TextBoxEmpresa, TextBoxTelefono, TextBoxCorreo, SearchByIdUpdateTextBox };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void BotonActualizar_Click(object sender, EventArgs e)
        {
            Contacto contacto = controlador.Capturar();
            await database.UpdateContact(id, contacto);
            List<Contacto> lista = await database.ReadAllContacts();
            Data.Update(lista, _mainForm);
            MessageBox.Show("¡Contacto actualizado con exito!", "Tu contacto fue actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Controlador.LimpiarTextBox(textBoxes);
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Dispose();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SearchUpdateButton_Click(object sender, EventArgs e)
        {
            Contacto contacto = await _searchEngine.SearchById(SearchByIdUpdateTextBox.Text);
            Controlador.LimpiarTextBox(textBoxes);
            controlador.Rellenar(contacto);
            id = contacto.ID;
            
        }
    }
}