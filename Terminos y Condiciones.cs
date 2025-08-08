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
    public partial class FTerminosC : Form
    {
        
        public bool TerminosAceptados { get; private set; } = false;

       
        private bool formularioCargado = false;

        public FTerminosC()
        {
            InitializeComponent();
            LTitulo.Text = "🐾 AMOR ANIMAL - Términos y Condiciones 💕";
            LExplicacion.Text = "Por favor, lee los términos y condiciones, para poder adoptar:";
           
            CargarTerminosYCondiciones();

         
            formularioCargado = true;
        }
        private void CargarTerminosYCondiciones()
        {
            string terminos = @"TÉRMINOS Y CONDICIONES DE USO - AMOR ANIMAL

                Última actualización: " + DateTime.Now.ToString("dd/MM/yyyy") + @"

                1. ACEPTACIÓN DE TÉRMINOS
                Al acceder y utilizar la plataforma Amor Animal, usted acepta estar sujeto a estos términos y condiciones de uso. Si no está de acuerdo con alguna parte de estos términos, no debe utilizar nuestros servicios.

                2. DESCRIPCIÓN DEL SERVICIO
                Amor Animal es una plataforma dedicada al bienestar animal que facilita:
                - Adopción responsable de mascotas
                - Servicios veterinarios
                - Productos para el cuidado animal
                - Información educativa sobre tenencia responsable

                3. RESPONSABILIDADES DEL USUARIO
                El usuario se compromete a:
                - Proporcionar información veraz y actualizada
                - Utilizar la plataforma de manera responsable
                - Respetar los derechos de los animales
                - Cumplir con las leyes locales sobre tenencia de mascotas
                - No utilizar la plataforma para actividades ilegales

                4. PROCESO DE ADOPCIÓN
                Para adopciones de mascotas:
                - Se requiere evaluación previa del adoptante
                - Compromiso de cuidado responsable
                - Seguimiento post-adopción
                - Derecho de la organización a verificar condiciones

                5. PRIVACIDAD Y PROTECCIÓN DE DATOS
                - Recopilamos datos necesarios para brindar el servicio
                - No compartimos información personal sin consentimiento
                - Utilizamos medidas de seguridad para proteger datos
                - El usuario puede solicitar eliminación de sus datos

                6. CONTENIDO Y PROPIEDAD INTELECTUAL
                - Todo el contenido está protegido por derechos de autor
                - Los usuarios pueden compartir contenido bajo licencia apropiada
                - Prohibido el uso comercial sin autorización

                7. LIMITACIÓN DE RESPONSABILIDAD
                Amor Animal no se responsabiliza por:
                - Daños indirectos o consecuenciales
                - Pérdida de datos o interrupciones del servicio
                - Acciones de terceros en la plataforma

                8. MODIFICACIONES
                Nos reservamos el derecho de modificar estos términos en cualquier momento. Los cambios serán notificados a través de la plataforma.

                9. TERMINACIÓN
                Podemos suspender o terminar el acceso por violación de estos términos.

                10. LEY APLICABLE
                Estos términos se rigen por las leyes de Argentina.

                11. CONTACTO
                Para consultas sobre estos términos:
                Email: legal@amoranimal.com
                Teléfono: +54 0303456

                12. COMPROMISO CON EL BIENESTAR ANIMAL
                Como parte de nuestra misión, todos los usuarios se comprometen a:
                - Promover el trato ético hacia los animales
                - Denunciar casos de maltrato animal
                - Apoyar la esterilización responsable
                - Educar sobre tenencia responsable

                Al aceptar estos términos, usted confirma que ha leído, entendido y acepta cumplir con todas las disposiciones aquí establecidas.

                ¡Gracias por ser parte de la comunidad Amor Animal! 🐾💕";

           
            RTBTerminos.Text = terminos;
            RTBTerminos.SelectionStart = 0;
            RTBTerminos.ScrollToCaret();
        }
        private void HabilitarCheckbox()
        {
            if (!CBAceptar.Enabled)
            {
                CBAceptar.Enabled = true;
                MessageBox.Show("¡Ya puedes aceptar los términos!", "Términos Leídos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }


        private void CBAceptar_CheckedChanged(object sender, EventArgs e)
        {
            BAceptar.Enabled = CBAceptar.Checked;
        }

        private void RTBTerminos_VScroll(object sender, EventArgs e)
        {
           
            if (!formularioCargado) return;

            RichTextBox rtb = sender as RichTextBox;

           
            int lastVisibleChar = rtb.GetCharIndexFromPosition(new Point(0, rtb.Height));

            
            if (lastVisibleChar >= rtb.TextLength - 150)
            {
                HabilitarCheckbox();
            }
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
           
            string nombreUsuario = Datos_Usuario.Nombre;

            string mensajeAgradecimiento = $@"¡GRACIAS POR ADOPTAR,{nombreUsuario.ToUpper()}!

                Estamos muy contentos de que hayas decidido darle un hogar a una de nuestras mascotas.

                Próximos pasos:
                • Nos pondremos en contacto contigo en las próximas 24-48 horas
            

                ¡Gracias por hacer la diferencia en la vida de un animal!";

        
                MessageBox.Show(mensajeAgradecimiento,"¡Adopción Confirmada!", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            
            TerminosAceptados = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
        //private void FTerminosC_Load(object sender, EventArgs e)
        //{
        //}
    }
}
