namespace AgendaTelefonica
{
    partial class UpdateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxNombre = new TextBox();
            TextBoxApellido = new TextBox();
            TextBoxEmpresa = new TextBox();
            TextBoxTelefono = new TextBox();
            TextBoxCorreo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BotonActualizar = new Button();
            BotonCancelar = new Button();
            label6 = new Label();
            Prueba = new Label();
            SuspendLayout();
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(161, 70);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(304, 27);
            TextBoxNombre.TabIndex = 0;
            // 
            // TextBoxApellido
            // 
            TextBoxApellido.Location = new Point(161, 114);
            TextBoxApellido.Name = "TextBoxApellido";
            TextBoxApellido.Size = new Size(304, 27);
            TextBoxApellido.TabIndex = 1;
            // 
            // TextBoxEmpresa
            // 
            TextBoxEmpresa.Location = new Point(161, 163);
            TextBoxEmpresa.Name = "TextBoxEmpresa";
            TextBoxEmpresa.Size = new Size(304, 27);
            TextBoxEmpresa.TabIndex = 2;
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(161, 208);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(304, 27);
            TextBoxTelefono.TabIndex = 3;
            // 
            // TextBoxCorreo
            // 
            TextBoxCorreo.Location = new Point(161, 251);
            TextBoxCorreo.Name = "TextBoxCorreo";
            TextBoxCorreo.Size = new Size(304, 27);
            TextBoxCorreo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 70);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 114);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 163);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Empresa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 208);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 8;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 251);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "Correo:";
            // 
            // BotonActualizar
            // 
            BotonActualizar.Location = new Point(161, 315);
            BotonActualizar.Name = "BotonActualizar";
            BotonActualizar.Size = new Size(106, 29);
            BotonActualizar.TabIndex = 10;
            BotonActualizar.Text = "Actualizar";
            BotonActualizar.UseVisualStyleBackColor = true;
            BotonActualizar.Click += BotonActualizar_Click;
            // 
            // BotonCancelar
            // 
            BotonCancelar.Location = new Point(313, 315);
            BotonCancelar.Name = "BotonCancelar";
            BotonCancelar.Size = new Size(110, 29);
            BotonCancelar.TabIndex = 11;
            BotonCancelar.Text = "Cancelar";
            BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(175, 9);
            label6.Name = "label6";
            label6.Size = new Size(248, 39);
            label6.TabIndex = 12;
            label6.Text = "Actualizar contacto";
            // 
            // Prueba
            // 
            Prueba.AutoSize = true;
            Prueba.Location = new Point(623, 58);
            Prueba.Name = "Prueba";
            Prueba.Size = new Size(55, 20);
            Prueba.TabIndex = 13;
            Prueba.Text = "Prueba";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 450);
            Controls.Add(Prueba);
            Controls.Add(label6);
            Controls.Add(BotonCancelar);
            Controls.Add(BotonActualizar);
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
            Name = "UpdateForm";
            Text = "Actualizar contacto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxNombre;
        private TextBox TextBoxApellido;
        private TextBox TextBoxEmpresa;
        private TextBox TextBoxTelefono;
        private TextBox TextBoxCorreo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BotonActualizar;
        private Button BotonCancelar;
        private Label label6;
        private Label Prueba;
    }
}