namespace AMOR_ANIMAL___MP
{
    partial class FInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicioSesion));
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBClaveInicio = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LClave = new System.Windows.Forms.Label();
            this.BIniciarS = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.PBFONDO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBFONDO)).BeginInit();
            this.SuspendLayout();
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(18, 36);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(174, 20);
            this.TBUsuario.TabIndex = 0;
            // 
            // TBClaveInicio
            // 
            this.TBClaveInicio.Location = new System.Drawing.Point(18, 95);
            this.TBClaveInicio.Name = "TBClaveInicio";
            this.TBClaveInicio.Size = new System.Drawing.Size(174, 20);
            this.TBClaveInicio.TabIndex = 1;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(80, 18);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(43, 13);
            this.LUsuario.TabIndex = 2;
            this.LUsuario.Text = "Usuario";
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Location = new System.Drawing.Point(87, 77);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(34, 13);
            this.LClave.TabIndex = 3;
            this.LClave.Text = "Clave";
            // 
            // BIniciarS
            // 
            this.BIniciarS.Location = new System.Drawing.Point(61, 135);
            this.BIniciarS.Name = "BIniciarS";
            this.BIniciarS.Size = new System.Drawing.Size(91, 43);
            this.BIniciarS.TabIndex = 4;
            this.BIniciarS.Text = "&Iniciar Sesion";
            this.BIniciarS.UseVisualStyleBackColor = true;
            this.BIniciarS.Click += new System.EventHandler(this.BIniciarS_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(73, 188);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(65, 22);
            this.BCancelar.TabIndex = 5;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // PBFONDO
            // 
            this.PBFONDO.Image = global::AMOR_ANIMAL___MP.Properties.Resources.fondo5;
            this.PBFONDO.Location = new System.Drawing.Point(63, 211);
            this.PBFONDO.Name = "PBFONDO";
            this.PBFONDO.Size = new System.Drawing.Size(88, 102);
            this.PBFONDO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFONDO.TabIndex = 6;
            this.PBFONDO.TabStop = false;
            // 
            // FInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(219, 292);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BIniciarS);
            this.Controls.Add(this.LClave);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.TBClaveInicio);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.PBFONDO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FInicioSesion";
            this.Text = "Inicio Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.PBFONDO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBClaveInicio;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LClave;
        private System.Windows.Forms.Button BIniciarS;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.PictureBox PBFONDO;
    }
}