using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMOR_ANIMAL___MP
{
    public partial class FBienvenidos : Form
    {
        public FBienvenidos()
        {
            InitializeComponent();
        }

        private void BAdoptar_Click(object sender, EventArgs e)
        {
            // Mostrar el mensaje de si está registrado
            DialogResult resultado = MessageBox.Show("Para poder adoptar a su compañero ideal, tiene que estar registrado, ¿se encuentra registrado?", "Consulta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            
            if (resultado == DialogResult.Yes)
            {
                
                FInicioSesion inicioSesionForm = new FInicioSesion(); 
                inicioSesionForm.Show();
            }
            // Si el usuario no está registrado
            else if (resultado == DialogResult.No)
            {
                // Preguntar si quiere registrarse
                DialogResult registroResultado = MessageBox.Show("¿Desea registrarse?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (registroResultado == DialogResult.Yes)
                {
                    FRegistro registroForm = new FRegistro();
                    registroForm.Show();
                }

               
            }
        }

        private void FBienvenidos_Load(object sender, EventArgs e)
        {
            Lintro.Text = "¡Hola, amante de los peluditos!🐶😺\n"+"¿Listo para encontrar a tu nuevo mejor amigo?";
            Lintro.Font = new Font("Segoe UI", 14, FontStyle.Regular);
       

        }

        private void LLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string UrlInfo = "https://docs.google.com/document/d/1cbXGeanWXafJLtPa9qt7tf4iaV5ayf6bZSPzHq4K9iM/edit?usp=sharing";
            System.Diagnostics.Process.Start(UrlInfo);
        }
    }
}
