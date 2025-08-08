namespace AMOR_ANIMAL___MP
{
    partial class FBienvenidos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBienvenidos));
            this.BAdoptar = new System.Windows.Forms.Button();
            this.PBBienvenidos = new System.Windows.Forms.PictureBox();
            this.Lintro = new System.Windows.Forms.Label();
            this.LLabelInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PBBienvenidos)).BeginInit();
            this.SuspendLayout();
            // 
            // BAdoptar
            // 
            this.BAdoptar.Location = new System.Drawing.Point(121, 145);
            this.BAdoptar.Name = "BAdoptar";
            this.BAdoptar.Size = new System.Drawing.Size(141, 63);
            this.BAdoptar.TabIndex = 0;
            this.BAdoptar.Text = "Quiero Adoptar";
            this.BAdoptar.UseVisualStyleBackColor = true;
            this.BAdoptar.Click += new System.EventHandler(this.BAdoptar_Click);
            // 
            // PBBienvenidos
            // 
            this.PBBienvenidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PBBienvenidos.Image = global::AMOR_ANIMAL___MP.Properties.Resources.fondo1;
            this.PBBienvenidos.Location = new System.Drawing.Point(127, 214);
            this.PBBienvenidos.Name = "PBBienvenidos";
            this.PBBienvenidos.Size = new System.Drawing.Size(127, 120);
            this.PBBienvenidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBienvenidos.TabIndex = 1;
            this.PBBienvenidos.TabStop = false;
            // 
            // Lintro
            // 
            this.Lintro.Location = new System.Drawing.Point(51, -2);
            this.Lintro.Name = "Lintro";
            this.Lintro.Size = new System.Drawing.Size(275, 157);
            this.Lintro.TabIndex = 2;
            this.Lintro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LLabelInfo
            // 
            this.LLabelInfo.AutoSize = true;
            this.LLabelInfo.Location = new System.Drawing.Point(2, 300);
            this.LLabelInfo.Name = "LLabelInfo";
            this.LLabelInfo.Size = new System.Drawing.Size(65, 13);
            this.LLabelInfo.TabIndex = 3;
            this.LLabelInfo.TabStop = true;
            this.LLabelInfo.Text = "Acerca de...";
            this.LLabelInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabelInfo_LinkClicked);
            // 
            // FBienvenidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(377, 316);
            this.Controls.Add(this.LLabelInfo);
            this.Controls.Add(this.BAdoptar);
            this.Controls.Add(this.PBBienvenidos);
            this.Controls.Add(this.Lintro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FBienvenidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BIENVENIDOS...";
            this.Load += new System.EventHandler(this.FBienvenidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBBienvenidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAdoptar;
        private System.Windows.Forms.PictureBox PBBienvenidos;
        private System.Windows.Forms.Label Lintro;
        private System.Windows.Forms.LinkLabel LLabelInfo;
    }
}

