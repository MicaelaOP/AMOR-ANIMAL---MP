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
    public partial class FInicioSesion : Form
    {
        public FInicioSesion()
        {
            InitializeComponent();
        }

        private void BIniciarS_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = TBUsuario.Text.Trim(); 
            string claveIngresada = TBClaveInicio.Text.Trim();

            // Validar si el usuario existe
            if (usuarioIngresado != Datos_Usuario.Usuario)
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBUsuario.Focus();

            }    
            else if (claveIngresada != Datos_Usuario.Clave)
            {
                MessageBox.Show("Clave incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBClaveInicio.Focus(); 
                
            }
            else
            {
                // Si todo está correcto
                MessageBox.Show("Inicio de sesión exitoso", $"Hola {Datos_Usuario.Nombre.ToUpper()}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                FBusqueda busquedaForm = new FBusqueda();
                busquedaForm.Show(); 
                this.Close(); 
            }
               
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            FBienvenidos finicio = new FBienvenidos();
            finicio.Show(); 
            this.Close(); 
        }
    }
}
