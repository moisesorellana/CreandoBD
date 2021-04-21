using BL.Tecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.TiendaElectronicos
{
    public partial class FormLogin : Form
    {
        SeguridadBL Seguridad;

        public FormLogin()
        {
            InitializeComponent();

            Seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Contraseña;

            
         // Almacenando Valores en las Variables

            Usuario = textBox1.Text; // Recuerda : siempre colocar el nombre correcto de la herramienta a utilisar. (Ejemplo: textBox1)
            Contraseña = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "verificando";
            Application.DoEvents();
              

            var usuarioDB = Seguridad.Autorizar(Usuario, Contraseña);

            //   Usuario2 = textBox3.Text;
            // Contraseña2 = textBox4.Text;

            // Login a Usuario 1 y 2

            if (usuarioDB != null)
            {
                Utils.nombreUsuario = usuarioDB.Nombre;
                Utils.EnviarCorreo();
                this.Close();
            }
          //  else
         //   if (Usuario2 == "Empleado2" && Contraseña2 == "123")
         //   {
          //      this.Close();
          //  }
            else           
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
            }
            button1.Enabled = true;
            button1.Text = "Aceptar";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(textBox1.Text != "")
                {
                    textBox2.Focus();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textBox2.Text != "")
                {
                    button1_Click(null, null);
                }
            }
        }
    }
}
