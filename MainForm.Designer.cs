namespace AgendaTelefonica
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TablaContactos = new DataGridView();
            SearchButton = new FontAwesome.Sharp.IconButton();
            databaseBindingSource = new BindingSource(components);
            ButtonEditar = new FontAwesome.Sharp.IconButton();
            ButtonEliminar = new FontAwesome.Sharp.IconButton();
            CreateButton = new FontAwesome.Sharp.IconButton();
            SearchTextBox = new TextBox();
            RadioButtonNombre = new RadioButton();
            RadioButtonTelefono = new RadioButton();
            RadioButtonEmpresa = new RadioButton();
            label1 = new Label();
            RefreshButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)TablaContactos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TablaContactos
            // 
            TablaContactos.AllowUserToAddRows = false;
            TablaContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaContactos.Location = new Point(57, 106);
            TablaContactos.Name = "TablaContactos";
            TablaContactos.RowHeadersWidth = 51;
            TablaContactos.RowTemplate.Height = 29;
            TablaContactos.Size = new Size(1080, 363);
            TablaContactos.TabIndex = 0;
            TablaContactos.CellContentClick += TablaContactos_CellContentClick;
            // 
            // SearchButton
            // 
            SearchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SearchButton.IconColor = Color.Black;
            SearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchButton.IconSize = 24;
            SearchButton.Location = new Point(1068, 10);
            SearchButton.Name = "SearchButton";
            SearchButton.Padding = new Padding(5);
            SearchButton.Size = new Size(69, 29);
            SearchButton.TabIndex = 2;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(Database);
            // 
            // ButtonEditar
            // 
            ButtonEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            ButtonEditar.IconColor = Color.Black;
            ButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonEditar.IconSize = 24;
            ButtonEditar.Location = new Point(476, 10);
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.Size = new Size(94, 29);
            ButtonEditar.TabIndex = 4;
            ButtonEditar.UseVisualStyleBackColor = true;
            ButtonEditar.Click += iconButton1_Click;
            // 
            // ButtonEliminar
            // 
            ButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            ButtonEliminar.IconColor = Color.Black;
            ButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonEliminar.IconSize = 20;
            ButtonEliminar.Location = new Point(376, 10);
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.Size = new Size(94, 29);
            ButtonEliminar.TabIndex = 5;
            ButtonEliminar.UseVisualStyleBackColor = true;
            ButtonEliminar.Click += iconButton1_Click_1;
            // 
            // CreateButton
            // 
            CreateButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            CreateButton.IconColor = Color.Black;
            CreateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CreateButton.IconSize = 24;
            CreateButton.Location = new Point(276, 10);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(94, 29);
            CreateButton.TabIndex = 6;
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(700, 12);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(362, 27);
            SearchTextBox.TabIndex = 1;
            // 
            // RadioButtonNombre
            // 
            RadioButtonNombre.AutoSize = true;
            RadioButtonNombre.Checked = true;
            RadioButtonNombre.Location = new Point(700, 45);
            RadioButtonNombre.Name = "RadioButtonNombre";
            RadioButtonNombre.Size = new Size(85, 24);
            RadioButtonNombre.TabIndex = 7;
            RadioButtonNombre.TabStop = true;
            RadioButtonNombre.Text = "Nombre";
            RadioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTelefono
            // 
            RadioButtonTelefono.AutoSize = true;
            RadioButtonTelefono.Location = new Point(833, 45);
            RadioButtonTelefono.Name = "RadioButtonTelefono";
            RadioButtonTelefono.Size = new Size(88, 24);
            RadioButtonTelefono.TabIndex = 8;
            RadioButtonTelefono.Text = "Telefono";
            RadioButtonTelefono.UseVisualStyleBackColor = true;
            // 
            // RadioButtonEmpresa
            // 
            RadioButtonEmpresa.AutoSize = true;
            RadioButtonEmpresa.Location = new Point(975, 45);
            RadioButtonEmpresa.Name = "RadioButtonEmpresa";
            RadioButtonEmpresa.Size = new Size(87, 24);
            RadioButtonEmpresa.TabIndex = 9;
            RadioButtonEmpresa.Text = "Empresa";
            RadioButtonEmpresa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(593, 45);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 10;
            label1.Text = "Buscar por:";
            // 
            // RefreshButton
            // 
            RefreshButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            RefreshButton.IconColor = Color.Black;
            RefreshButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RefreshButton.IconSize = 24;
            RefreshButton.Location = new Point(628, 10);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(66, 29);
            RefreshButton.TabIndex = 11;
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 491);
            Controls.Add(RefreshButton);
            Controls.Add(label1);
            Controls.Add(RadioButtonEmpresa);
            Controls.Add(RadioButtonTelefono);
            Controls.Add(RadioButtonNombre);
            Controls.Add(CreateButton);
            Controls.Add(ButtonEliminar);
            Controls.Add(ButtonEditar);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(TablaContactos);
            Name = "MainForm";
            Text = "Agenda Telefonica";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)TablaContactos).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView TablaContactos;
        private FontAwesome.Sharp.IconButton SearchButton;
        private BindingSource databaseBindingSource;
        private FontAwesome.Sharp.IconButton ButtonEditar;
        private FontAwesome.Sharp.IconButton ButtonEliminar;
        private FontAwesome.Sharp.IconButton CreateButton;
        private TextBox SearchTextBox;
        private RadioButton RadioButtonNombre;
        private RadioButton RadioButtonTelefono;
        private RadioButton RadioButtonEmpresa;
        private Label label1;
        private FontAwesome.Sharp.IconButton RefreshButton;
    }
}