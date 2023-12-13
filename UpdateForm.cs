namespace AgendaTelefonica
{
    public partial class UpdateForm : Form
    {
        Database database;
        Controlador controlador;
        SearchEngine searchEngine;
        int id = 0;

        public UpdateForm()
        {
            InitializeComponent();
            database = new Database();
            searchEngine = new SearchEngine(database);
            controlador = new Controlador(this.TextBoxNombre, this.TextBoxApellido, this.TextBoxEmpresa, this.TextBoxTelefono, this.TextBoxCorreo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void BotonActualizar_Click(object sender, EventArgs e)
        {
            Contacto contacto = controlador.Capturar();
            await database.UpdateContact(id, contacto);
            MessageBox.Show("¡Contacto actualizado con exito!", "Tu contacto fue actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Contacto contacto = await searchEngine.SearchById(SearchByIdUpdateTextBox.Text);

            controlador.Rellenar(contacto);
            id = contacto.ID;
        }
    }
}