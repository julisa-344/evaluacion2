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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRol rolForm = new frmRol();
            rolForm.ShowDialog(); // Abre el formulario de rol como un diálogo
            this.Show(); // Muestra nuevamente el formulario de menú al cerrar el diálogo
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCategoria categoriaForm = new frmCategoria();
            categoriaForm.ShowDialog();
            this.Show();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMarca marcaForm = new frmMarca();
            marcaForm.ShowDialog();
            this.Show();
        }

        private void btnDistrito_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDistrito distritoForm = new frmDistrito();
            distritoForm.ShowDialog();
            this.Show();
        }

        private void btnTipoDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTipoDocumento tipoDocForm = new frmTipoDocumento();
            tipoDocForm.ShowDialog();
            this.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmpleado empleadoForm = new frmEmpleado();
            empleadoForm.ShowDialog();
            this.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCliente clienteForm = new frmCliente();
            clienteForm.ShowDialog();
            this.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProducto productoForm = new frmProducto();
            productoForm.ShowDialog();
            this.Show();
        }
    }
}
