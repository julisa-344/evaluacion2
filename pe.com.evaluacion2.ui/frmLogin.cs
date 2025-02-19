using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe.com.evaluacion2.ui
{
    public partial class frmLogin : Form
    {
        private UsuarioBAL usuarioBAL = new UsuarioBAL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            if (usuario == "" || clave == "")
            {
                lblMensaje.Text = "Por favor, ingrese usuario y clave.";
                return;
            }

            bool esValido = usuarioBAL.ValidarUsuario(usuario, clave);
            if (esValido)
            {
                lblMensaje.Text = "Login exitoso.";
                // Aquí puedes abrir el formulario principal de tu aplicación
                this.Hide();
                frmMenu principal = new frmMenu(); // Cambia esto por tu formulario principal
                principal.Show();
            }
            else
            {
                lblMensaje.Text = "Usuario o clave incorrectos.";
            }
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
