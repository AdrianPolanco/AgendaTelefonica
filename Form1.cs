namespace AgendaTelefonica
{
    public partial class UpdateForm : Form
    {
        Database database = Database.GetInstance();
        Controlador controlador;

        public UpdateForm()
        {
            InitializeComponent();
            controlador = new Controlador(this.TextBoxNombre, this.TextBoxApellido, this.TextBoxEmpresa, this.TextBoxTelefono, this.TextBoxCorreo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void BotonActualizar_Click(object sender, EventArgs e)
        {
            Contacto contacto = controlador.Capturar();
            await database.CreateContact(contacto);
        }
    }
}