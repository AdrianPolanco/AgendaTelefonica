namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Database database = Database.GetInstance();
            database.Database.EnsureCreated();
            Contacto contacto = new Contacto() { 
            Nombre = "Adrian", Apellido="Polanco", Telefono="7373478374", Correo="ad@gmail.com", Empresa="ITLA"};
            try
            {
                await database.Contactos.AddAsync(contacto);
                await database.SaveAsync();
            }catch(Exception ex) {
                throw ex;
            }
            
        }
    }
}