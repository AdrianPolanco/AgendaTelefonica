﻿using System;
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
        private Database database;
        private UpdateForm updateForm;
        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }
        private async void SearchButton_Click(object sender, EventArgs e)
        {

        }


        private void TablaContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.database = new Database();
                List<Contacto> contactos = await database.ReadAllContacts();
                TablaContactos.DataSource = contactos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar los contactos: {ex.Message}");
            }
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateForm();
            updateForm.ShowDialog(this);
        }
    }
}