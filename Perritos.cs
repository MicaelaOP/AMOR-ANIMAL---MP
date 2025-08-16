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
    public partial class Busqueda_Perro : Form
    {
        public Busqueda_Perro()
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
                    DialogResult respuesta = MessageBox.Show("¿Desea volver al menú de busqueda de perrito ?", "Volver al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        Busqueda_Perro formPerrito = new Busqueda_Perro();
                        formPerrito.Show();
                        this.Close();
                    }
                    else if (respuesta == DialogResult.No)
                    {
                        DialogResult respuesta2 = MessageBox.Show("¿Desea volver al menú de busqueda ?", "Volver al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (respuesta2 == DialogResult.Yes)
                        {
                            VolverMenuBusqueda();
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show($"Esperamos que encuentres a tu {genero} ideal.", "Hasta pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult respuestaBusqueda = MessageBox.Show("¿Desea volver al menú de búsqueda para ver otras mascotas?", "Buscar otras mascotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuestaBusqueda == DialogResult.Yes)
                {
                    VolverMenuBusqueda();
                }
            }
        }


        private void BInfoPachi_Click(object sender, EventArgs e)
        {
            string descripcion = "Descripción: Un compañero leal y juguetón. Le encanta correr y recibir mimos. ";
            RealizarAdopcion("Pachi", descripcion, "lo", "compañero perruno");
           
        }

        private void BInfoLola_Click(object sender, EventArgs e)
        {
            string descripcion = "Descripción:Curiosa y dulce, siempre lista para una aventura. Se lleva bien con otros animales y niños. ";
            RealizarAdopcion("Lola", descripcion, "la", "compañera perruna");

        }

        private void BInfoRoman_Click(object sender, EventArgs e)
        {
            string descripcion = "Descripción:Tranquilo y cariñoso. Disfruta de las siestas al sol y los paseos tranquilos.";
            RealizarAdopcion("Roman", descripcion, "lo", "compañero perruno");

        }

        private void BInfoCielo_Click(object sender, EventArgs e)
        {
            string descripcion ="Descripción: Muy tierna y obediente. Le encanta estar acompañada y dar amor. ";
            RealizarAdopcion("Cielo", descripcion, "la", "compañera perruna");
            
        }

        private void BAtras_Click(object sender, EventArgs e)
        {
            VolverMenuBusqueda();
        }
    }
}
