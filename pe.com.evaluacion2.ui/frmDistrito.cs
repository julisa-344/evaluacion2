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
    public partial class frmDistrito : Form
    {
        //crear un objeto de la DistritoBAL
        private DistritoBAL bal = new DistritoBAL();
        //crear un objeto de DistritoBO
        private DistritoBO obj = new DistritoBO();
        //declarando variables
        private int cod = 0, indice = -1;
        private string nom;
        private bool est = false, res = false;

        public frmDistrito()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //bloqueamos los controles
            Bloquear();
            //cargamos el DataGridView
            CargarDistrito();
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
            txtCod.Text = bal.MostrarCodigoDistrito().ToString();
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
        public void CargarDistrito()
        {
            List<DistritoBO> distritos = bal.MostrarDistritoTodo();
            //asignamos la lista al datagridview
            dgvDistrito.DataSource = distritos;
            //MessageBox.Show(Distritos.Count() + "");
        }

        private void btnRegistrar_Click_2(object sender, EventArgs e)
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
                res = bal.RegistrarDistrito(obj);
                if (res == true)
                {
                    MessageBox.Show("Se registro la Distrito");
                    CargarDistrito();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede registrar la Distrito");
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

        private void PersonalizarDataGridView()
        {
            dgvDistrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //ajustar el ancho para llenar el Datagridview
            dgvDistrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //evitar que se autogenera las columnas
            dgvDistrito.AutoGenerateColumns = false;

            //limpiar columnas existentes
            dgvDistrito.Columns.Clear();

            //eliminamos la seleccion al iniciar
            dgvDistrito.ClearSelection();

            //hacemos de solo lectura el datagridview
            dgvDistrito.ReadOnly = true;

            //definimos las columnas de forma manual
            dgvDistrito.Columns.Add("codigo", "Codigo");
            //agrego a la columna la propiedad que viene de la clase
            dgvDistrito.Columns["codigo"].DataPropertyName = "codigo";

            //definimos las columnas de forma manual
            dgvDistrito.Columns.Add("nombre", "Nombre");
            //agrego a la columna la propiedad que viene de la clase
            dgvDistrito.Columns["nombre"].DataPropertyName = "nombre";

            //creamos una columna personalizada
            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };

            //agregamos la columna
            dgvDistrito.Columns.Add(colestado);
            //formato para la visualizacion de la columna estado
            dgvDistrito.CellFormatting += (s, e) =>
            {
                if (dgvDistrito.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            //centrar el texto
            foreach (DataGridViewColumn col in dgvDistrito.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvDistrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //capturando el indice seleccionado
            indice = e.RowIndex;
            //verificamos que se haya seleccinado un valor
            if (indice >= 0)
            {
                //desbloqueamos
                Desbloquear();
                btnRegistrar.Enabled = false;
                DataGridViewRow filaseleccinada = dgvDistrito.Rows[indice];
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

        private void btnActualizar_Click_1(object sender, EventArgs e)
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
            res = bal.ActualizarDistrito(obj);
            if (res == true)
            {
                MessageBox.Show("Se actualizo la Distrito");
                CargarDistrito();
                //limpiamos los controles
                Limpiar();
                //Bloqueamos
                Bloquear();
                //Desbloqueamos el boton nuevo
                btnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se puede actualizar la Distrito");
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //capturando valores
            cod = Convert.ToInt32(txtCod.Text);
            //enviamos los datos al objeto
            obj.codigo = cod;
            //declaramos una variable para el cuadro de dialogo
            DialogResult resultado = MessageBox.Show("¿Quieres eliminar la Distrito?", "Eliminando Distrito", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //ejecutamos la funcion
                res = bal.EliminarDistrito(obj);
                if (res == true)
                {
                    MessageBox.Show("Se elimino la Distrito");
                    CargarDistrito();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede elmiminar la Distrito");
                    Limpiar();
                }
            }

        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            //capturando valores
            cod = Convert.ToInt32(txtCod.Text);
            //enviamos los datos al objeto
            obj.codigo = cod;
            //declaramos una variable para el cuadro de dialogo
            DialogResult resultado = MessageBox.Show("¿Quieres habilitar la Distrito?", "Habilitando Distrito", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //ejecutamos la funcion
                res = bal.HabilitarDistrito(obj);
                if (res == true)
                {
                    MessageBox.Show("Se habilito la Distrito");
                    CargarDistrito();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede habilitar la Distrito");
                    Limpiar();
                }
            }
        }

        private void dgvDistrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                res = bal.RegistrarDistrito(obj);
                if (res == true)
                {
                    MessageBox.Show("Se registro la Distrito");
                    CargarDistrito();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede registrar la Distrito");
                    Limpiar();
                }

            }
        }
    }
}
