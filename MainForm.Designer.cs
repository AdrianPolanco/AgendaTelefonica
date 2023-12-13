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
            SearchTextBox = new TextBox();
            SearchButton = new FontAwesome.Sharp.IconButton();
            databaseBindingSource = new BindingSource(components);
            ButtonEditar = new FontAwesome.Sharp.IconButton();
            ButtonEliminar = new FontAwesome.Sharp.IconButton();
            CreateButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)TablaContactos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TablaContactos
            // 
            TablaContactos.AllowUserToAddRows = false;
            TablaContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaContactos.Location = new Point(40, 54);
            TablaContactos.Name = "TablaContactos";
            TablaContactos.RowHeadersWidth = 51;
            TablaContactos.RowTemplate.Height = 29;
            TablaContactos.Size = new Size(1080, 363);
            TablaContactos.TabIndex = 0;
            TablaContactos.CellContentClick += TablaContactos_CellContentClick;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(700, 12);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(298, 27);
            SearchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SearchButton.IconColor = Color.Black;
            SearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchButton.IconSize = 24;
            SearchButton.Location = new Point(1004, 12);
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
            ButtonEditar.Location = new Point(600, 10);
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
            ButtonEliminar.Location = new Point(500, 10);
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
            CreateButton.Location = new Point(400, 10);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(94, 29);
            CreateButton.TabIndex = 6;
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 450);
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

        private DataGridView TablaContactos;
        private TextBox SearchTextBox;
        private FontAwesome.Sharp.IconButton SearchButton;
        private BindingSource databaseBindingSource;
        private FontAwesome.Sharp.IconButton ButtonEditar;
        private FontAwesome.Sharp.IconButton ButtonEliminar;
        private FontAwesome.Sharp.IconButton CreateButton;
    }
}