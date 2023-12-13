namespace AgendaTelefonica
{
    partial class DeleteForm
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
            DeleteTextBox = new TextBox();
            SearchDeleteButton = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LabelCorreo = new Label();
            LabelTelefono = new Label();
            LabelEmpresa = new Label();
            LabelApellido = new Label();
            LabelNombre = new Label();
            DeleteButton = new Button();
            CancelarButton = new Button();
            SuspendLayout();
            // 
            // DeleteTextBox
            // 
            DeleteTextBox.Location = new Point(405, 50);
            DeleteTextBox.Name = "DeleteTextBox";
            DeleteTextBox.Size = new Size(266, 27);
            DeleteTextBox.TabIndex = 0;
            // 
            // SearchDeleteButton
            // 
            SearchDeleteButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SearchDeleteButton.IconColor = Color.Black;
            SearchDeleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchDeleteButton.IconSize = 24;
            SearchDeleteButton.Location = new Point(677, 50);
            SearchDeleteButton.Name = "SearchDeleteButton";
            SearchDeleteButton.Padding = new Padding(5);
            SearchDeleteButton.Size = new Size(69, 29);
            SearchDeleteButton.TabIndex = 16;
            SearchDeleteButton.UseVisualStyleBackColor = true;
            SearchDeleteButton.Click += SearchDeleteButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(68, 38);
            label6.Name = "label6";
            label6.Size = new Size(231, 39);
            label6.TabIndex = 17;
            label6.Text = "Eliminar contacto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 280);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 22;
            label5.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 237);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 21;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 192);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 20;
            label3.Text = "Empresa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 143);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 19;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 99);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 18;
            label1.Text = "Nombre:";
            // 
            // LabelCorreo
            // 
            LabelCorreo.AutoSize = true;
            LabelCorreo.Location = new Point(141, 280);
            LabelCorreo.Name = "LabelCorreo";
            LabelCorreo.Size = new Size(0, 20);
            LabelCorreo.TabIndex = 27;
            // 
            // LabelTelefono
            // 
            LabelTelefono.AutoSize = true;
            LabelTelefono.Location = new Point(141, 237);
            LabelTelefono.Name = "LabelTelefono";
            LabelTelefono.Size = new Size(0, 20);
            LabelTelefono.TabIndex = 26;
            // 
            // LabelEmpresa
            // 
            LabelEmpresa.AutoSize = true;
            LabelEmpresa.Location = new Point(141, 192);
            LabelEmpresa.Name = "LabelEmpresa";
            LabelEmpresa.Size = new Size(0, 20);
            LabelEmpresa.TabIndex = 25;
            // 
            // LabelApellido
            // 
            LabelApellido.AutoSize = true;
            LabelApellido.Location = new Point(141, 143);
            LabelApellido.Name = "LabelApellido";
            LabelApellido.Size = new Size(0, 20);
            LabelApellido.TabIndex = 24;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(141, 99);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(0, 20);
            LabelNombre.TabIndex = 23;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(105, 352);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(93, 37);
            DeleteButton.TabIndex = 28;
            DeleteButton.Text = "Eliminar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(225, 352);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(94, 37);
            CancelarButton.TabIndex = 29;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarButton);
            Controls.Add(DeleteButton);
            Controls.Add(LabelCorreo);
            Controls.Add(LabelTelefono);
            Controls.Add(LabelEmpresa);
            Controls.Add(LabelApellido);
            Controls.Add(LabelNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(SearchDeleteButton);
            Controls.Add(DeleteTextBox);
            Name = "DeleteForm";
            Text = "DeleteForm";
            Load += DeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DeleteTextBox;
        private FontAwesome.Sharp.IconButton SearchDeleteButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label LabelCorreo;
        private Label LabelTelefono;
        private Label LabelEmpresa;
        private Label LabelApellido;
        private Label LabelNombre;
        private Button DeleteButton;
        private Button CancelarButton;
    }
}