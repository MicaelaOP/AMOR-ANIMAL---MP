namespace AMOR_ANIMAL___MP
{
    partial class FTerminosC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTerminosC));
            this.LTitulo = new System.Windows.Forms.Label();
            this.LExplicacion = new System.Windows.Forms.Label();
            this.RTBTerminos = new System.Windows.Forms.RichTextBox();
            this.PBotones = new System.Windows.Forms.Panel();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BAceptar = new System.Windows.Forms.Button();
            this.CBAceptar = new System.Windows.Forms.CheckBox();
            this.PBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(19, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(0, 13);
            this.LTitulo.TabIndex = 0;
            // 
            // LExplicacion
            // 
            this.LExplicacion.AutoSize = true;
            this.LExplicacion.Location = new System.Drawing.Point(21, 34);
            this.LExplicacion.Name = "LExplicacion";
            this.LExplicacion.Size = new System.Drawing.Size(0, 13);
            this.LExplicacion.TabIndex = 1;
            // 
            // RTBTerminos
            // 
            this.RTBTerminos.Location = new System.Drawing.Point(24, 74);
            this.RTBTerminos.Name = "RTBTerminos";
            this.RTBTerminos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RTBTerminos.Size = new System.Drawing.Size(387, 262);
            this.RTBTerminos.TabIndex = 2;
            this.RTBTerminos.Text = "";
            this.RTBTerminos.VScroll += new System.EventHandler(this.RTBTerminos_VScroll);
            // 
            // PBotones
            // 
            this.PBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBotones.Controls.Add(this.BCancelar);
            this.PBotones.Controls.Add(this.BAceptar);
            this.PBotones.Controls.Add(this.CBAceptar);
            this.PBotones.Location = new System.Drawing.Point(27, 361);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(383, 66);
            this.PBotones.TabIndex = 3;
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(282, 32);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 5;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.Enabled = false;
            this.BAceptar.Location = new System.Drawing.Point(129, 32);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(147, 23);
            this.BAceptar.TabIndex = 4;
            this.BAceptar.Text = "¡¡ACEPTAR Y ADOPTAR!!";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // CBAceptar
            // 
            this.CBAceptar.AutoSize = true;
            this.CBAceptar.Enabled = false;
            this.CBAceptar.Location = new System.Drawing.Point(9, 9);
            this.CBAceptar.Name = "CBAceptar";
            this.CBAceptar.Size = new System.Drawing.Size(237, 17);
            this.CBAceptar.TabIndex = 0;
            this.CBAceptar.Text = "He leído y acepto los terminos y condiciones";
            this.CBAceptar.UseVisualStyleBackColor = true;
            this.CBAceptar.CheckedChanged += new System.EventHandler(this.CBAceptar_CheckedChanged);
            // 
            // FTerminosC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 439);
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.RTBTerminos);
            this.Controls.Add(this.LExplicacion);
            this.Controls.Add(this.LTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTerminosC";
            this.Text = "Terminos y Condiciones";
            this.Load += new System.EventHandler(this.FTerminosC_Load);
            this.PBotones.ResumeLayout(false);
            this.PBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LExplicacion;
        private System.Windows.Forms.RichTextBox RTBTerminos;
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.CheckBox CBAceptar;
    }
}