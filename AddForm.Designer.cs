namespace AgendaTelefonica
{
    partial class AddForm
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
            label6 = new Label();
            BotonCancelar = new Button();
            BotonAdd = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TextBoxCorreo = new TextBox();
            TextBoxTelefono = new TextBox();
            TextBoxEmpresa = new TextBox();
            TextBoxApellido = new TextBox();
            TextBoxNombre = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(131, 30);
            label6.Name = "label6";
            label6.Size = new Size(208, 39);
            label6.TabIndex = 25;
            label6.Text = "Añadir contacto";
            // 
            // BotonCancelar
            // 
            BotonCancelar.Location = new Point(269, 336);
            BotonCancelar.Name = "BotonCancelar";
            BotonCancelar.Size = new Size(110, 29);
            BotonCancelar.TabIndex = 24;
            BotonCancelar.Text = "Cancelar";
            BotonCancelar.UseVisualStyleBackColor = true;
            BotonCancelar.Click += BotonCancelar_Click;
            // 
            // BotonAdd
            // 
            BotonAdd.Location = new Point(117, 336);
            BotonAdd.Name = "BotonAdd";
            BotonAdd.Size = new Size(106, 29);
            BotonAdd.TabIndex = 23;
            BotonAdd.Text = "Añadir";
            BotonAdd.UseVisualStyleBackColor = true;
            BotonAdd.Click += BotonActualizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 272);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 22;
            label5.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 229);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 21;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 184);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 20;
            label3.Text = "Empresa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 135);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 19;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 91);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 18;
            label1.Text = "Nombre:";
            // 
            // TextBoxCorreo
            // 
            TextBoxCorreo.Location = new Point(117, 272);
            TextBoxCorreo.Name = "TextBoxCorreo";
            TextBoxCorreo.Size = new Size(304, 27);
            TextBoxCorreo.TabIndex = 17;
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(117, 229);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(304, 27);
            TextBoxTelefono.TabIndex = 16;
            // 
            // TextBoxEmpresa
            // 
            TextBoxEmpresa.Location = new Point(117, 184);
            TextBoxEmpresa.Name = "TextBoxEmpresa";
            TextBoxEmpresa.Size = new Size(304, 27);
            TextBoxEmpresa.TabIndex = 15;
            // 
            // TextBoxApellido
            // 
            TextBoxApellido.Location = new Point(117, 135);
            TextBoxApellido.Name = "TextBoxApellido";
            TextBoxApellido.Size = new Size(304, 27);
            TextBoxApellido.TabIndex = 14;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(117, 91);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(304, 27);
            TextBoxNombre.TabIndex = 13;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(label6);
            Controls.Add(BotonCancelar);
            Controls.Add(BotonAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxCorreo);
            Controls.Add(TextBoxTelefono);
            Controls.Add(TextBoxEmpresa);
            Controls.Add(TextBoxApellido);
            Controls.Add(TextBoxNombre);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button BotonCancelar;
        private Button BotonAdd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TextBoxCorreo;
        private TextBox TextBoxTelefono;
        private TextBox TextBoxEmpresa;
        private TextBox TextBoxApellido;
        private TextBox TextBoxNombre;
    }
}