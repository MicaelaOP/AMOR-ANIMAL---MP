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
        
        private void BInfoPolenta_Click(object sender, EventArgs e)
        {
            string info = "INFORMACIÓN DE POLENTA\n\n" + "Descripción: Gatito muy juguetón y cariñoso. " + "Le encanta correr y jugar con pelotas.\n\n" + "¿Te gustaría adoptarlo?";
            DialogResult resultado = MessageBox.Show(info, "Información de Polenta",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FTerminosC terminosForm = new FTerminosC();
                DialogResult terminosResultado = terminosForm.ShowDialog();

              if (terminosResultado == DialogResult.OK && terminosForm.TerminosAceptados)
              {
                    MessageBox.Show("Estas de acuerdo con nuestros terminos y condiciones.\n Ahora podes continuar con la adopción de Polenta.", "Términos Aceptados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("¡Gracias por adoptar a Polenta! " + "Nos pondremos en contacto pronto.","Adopción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

              }
              else
              {
                    MessageBox.Show("Adopción cancelada. Debes aceptar los términos y condiciones para continuar con la adopción.","Adopción Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult respuesta= MessageBox.Show("¿Desea volver al menú de busqueda?","Volver al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(respuesta == DialogResult.Yes)
                    {
                        FBusqueda formBusqueda = new FBusqueda();
                        formBusqueda.Show();
                        this.Close();
                    }
              }

            }
            else
            {
                MessageBox.Show("Esperamos que encuentres a tu compañero felino ideal.","Hasta pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                DialogResult respuestaBusqueda = MessageBox.Show("¿Desea volver al menú de búsqueda para ver otras mascotas?","Buscar otras mascotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuestaBusqueda == DialogResult.Yes)
                {
                    FBusqueda formBusqueda = new FBusqueda();
                    formBusqueda.Show();
                    this.Close();
                }
            }
        }

        private void BInfoLuz_Click(object sender, EventArgs e)
        {
            string info = "INFORMACIÓN DE LUZ\n\n" + "Descripción: Elegante y curiosa, le encanta explorar cada rincón. Muy cariñosa cuando entra en confianza. " + "\n\n" + "¿Te gustaría adoptarla?";
            DialogResult resultado = MessageBox.Show(info, "Información de Luz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FTerminosC terminosForm = new FTerminosC();
                DialogResult terminosResultado = terminosForm.ShowDialog();

                if (terminosResultado == DialogResult.OK && terminosForm.TerminosAceptados)
                {
                    MessageBox.Show("Estás de acuerdo con nuestros términos y condiciones.\n Ahora podes continuar con la adopción de Luz.", "Términos Aceptados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("¡Gracias por adoptar a Luz! " + "Nos pondremos en contacto pronto.", "Adopción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Adopción cancelada. Debes aceptar los términos y condiciones para continuar con la adopción.", "Adopción Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    DialogResult respuesta = MessageBox.Show("¿Deseas volver al menú de búsqueda?", "Volver al Menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                MessageBox.Show("Esperamos que encuentres a tu compañera felina ideal.","Hasta Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult respuestaBusqueda = MessageBox.Show("¿Deseas volver al menú de búsqueda para ver otras mascotas?","Buscar Otras Mascotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuestaBusqueda == DialogResult.Yes)
                {
                    FBusqueda formBusqueda = new FBusqueda();
                    formBusqueda.Show();
                    this.Close();
                }

            }
        }

        private void BInfoMora_Click(object sender, EventArgs e)
        {
            string info = "INFORMACIÓN DE MORA\n\n" + "Descripción: Tranquila y mimosa. Ideal para quienes buscan una compañera " +"serena que disfrute del sillón y los mimos.\n\n" + " ¿Te gustaría adoptarla?";

            DialogResult resultado = MessageBox.Show(info, "Información de Mora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FTerminosC terminosForm = new FTerminosC();
                DialogResult terminosResultado = terminosForm.ShowDialog();

                if (terminosResultado == DialogResult.OK && terminosForm.TerminosAceptados)
                {
                    MessageBox.Show("Estás de acuerdo con nuestros términos y condiciones.\n Ahora podes continuar con la adopción de Mora.","Términos Aceptados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("¡Gracias por adoptar a Mora! " +" Nos pondremos en contacto pronto."," Adopción Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Adopción cancelada. Debes aceptar los términos y condiciones para continuar con la adopción.","Adopción Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    DialogResult respuesta = MessageBox.Show("¿Deseas volver al menú de búsqueda?", "Volver al Menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                MessageBox.Show("Esperamos que encuentres a tu compañera felina ideal.", "Hasta Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult respuestaBusqueda = MessageBox.Show("¿Deseas volver al menú de búsqueda para ver otras mascotas?","Buscar Otras Mascotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
 
