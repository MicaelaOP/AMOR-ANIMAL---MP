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

        private void BInfoPachi_Click(object sender, EventArgs e)
        {
            string info = "INFORMACIÓN DE PACHI\n\n" + "Descripción: Un compañero leal y juguetón. Le encanta correr y recibir mimos. " + "\n\n" + "¿Te gustaría adoptarlo?";
            DialogResult resultado = MessageBox.Show(info, "Información de Pachi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FTerminosC terminosForm = new FTerminosC();
                DialogResult terminosResultado = terminosForm.ShowDialog();

                if (terminosResultado == DialogResult.OK && terminosForm.TerminosAceptados)
                {
                    MessageBox.Show("Estas de acuerdo con nuestros terminos y condiciones.\n Ahora podes continuar con la adopción de Pachi.", "Términos Aceptados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("¡Gracias por adoptar a Pachi! " + "Nos pondremos en contacto pronto.", "Adopción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Adopción cancelada. Debes aceptar los términos y condiciones para continuar con la adopción.", "Adopción Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult respuesta = MessageBox.Show("¿Desea volver al menú de busqueda?", "Volver al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        FBusqueda formBusqueda = new FBusqueda();
                        formBusqueda.Show();
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Esperamos que encuentres a tu compañero perruno ideal.", "Hasta pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                DialogResult respuestaBusqueda = MessageBox.Show("¿Desea volver al menú de búsqueda para ver otras mascotas?", "Buscar otras mascotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuestaBusqueda == DialogResult.Yes)
                {
                    FBusqueda formBusqueda = new FBusqueda();
                    formBusqueda.Show();
                    this.Close();
                }
            }
        }

        private void BInfoLola_Click(object sender, EventArgs e)
        {
            string info = "INFORMACIÓN DE LOLA\n\n" + "Descripción:Curiosa y dulce, siempre lista para una aventura. Se lleva bien con otros animales y niños. " + "\n\n" + "¿Te gustaría adoptarla?";
            DialogResult resultado = MessageBox.Show(info, "Información de Lola", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FTerminosC terminosForm = new FTerminosC();
                DialogResult terminosResultado = terminosForm.ShowDialog();

                if (terminosResultado == DialogResult.OK && terminosForm.TerminosAceptados)
                {
                    MessageBox.Show("Estas de acuerdo con nuestros terminos y condiciones.\n Ahora podes continuar con la adopción de Lola.", "Términos Aceptados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("¡Gracias por adoptar a Lola! " + "Nos pondremos en contacto pronto.", "Adopción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Adopción cancelada. Debes aceptar los términos y condiciones para continuar con la adopción.", "Adopción Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult respuesta = MessageBox.Show("¿Desea volver al menú de busqueda?", "Volver al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        FBusqueda formBusq = new FBusqueda();
                        formBusq.Show();
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Esperamos que encuentres a tu compañero perruno ideal.", "Hasta pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
                DialogResult respuestaBusqueda = MessageBox.Show("¿Desea volver al menú de búsqueda para ver otras mascotas?", "Buscar otras mascotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuestaBusqueda == DialogResult.Yes)
                {
                    FBusqueda formBusqueda = new FBusqueda();
                    formBusqueda.Show();
                    this.Close();
                }
            }
        }

        private void BInfoRoman_Click(object sender, EventArgs e)
        {
            string info = "INFORMACIÓN DE ROMAN\n\n" + "Descripción:Tranquilo y cariñoso. Disfruta de las siestas al sol y los paseos tranquilos." +"\n\n" + "¿Te gustaría adoptarlo?";
            DialogResult resultado = MessageBox.Show(info, "Información de Roman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FTerminosC terminosForm = new FTerminosC();
                DialogResult terminosResultado = terminosForm.ShowDialog();

                if (terminosResultado == DialogResult.OK && terminosForm.TerminosAceptados)
                {
                    MessageBox.Show("Estas de acuerdo con nuestros terminos y condiciones.\n Ahora podes continuar con la adopción de Roman.", "Términos Aceptados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("¡Gracias por adoptar a Roman! " + "Nos pondremos en contacto pronto.", "Adopción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Adopción cancelada. Debes aceptar los términos y condiciones para continuar con la adopción.", "Adopción Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult respuesta = MessageBox.Show("¿Desea volver al menú de busqueda?", "Volver al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        FBusqueda formBusqueda = new FBusqueda();
                        formBusqueda.Show();
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Esperamos que encuentres a tu compañero perruno ideal.", "Hasta pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult respuestaBusqueda = MessageBox.Show("¿Desea volver al menú de búsqueda para ver otras mascotas?", "Buscar otras mascotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuestaBusqueda == DialogResult.Yes)
                {
                    FBusqueda formBusqueda = new FBusqueda();
                    formBusqueda.Show();
                    this.Close();
                }
            }
        }

        private void BInfoCielo_Click(object sender, EventArgs e)
        {
            string info = "INFORMACIÓN DE CIELO\n\n" + "Descripción: Muy tierna y obediente. Le encanta estar acompañada y dar amor. " +"\n\n" + "¿Te gustaría adoptarla?"; 
            DialogResult resultado = MessageBox.Show(info, "Información de Cielo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                FTerminosC terminosForm = new FTerminosC();
                DialogResult terminosResultado = terminosForm.ShowDialog();

                if (terminosResultado == DialogResult.OK && terminosForm.TerminosAceptados)
                {
                    MessageBox.Show("Estas de acuerdo con nuestros terminos y condiciones.\n Ahora podes continuar con la adopción de Cielo.", "Términos Aceptados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("¡Gracias por adoptar a Cielo! " + "Nos pondremos en contacto pronto.", "Adopción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Adopción cancelada. Debes aceptar los términos y condiciones para continuar con la adopción.", "Adopción Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult respuesta = MessageBox.Show("¿Desea volver al menú de busqueda?", "Volver al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        FBusqueda formBusqueda = new FBusqueda();
                        formBusqueda.Show();
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Esperamos que encuentres a tu compañero perruno ideal.", "Hasta pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                DialogResult respuestaBusqueda = MessageBox.Show("¿Desea volver al menú de búsqueda para ver otras mascotas?", "Buscar otras mascotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuestaBusqueda == DialogResult.Yes)
                {
                    FBusqueda formBusqueda = new FBusqueda();
                    formBusqueda.Show();
                    this.Close();
                }
            }
        }

        private void BAtras_Click(object sender, EventArgs e)
        {
            FBusqueda formBusqueda = new FBusqueda();
            formBusqueda.Show();
            this.Close();
        }
    }
}
