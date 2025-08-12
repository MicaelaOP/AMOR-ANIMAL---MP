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
    public partial class FRegistro : Form
    {
        public FRegistro()
        {
            InitializeComponent();
        }

        private void BRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = TBNombre.Text.Trim();
            string apellido = TBApellido.Text.Trim();
            string email = TBEmail.Text.Trim();
            string clave = TBClave.Text.Trim();
            string telefono = MTBTel.Text.Trim();

            bool arroba = false;
            bool punto = false;
            int posArroba = -1;
            int posPunto = -1;
            int cantLetras = 0;
            int cantNumeros = 0;
            int cantSimbolos = 0;

            // Validaciones de campos 
            if (nombre == "")
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBNombre.Focus();
                
            }
             else if (apellido == "")
             {
                MessageBox.Show("DEBE INGRESAR UN APELLIDO", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBApellido.Focus();

             }
            else if (email == "")
            {
                MessageBox.Show("DEBE INGRESAR UN EMAIL", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBEmail.Focus();
              
            }
            else if (clave == "")
            {
                MessageBox.Show("DEBE INGRESAR UNA CONTRASEÑA", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBClave.Focus();
      
            }
            else
            {
                // Validación de email
                for (int indice = 0; indice < email.Length; indice++)
                {
                    if (email[indice] == '@')
                    {
                        arroba = true;
                        posArroba = indice;
                    }
                    else if (email[indice] == '.')
                    {
                        punto = true;
                        posPunto = indice;
                    }
                }
            }


            if ((!arroba) || (!punto) || (posArroba >= posPunto))
            {
                MessageBox.Show("DEBE INGRESAR UN EMAIL VALIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBEmail.Focus();
            
            }
            else if (clave.Length < 8)
            {
                MessageBox.Show("LA CONTRASEÑA DEBE TENER MINIMO 8 CARACTERES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBClave.Focus();
                
            }
            else
            {
                for (int indice = 0; indice < clave.Length; indice++)
                {
                      char c = clave[indice];
                      if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                      {
                         cantLetras++;
                      }
                      else if ((c >= '0') && (c <= '9'))
                      {
                         cantNumeros++;
                      }
                      else if ((c >= '!') && (c <= '/') || (c >= ':') && (c <= '@') || (c >= '[') && (c <= '`') || (c >= '{') && (c <= '~'))
                      {
                        cantSimbolos++;
                      }
                }
            }
                

            if ((cantLetras == 0) || (cantNumeros == 0) || (cantSimbolos == 0))
            {
                MessageBox.Show("LA CONTRASEÑA DEBE TENER AL MENOS UNA LETRA, UN NUMERO Y UN SIMBOLO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBClave.Focus();
                
            }
            else
            {
                string mensaje = $"¿Está de acuerdo con los siguientes datos?\n" + $"Nombre: {nombre}\n" + $"Apellido: {apellido}\n" + $"Email: {email}\n" + $"Clave: {clave}";

                DialogResult resultado = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
               
                      Datos_Usuario.Usuario = $"{nombre[0]}{apellido[0]}".ToUpper(); // Crear el usuario
                      Datos_Usuario.Clave = clave;
                      Datos_Usuario.Nombre = nombre; 

                
                    MessageBox.Show($"Usuario creado exitosamente:\n\nUsuario: {Datos_Usuario.Usuario}\nClave: {Datos_Usuario.Clave}", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    FInicioSesion inicioSesionForm = new FInicioSesion();
                    inicioSesionForm.Show();
                    this.Close(); 
                }

            }


        }
    }
}
