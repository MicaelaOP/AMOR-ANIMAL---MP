namespace AMOR_ANIMAL___MP
{
    partial class FBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBusqueda));
            this.LSaludo = new System.Windows.Forms.Label();
            this.LSaludoB = new System.Windows.Forms.Label();
            this.BPerro = new System.Windows.Forms.Button();
            this.BGato = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BAtras = new System.Windows.Forms.Button();
            this.PBFONDO = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFONDO)).BeginInit();
            this.SuspendLayout();
            // 
            // LSaludo
            // 
            this.LSaludo.Location = new System.Drawing.Point(0, 0);
            this.LSaludo.Name = "LSaludo";
            this.LSaludo.Size = new System.Drawing.Size(100, 23);
            this.LSaludo.TabIndex = 0;
            // 
            // LSaludoB
            // 
            this.LSaludoB.AutoSize = true;
            this.LSaludoB.Location = new System.Drawing.Point(27, 9);
            this.LSaludoB.Name = "LSaludoB";
            this.LSaludoB.Size = new System.Drawing.Size(0, 13);
            this.LSaludoB.TabIndex = 0;
            // 
            // BPerro
            // 
            this.BPerro.Location = new System.Drawing.Point(16, 19);
            this.BPerro.Name = "BPerro";
            this.BPerro.Size = new System.Drawing.Size(186, 45);
            this.BPerro.TabIndex = 1;
            this.BPerro.Text = "Quiero un perro que ronque más que yo, pero me deje dormir igual.";
            this.BPerro.UseVisualStyleBackColor = true;
            this.BPerro.Click += new System.EventHandler(this.BPerro_Click);
            // 
            // BGato
            // 
            this.BGato.Location = new System.Drawing.Point(16, 72);
            this.BGato.Name = "BGato";
            this.BGato.Size = new System.Drawing.Size(186, 40);
            this.BGato.TabIndex = 2;
            this.BGato.Text = "Quiero un gato que me mire con desprecio, pero me ame en secreto.";
            this.BGato.UseVisualStyleBackColor = true;
            this.BGato.Click += new System.EventHandler(this.BGato_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BPerro);
            this.groupBox1.Controls.Add(this.BGato);
            this.groupBox1.Location = new System.Drawing.Point(35, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿QUE ESTAS BUSCANDO?";
            // 
            // BAtras
            // 
            this.BAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAtras.Location = new System.Drawing.Point(96, 190);
            this.BAtras.Name = "BAtras";
            this.BAtras.Size = new System.Drawing.Size(106, 30);
            this.BAtras.TabIndex = 17;
            this.BAtras.Text = "&Atras";
            this.BAtras.UseVisualStyleBackColor = true;
            this.BAtras.Click += new System.EventHandler(this.BAtras_Click);
            // 
            // PBFONDO
            // 
            this.PBFONDO.Image = global::AMOR_ANIMAL___MP.Properties.Resources.fondo3;
            this.PBFONDO.Location = new System.Drawing.Point(-18, 139);
            this.PBFONDO.Name = "PBFONDO";
            this.PBFONDO.Size = new System.Drawing.Size(130, 150);
            this.PBFONDO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFONDO.TabIndex = 18;
            this.PBFONDO.TabStop = false;
            // 
            // FBusqueda
            // 
            this.ClientSize = new System.Drawing.Size(281, 265);
            this.Controls.Add(this.BAtras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LSaludoB);
            this.Controls.Add(this.PBFONDO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FBusqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.FBusqueda_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBFONDO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LSaludo;
        private System.Windows.Forms.Label LSaludoB;
        private System.Windows.Forms.Button BPerro;
        private System.Windows.Forms.Button BGato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BAtras;
        private System.Windows.Forms.PictureBox PBFONDO;
    }
}