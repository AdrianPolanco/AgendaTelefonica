namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        Database database = Database.GetInstance();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Estos botones son solo de prueba para verificar que la conexion a la BD funcionaba, lo pueden borrar para crear la UI
        private async void button1_Click(object sender, EventArgs e)
        {

            Contacto contacto = new Contacto() { Nombre = "Anita Veronica", Apellido = "Perez Perez", Telefono = "849587-9667", Empresa = "Coca Cola", Correo = "ana@gmail.com" };
            await database.CreateContact(contacto);

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            List<Contacto> data = await database.ReadAllContacts();
            foreach (Contacto contacto in data)
            {
                dataTable.Text += $"Nombre: {contacto.Nombre} \n Apellido: {contacto.Apellido} \n Telefono: {contacto.Telefono} \n Empresa: {contacto.Empresa}\n Correo: {contacto.Correo}";
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Contacto? contacto = await database.ReadContactById(2);
            dataTable.Text += $"Nombre: {contacto.Nombre} \n Apellido: {contacto.Apellido} \n Telefono: {contacto.Telefono} \n Empresa: {contacto.Empresa}\n Correo: {contacto.Correo}";
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            List<Contacto> data = await database.ReadContactByName("ad");
            foreach (Contacto contacto in data)
            {
                dataTable.Text += $"Nombre: {contacto.Nombre} \n Apellido: {contacto.Apellido} \n Telefono: {contacto.Telefono} \n Empresa: {contacto.Empresa}\n Correo: {contacto.Correo}";
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            List<Contacto> data = await database.ReadContactByPhoneNumber("849-587-");
            foreach (Contacto contacto in data)
            {
                dataTable.Text += $"Nombre: {contacto.Nombre} \n Apellido: {contacto.Apellido} \n Telefono: {contacto.Telefono} \n Empresa: {contacto.Empresa}\n Correo: {contacto.Correo}";
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto() { Nombre = "Adrian Saul", Apellido = "Polanco Ferrer", Telefono = "867-987-5579", Empresa = "Coca Cola", Correo = "ana@gmail.com" };
            await database.UpdateContact(2, contacto);
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            await database.DeleteContact(14);
        }
    }
}