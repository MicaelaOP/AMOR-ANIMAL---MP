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
    public partial class FBusqueda : Form
    {
        public FBusqueda()
        {
            InitializeComponent();
        }

        private void FBusqueda_Load(object sender, EventArgs e)
        {
            LSaludoB.Text = "HOLA " + Datos_Usuario.Nombre.ToUpper()+ " BIENVENID@ A AMOR ANIMAL !";
        }

        private void BPerro_Click(object sender, EventArgs e)
        {
            Busqueda_Perro formBusqueda = new Busqueda_Perro();
            formBusqueda.ShowDialog();  
            this.Close();
        }

        private void BGato_Click(object sender, EventArgs e)
        {
            Busqueda_Gato formBusqueda= new Busqueda_Gato();    
            formBusqueda.ShowDialog();
            this.Close();   
        }

        private void BAtras_Click(object sender, EventArgs e)
        {
            FInicioSesion formBusqueda = new FInicioSesion();
            formBusqueda.Show();
            this.Close();
        }
    }
}
