using pe.com.evaluacion2.bal;
using pe.com.evaluacion2.bo;
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
    public partial class frmCategoria : Form
    {
        //crear un objeto de la CategoriaBAL
        private CategoriaBAL bal = new CategoriaBAL();
        //crear un objeto de CategoriaBO
        private CategoriaBO obj = new CategoriaBO();
        //declarando variables
        private int cod = 0, indice = -1;
        private string nom;
        private bool est = false, res = false;

        public frmCategoria()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //bloqueamos los controles
            Bloquear();
            //cargamos el DataGridView
            CargarCategoria();
            //hacemos de solo lectura
            SoloLectura();
            //llamamos al personalizar DatagridView
            PersonalizarDataGridView();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //llamamos al procedimiento pára desbloquear
            Desbloquear();
            //bloqueamos el boton nuevo
            btnNuevo.Enabled = false;
            //limpiamos
            Limpiar();
            txtCod.Text = bal.MostrarCodigoCategoria().ToString();
        }

        //creamos un procedimiento para poder bloquear los controles
        public void Bloquear()
        {
            txtCod.Enabled = false;
            txtNom.Enabled = false;
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
            chkEst.Enabled = true;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnHabilitar.Enabled = true;
        }

        //creamos un procedimiento para cargar el DataGridView
        public void CargarCategoria()
        {
            List<CategoriaBO> categorias = bal.MostrarCategoriaTodo();
            //asignamos la lista al datagridview
            dgvCategoria.DataSource = categorias;
            //MessageBox.Show(categorias.Count() + "");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validaciones
            if (txtNom.Text == "")
            {
                MessageBox.Show("Ingresa el Nombre");
                txtNom.Focus();
            }
            else
            {
                //capturando valores
                nom = txtNom.Text;
                if (chkEst.Checked == true)
                {
                    est = true;
                }
                else
                {
                    est = false;
                }
                //enviamos los datos al objeto
                obj.nombre = nom;
                obj.estado = est;
                //ejecutamos la funcion
                res = bal.RegistrarCategoria(obj);
                if (res == true)
                {
                    MessageBox.Show("Se registro la categoria");
                    CargarCategoria();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede registrar la categoria");
                    Limpiar();
                }

            }
        }

        //creamos un procedimiento para limpiar
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

        //private void PersonalizarDataGridView()
        //{
        //    //ajustar el tamaño de ls columnas
        //    dgvCategoria.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.AllCells;
        //    //ajustar el ancho para llenar el Datagridview
        //    dgvCategoria.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
        //    //evitar que se autogenera las columnas
        //    dgvCategoria.AutoGenerateColumns = false;

        //    //asignando titulos a la columna
        //    if (dgvCategoria.Columns.Contains("codigo")) dgvCategoria.Columns["codigo"].HeaderText = "Codigo";
        //    if (dgvCategoria.Columns.Contains("nombre")) dgvCategoria.Columns["nombre"].HeaderText = "Nombre";
        //    if (dgvCategoria.Columns.Contains("estado")) dgvCategoria.Columns["estado"].HeaderText = "Estado";

        //    //centrar el texto
        //    foreach(DataGridViewColumn col in dgvCategoria.Columns)
        //    {
        //        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    }

        //    //eliminamos la seleccion al iniciar
        //    dgvCategoria.ClearSelection();

        //    //hacemos de solo lectura el datagridview
        //    dgvCategoria.ReadOnly = true;
        //}

        private void PersonalizarDataGridView()
        {
            //ajustar el tamaño de ls columnas
            dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //ajustar el ancho para llenar el Datagridview
            dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //evitar que se autogenera las columnas
            dgvCategoria.AutoGenerateColumns = false;

            //limpiar columnas existentes
            dgvCategoria.Columns.Clear();

            //eliminamos la seleccion al iniciar
            dgvCategoria.ClearSelection();

            //hacemos de solo lectura el datagridview
            dgvCategoria.ReadOnly = true;

            //definimos las columnas de forma manual
            dgvCategoria.Columns.Add("codigo", "Codigo");
            //agrego a la columna la propiedad que viene de la clase
            dgvCategoria.Columns["codigo"].DataPropertyName = "codigo";

            //definimos las columnas de forma manual
            dgvCategoria.Columns.Add("nombre", "Nombre");
            //agrego a la columna la propiedad que viene de la clase
            dgvCategoria.Columns["nombre"].DataPropertyName = "nombre";

            //creamos una columna personalizada
            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };

            //agregamos la columna
            dgvCategoria.Columns.Add(colestado);
            //formato para la visualizacion de la columna estado
            dgvCategoria.CellFormatting += (s, e) =>
            {
                if (dgvCategoria.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            //centrar el texto
            foreach (DataGridViewColumn col in dgvCategoria.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //capturando el indice seleccionado
            indice = e.RowIndex;
            //verificamos que se haya seleccinado un valor
            if (indice >= 0)
            {
                //desbloqueamos
                Desbloquear();
                btnRegistrar.Enabled = false;
                DataGridViewRow filaseleccinada = dgvCategoria.Rows[indice];
                txtCod.Text = filaseleccinada.Cells["codigo"].Value.ToString();
                txtNom.Text = filaseleccinada.Cells["nombre"].Value.ToString();
                if (Convert.ToBoolean(filaseleccinada.Cells["estado"].Value))
                {
                    chkEst.Checked = true;
                }
                else
                {
                    chkEst.Checked = false;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //capturando valores
            cod = Convert.ToInt32(txtCod.Text);
            nom = txtNom.Text;
            if (chkEst.Checked == true)
            {
                est = true;
            }
            else
            {
                est = false;
            }
            //enviamos los datos al objeto
            obj.codigo = cod;
            obj.nombre = nom;
            obj.estado = est;
            //ejecutamos la funcion
            res = bal.ActualizarCategoria(obj);
            if (res == true)
            {
                MessageBox.Show("Se actualizo la categoria");
                CargarCategoria();
                //limpiamos los controles
                Limpiar();
                //Bloqueamos
                Bloquear();
                //Desbloqueamos el boton nuevo
                btnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se puede actualizar la categoria");
                Limpiar();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //capturando valores
            cod = Convert.ToInt32(txtCod.Text);
            //enviamos los datos al objeto
            obj.codigo = cod;
            //declaramos una variable para el cuadro de dialogo
            DialogResult resultado = MessageBox.Show("¿Quieres eliminar la categoria?", "Eliminando Categoria", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //ejecutamos la funcion
                res = bal.EliminarCategoria(obj);
                if (res == true)
                {
                    MessageBox.Show("Se elimino la categoria");
                    CargarCategoria();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede elmiminar la categoria");
                    Limpiar();
                }
            }

        }

        private void btnHabilitar_Click_1(object sender, EventArgs e)
        {
            //capturando valores
            cod = Convert.ToInt32(txtCod.Text);
            //enviamos los datos al objeto
            obj.codigo = cod;
            //declaramos una variable para el cuadro de dialogo
            DialogResult resultado = MessageBox.Show("¿Quieres habilitar la categoria?", "Habilitando Categoria", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //ejecutamos la funcion
                res = bal.HabilitarCategoria(obj);
                if (res == true)
                {
                    MessageBox.Show("Se habilito la categoria");
                    CargarCategoria();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede habilitar la categoria");
                    Limpiar();
                }
            }
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            //validaciones
            if (txtNom.Text == "")
            {
                MessageBox.Show("Ingresa el Nombre");
                txtNom.Focus();
            }
            else
            {
                //capturando valores
                nom = txtNom.Text;
                if (chkEst.Checked == true)
                {
                    est = true;
                }
                else
                {
                    est = false;
                }
                //enviamos los datos al objeto
                obj.nombre = nom;
                obj.estado = est;
                //ejecutamos la funcion
                res = bal.RegistrarCategoria(obj);
                if (res == true)
                {
                    MessageBox.Show("Se registro la categoria");
                    CargarCategoria();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede registrar la categoria");
                    Limpiar();
                }

            }
        }

    }
}