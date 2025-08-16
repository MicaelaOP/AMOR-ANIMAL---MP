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
    public partial class Busqueda_Gato : Form
    {
        public Busqueda_Gato()
        {
            InitializeComponent();
        }
        private void VolverMenuBusqueda()
        {
            FBusqueda formBusqueda = new FBusqueda();
            formBusqueda.Show();
            this.Close();
        }
        private void RealizarAdopcion(string nombreMascota, string descripcion, string pronombre, string genero)
        {
            string info = $"INFORMACIÓN DE {nombreMascota.ToUpper()}\n\n {descripcion}\n\n¿ Te gustaria adoptar{pronombre}?";
            DialogResult resultado = MessageBox.Show(info, $"Información de {nombreMascota}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FTerminosC terminosForm = new FTerminosC();
                DialogResult terminosResultado = terminosForm.ShowDialog();

                if (terminosResultado == DialogResult.OK && terminosForm.TerminosAceptados)
                {
                    MessageBox.Show($"Estas de acuerdo con nuestros terminos y condiciones.\n Ahora podes continuar con la adopción de {nombreMascota}.", "Términos Aceptados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"¡Gracias por adoptar a {nombreMascota}! " + "Nos pondremos en contacto pronto.", "Adopción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Adopción cancelada. Debes aceptar los términos y condiciones para continuar con la adopción.", "Adopción Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult respuesta = MessageBox.Show("¿Desea volver al menú de busqueda de michi?", "Volver al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        Busqueda_Gato formMichi = new Busqueda_Gato();
                        formMichi.Show();
                        this.Close();   
                    }
                    else if (respuesta== DialogResult.No)
                    {
                        DialogResult respuesta2 = MessageBox.Show("¿Desea volver al menú de busqueda ?", "Volver al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if(respuesta2 == DialogResult.Yes)
                        {
                            VolverMenuBusqueda();
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show($"Esperamos que encuentres a tu {genero} ideal.","Hasta pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult respuestaBusqueda = MessageBox.Show("¿Desea volver al menú de búsqueda para ver otras mascotas?","Buscar otras mascotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuestaBusqueda == DialogResult.Yes)
                {
                    VolverMenuBusqueda();
                }
            }
        }
        
        private void BInfoPolenta_Click(object sender, EventArgs e)
        {
            string descripcion = "Descripcion: Gatito muy jugueton y cariñoso. Le encanta correr y jugar con pelotas";
            RealizarAdopcion("Polenta", descripcion, "lo", "compañero felino");
           
        }

        private void BInfoLuz_Click(object sender, EventArgs e)
        {
            string descripcion = "Descripción: Elegante y curiosa, le encanta explorar cada rincón. Muy cariñosa cuando entra en confianza. ";
            RealizarAdopcion ("Luz",descripcion,"la","compañera felina");

        }

        private void BInfoMora_Click(object sender, EventArgs e)
        {
            string descripcion = "Descripción: Tranquila y mimosa. Ideal para quienes buscan una compañera tranquila que disfrute del sillón y los mimos. ";
            RealizarAdopcion("Mora", descripcion, "la", "compañera felina");

            
        }

        private void BAtras_Click(object sender, EventArgs e)
        {
            VolverMenuBusqueda();
        }
     
       
    }
}
 
