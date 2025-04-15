using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void picIFTS_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando llega al foco */

            if(txtUsuario.Text == "Ingrese su Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando se va el foco*/

            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su Usuario";
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando llega al foco */

            if (txtContrasena.Text == "Ingrese su Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.UseSystemPasswordChar = true;
            }

        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando se va el foco*/

            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Ingrese su Contraseña";
                txtContrasena.UseSystemPasswordChar = false;
            }
        }
    }
}
