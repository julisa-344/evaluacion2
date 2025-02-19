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
    public partial class frmTipoDocumento : Form
    {
        //crear un objeto de la TipoDocumentoBAL
        private TipoDocumentoBAL bal = new TipoDocumentoBAL();
        //crear un objeto de TipoDocumentoBO
        private TipoDocumentoBO obj = new TipoDocumentoBO();
        //declarando variables
        private int cod = 0, indice = -1;
        private string nom;
        private bool est = false, res = false;

        public frmTipoDocumento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //bloqueamos los controles
            Bloquear();
            //cargamos el DataGridView
            CargarTipoDocumento();
            //hacemos de solo lectura
            SoloLectura();
            //llamamos al personalizar DatagridView
            PersonalizarDataGridView();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            //llamamos al procedimiento pára desbloquear
            Desbloquear();
            //bloqueamos el boton nuevo
            btnNuevo.Enabled = false;
            //limpiamos
            Limpiar();
            txtCod.Text = bal.MostrarCodigoTipoDocumento().ToString();
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
        public void CargarTipoDocumento()
        {
            List<TipoDocumentoBO> tipoDocumentos = bal.MostrarTipoDocumentoTodo();
            //asignamos la lista al datagridview
            dgvTipoDocumento.DataSource = tipoDocumentos;
            //MessageBox.Show(TipoDocumentos.Count() + "");
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
                res = bal.RegistrarTipoDocumento(obj);
                if (res == true)
                {
                    MessageBox.Show("Se registro la TipoDocumento");
                    CargarTipoDocumento();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede registrar la TipoDocumento");
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
            //ajustar el tamaño de ls columnas
            dgvTipoDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //ajustar el ancho para llenar el Datagridview
            dgvTipoDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //evitar que se autogenera las columnas
            dgvTipoDocumento.AutoGenerateColumns = false;

            //limpiar columnas existentes
            dgvTipoDocumento.Columns.Clear();

            //eliminamos la seleccion al iniciar
            dgvTipoDocumento.ClearSelection();

            //hacemos de solo lectura el datagridview
            dgvTipoDocumento.ReadOnly = true;

            //definimos las columnas de forma manual
            dgvTipoDocumento.Columns.Add("codigo", "Codigo");
            //agrego a la columna la propiedad que viene de la clase
            dgvTipoDocumento.Columns["codigo"].DataPropertyName = "codigo";

            //definimos las columnas de forma manual
            dgvTipoDocumento.Columns.Add("nombre", "Nombre");
            //agrego a la columna la propiedad que viene de la clase
            dgvTipoDocumento.Columns["nombre"].DataPropertyName = "nombre";

            //creamos una columna personalizada
            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };

            //agregamos la columna
            dgvTipoDocumento.Columns.Add(colestado);
            //formato para la visualizacion de la columna estado
            dgvTipoDocumento.CellFormatting += (s, e) =>
            {
                if (dgvTipoDocumento.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            //centrar el texto
            foreach (DataGridViewColumn col in dgvTipoDocumento.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvTipoDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //capturando el indice seleccionado
            indice = e.RowIndex;
            //verificamos que se haya seleccinado un valor
            if (indice >= 0)
            {
                //desbloqueamos
                Desbloquear();
                btnRegistrar.Enabled = false;
                DataGridViewRow filaseleccinada = dgvTipoDocumento.Rows[indice];
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
            res = bal.ActualizarTipoDocumento(obj);
            if (res == true)
            {
                MessageBox.Show("Se actualizo la TipoDocumento");
                CargarTipoDocumento();
                //limpiamos los controles
                Limpiar();
                //Bloqueamos
                Bloquear();
                //Desbloqueamos el boton nuevo
                btnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se puede actualizar la TipoDocumento");
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
            DialogResult resultado = MessageBox.Show("¿Quieres eliminar la TipoDocumento?", "Eliminando TipoDocumento", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //ejecutamos la funcion
                res = bal.EliminarTipoDocumento(obj);
                if (res == true)
                {
                    MessageBox.Show("Se elimino la TipoDocumento");
                    CargarTipoDocumento();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede elmiminar la TipoDocumento");
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
            DialogResult resultado = MessageBox.Show("¿Quieres habilitar la TipoDocumento?", "Habilitando TipoDocumento", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //ejecutamos la funcion
                res = bal.HabilitarTipoDocumento(obj);
                if (res == true)
                {
                    MessageBox.Show("Se habilito la TipoDocumento");
                    CargarTipoDocumento();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede habilitar la TipoDocumento");
                    Limpiar();
                }
            }
        }

        private void dgvTipoDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                res = bal.RegistrarTipoDocumento(obj);
                if (res == true)
                {
                    MessageBox.Show("Se registro la TipoDocumento");
                    CargarTipoDocumento();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede registrar la TipoDocumento");
                    Limpiar();
                }

            }
        }
    }
}
