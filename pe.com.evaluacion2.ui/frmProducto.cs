using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pe.com.evaluacion2.bal;
using pe.com.evaluacion2.bo;

namespace pe.com.evaluacion2.ui
{
    public partial class frmProducto : Form
    {
        private ProductoBAL bal = new ProductoBAL();
        private CategoriaBAL balcat = new CategoriaBAL();
        private MarcaBAL balmar = new MarcaBAL();
        private ProductoBO obj = new ProductoBO();
        private int cod = 0, indice = -1;
        private string nom;
        private bool est = false, res = false;

        public frmProducto()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Bloquear();
            SoloLectura();
            // Asegúrate de que dgvProducto esté inicializado correctamente
            if (dgvProducto == null)
            {
                MessageBox.Show("El control DataGridView no está inicializado.");
                return;
            }
            PersonalizarDataGridView();
            //llamamos a cargar los combos
            CargarCombos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Desbloquear();
            btnNuevo.Enabled = false;
            Limpiar();
            txtCod.Text = bal.MostrarCodigoProducto().ToString();
        }

        //creamos un procedimiento para poder bloquear los controles
        public void Bloquear()
        {
            txtCod.Enabled = false;
            txtNom.Enabled = false;
            txtDes.Enabled = false;
            txtPre.Enabled = false;
            txtCan.Enabled = false;
            cboCategoria.Enabled = false;
            cboMarca.Enabled = false;
            chkEst.Enabled = false;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnHabilitar.Enabled = false;
        }

        //creamos un procedimiento para desbloquear
        public void Desbloquear()
        {
            txtCod.Enabled = true;
            txtNom.Enabled = true;
            txtDes.Enabled = true;
            txtPre.Enabled = true;
            txtCan.Enabled = true;
            cboCategoria.Enabled = true;
            cboMarca.Enabled = true;
            chkEst.Enabled = true;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnHabilitar.Enabled = true;
        }

        private void Limpiar()
        {
            txtCod.Clear();
            txtNom.Clear();
            chkEst.Checked = false;
            txtNom.Focus();
        }

        //creamos un procedimiento de solo lectura
        private void SoloLectura()
        {
            txtCod.ReadOnly = true;
        }

        private void PersonalizarDataGridView()
        {
            // Asegúrate de que dgvProducto esté correctamente inicializado
            if (dgvProducto == null)
            {
                MessageBox.Show("El control DataGridView no está inicializado.");
                return;
            }

            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.AutoGenerateColumns = false;
            dgvProducto.Columns.Clear();
            //no permite que se agrega una fila en blanco
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.ClearSelection();
            dgvProducto.ReadOnly = true;
            dgvProducto.Columns.Add("codigo", "Codigo");
            dgvProducto.Columns.Add("nombre", "Nombre");
            dgvProducto.Columns.Add("descripcion", "Descripcion");
            dgvProducto.Columns.Add("precio", "Precio");
            dgvProducto.Columns.Add("cantidad", "Cantidad");
            dgvProducto.Columns.Add("marca", "Marca");
            dgvProducto.Columns.Add("categoria", "Categoria");
            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
            };
            dgvProducto.Columns.Add(colestado);

            // Verifica que la lista de productos no sea null antes de continuar
            List<ProductoBO> productos = bal.MostrarProductoTodo();
            if (productos != null)
            {
                for (int i = 0; i < productos.Count; i++)
                {
                    ProductoBO producto = productos[i];
                    dgvProducto.Rows.Add();
                    dgvProducto.Rows[i].Cells["codigo"].Value = producto.codigo;
                    dgvProducto.Rows[i].Cells["nombre"].Value = producto.nombre;
                    dgvProducto.Rows[i].Cells["descripcion"].Value = producto.descripcion;
                    dgvProducto.Rows[i].Cells["precio"].Value = producto.precio;
                    dgvProducto.Rows[i].Cells["cantidad"].Value = producto.cantidad;
                    dgvProducto.Rows[i].Cells["marca"].Value = producto.categoria.nombre;
                    dgvProducto.Rows[i].Cells["categoria"].Value = producto.marca.nombre;
                    dgvProducto.Rows[i].Cells["estado"].Value = producto.estado;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron productos.");
            }

            dgvProducto.CellFormatting += (s, e) =>
            {
                if (dgvProducto.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            foreach (DataGridViewColumn col in dgvProducto.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        //creamos un procedimiento para cargar los combos
        private void CargarCombos()
        {
            //generamos listas con los valores de la base de datos
            List<CategoriaBO> categorias = balcat.MostrarCategoria();
            List<MarcaBO> marcas = balmar.MostrarMarca();
            //insertamos valores dentro de las listas
            MarcaBO marca = new MarcaBO
            {
                codigo = 0,
                nombre = "Seleccione una marca",
                estado = false
            };
            CategoriaBO categoria = new CategoriaBO
            {
                codigo = 0,
                nombre = "Seleccione una categoria",
                estado = false
            };
            marcas.Insert(0, marca);
            categorias.Insert(0, categoria);
            //cargamos los combos
            //marca
            cboMarca.DataSource = marcas;
            cboMarca.DisplayMember = "nombre";
            cboCategoria.ValueMember = "codigo";
            //categoria
            cboCategoria.DataSource = categorias;
            cboCategoria.DisplayMember = "nombre";
            cboCategoria.ValueMember = "codigo";
            //combos de solo lectura
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
