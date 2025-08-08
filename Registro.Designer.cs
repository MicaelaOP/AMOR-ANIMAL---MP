namespace AMOR_ANIMAL___MP
{
    partial class FRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegistro));
            this.BRegistrar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBClave = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LTel = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.MTBTel = new System.Windows.Forms.MaskedTextBox();
            this.PBFONDO2 = new System.Windows.Forms.PictureBox();
            this.PBFONDO1 = new System.Windows.Forms.PictureBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBFONDO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFONDO1)).BeginInit();
            this.SuspendLayout();
            // 
            // BRegistrar
            // 
            this.BRegistrar.Location = new System.Drawing.Point(65, 278);
            this.BRegistrar.Name = "BRegistrar";
            this.BRegistrar.Size = new System.Drawing.Size(86, 24);
            this.BRegistrar.TabIndex = 11;
            this.BRegistrar.Text = "&Registrarme";
            this.BRegistrar.UseVisualStyleBackColor = true;
            this.BRegistrar.Click += new System.EventHandler(this.BRegistrar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(70, 308);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(76, 24);
            this.BCancelar.TabIndex = 0;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(33, 36);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(157, 20);
            this.TBNombre.TabIndex = 2;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(33, 89);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(157, 20);
            this.TBApellido.TabIndex = 4;
            // 
            // TBClave
            // 
            this.TBClave.Location = new System.Drawing.Point(33, 243);
            this.TBClave.Name = "TBClave";
            this.TBClave.PasswordChar = '*';
            this.TBClave.Size = new System.Drawing.Size(157, 20);
            this.TBClave.TabIndex = 10;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(90, 20);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(90, 73);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clave";
            // 
            // LTel
            // 
            this.LTel.AutoSize = true;
            this.LTel.Location = new System.Drawing.Point(59, 122);
            this.LTel.Name = "LTel";
            this.LTel.Size = new System.Drawing.Size(104, 13);
            this.LTel.TabIndex = 5;
            this.LTel.Text = "Número de Telefono";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(90, 171);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 7;
            this.LEmail.Text = "Email";
            // 
            // MTBTel
            // 
            this.MTBTel.Location = new System.Drawing.Point(33, 138);
            this.MTBTel.Mask = "(999)000-0000";
            this.MTBTel.Name = "MTBTel";
            this.MTBTel.Size = new System.Drawing.Size(151, 20);
            this.MTBTel.TabIndex = 6;
            // 
            // PBFONDO2
            // 
            this.PBFONDO2.Image = global::AMOR_ANIMAL___MP.Properties.Resources.huella_fondo;
            this.PBFONDO2.Location = new System.Drawing.Point(70, 171);
            this.PBFONDO2.Name = "PBFONDO2";
            this.PBFONDO2.Size = new System.Drawing.Size(167, 192);
            this.PBFONDO2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBFONDO2.TabIndex = 12;
            this.PBFONDO2.TabStop = false;
            // 
            // PBFONDO1
            // 
            this.PBFONDO1.Image = global::AMOR_ANIMAL___MP.Properties.Resources.huella_fondo;
            this.PBFONDO1.Location = new System.Drawing.Point(-21, -37);
            this.PBFONDO1.Name = "PBFONDO1";
            this.PBFONDO1.Size = new System.Drawing.Size(138, 172);
            this.PBFONDO1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBFONDO1.TabIndex = 13;
            this.PBFONDO1.TabStop = false;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(33, 187);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(157, 20);
            this.TBEmail.TabIndex = 8;
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(227, 349);
            this.Controls.Add(this.MTBTel);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.TBClave);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BRegistrar);
            this.Controls.Add(this.PBFONDO1);
            this.Controls.Add(this.PBFONDO2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRegistro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.PBFONDO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFONDO1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BRegistrar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBClave;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LTel;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.MaskedTextBox MTBTel;
        private System.Windows.Forms.PictureBox PBFONDO2;
        private System.Windows.Forms.PictureBox PBFONDO1;
        private System.Windows.Forms.TextBox TBEmail;
    }
}