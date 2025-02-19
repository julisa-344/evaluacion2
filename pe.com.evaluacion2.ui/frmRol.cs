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
    public partial class frmRol : Form
    {
        //crear un objeto de la RolBAL
        private RolBAL bal = new RolBAL();
        //crear un objeto de RolBO
        private RolBO obj = new RolBO();
        //declarando variables
        private int cod = 0, indice = -1;
        private string nom;
        private bool est = false, res = false;

        public frmRol()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //bloqueamos los controles
            Bloquear();
            //cargamos el DataGridView
            CargarRol();
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
            txtCod.Text = bal.MostrarCodigoRol().ToString();
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
        public void CargarRol()
        {
            List<RolBO> rols = bal.MostrarRolTodo();
            //asignamos la lista al datagridview
            dgvRol.DataSource = rols;
            //MessageBox.Show(rols.Count() + "");
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
                res = bal.RegistrarRol(obj);
                if (res == true)
                {
                    MessageBox.Show("Se registro la Rol");
                    CargarRol();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede registrar la Rol");
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
            dgvRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //ajustar el ancho para llenar el Datagridview
            dgvRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //evitar que se autogenera las columnas
            dgvRol.AutoGenerateColumns = false;

            //limpiar columnas existentes
            dgvRol.Columns.Clear();

            //eliminamos la seleccion al iniciar
            dgvRol.ClearSelection();

            //hacemos de solo lectura el datagridview
            dgvRol.ReadOnly = true;

            //definimos las columnas de forma manual
            dgvRol.Columns.Add("codigo", "Codigo");
            //agrego a la columna la propiedad que viene de la clase
            dgvRol.Columns["codigo"].DataPropertyName = "codigo";

            //definimos las columnas de forma manual
            dgvRol.Columns.Add("nombre", "Nombre");
            //agrego a la columna la propiedad que viene de la clase
            dgvRol.Columns["nombre"].DataPropertyName = "nombre";

            //creamos una columna personalizada
            DataGridViewTextBoxColumn colestado = new DataGridViewTextBoxColumn
            {
                Name = "estado",
                HeaderText = "Estado",
                DataPropertyName = "estado"
            };

            //agregamos la columna
            dgvRol.Columns.Add(colestado);
            //formato para la visualizacion de la columna estado
            dgvRol.CellFormatting += (s, e) =>
            {
                if (dgvRol.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            //centrar el texto
            foreach (DataGridViewColumn col in dgvRol.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //capturando el indice seleccionado
            indice = e.RowIndex;
            //verificamos que se haya seleccinado un valor
            if (indice >= 0)
            {
                //desbloqueamos
                Desbloquear();
                btnRegistrar.Enabled = false;
                DataGridViewRow filaseleccinada = dgvRol.Rows[indice];
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
            res = bal.ActualizarRol(obj);
            if (res == true)
            {
                MessageBox.Show("Se actualizo la Rol");
                CargarRol();
                //limpiamos los controles
                Limpiar();
                //Bloqueamos
                Bloquear();
                //Desbloqueamos el boton nuevo
                btnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se puede actualizar la Rol");
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
            DialogResult resultado = MessageBox.Show("¿Quieres eliminar la Rol?", "Eliminando Rol", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //ejecutamos la funcion
                res = bal.EliminarRol(obj);
                if (res == true)
                {
                    MessageBox.Show("Se elimino la Rol");
                    CargarRol();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede elmiminar la Rol");
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
            DialogResult resultado = MessageBox.Show("¿Quieres habilitar la Rol?", "Habilitando Rol", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //ejecutamos la funcion
                res = bal.HabilitarRol(obj);
                if (res == true)
                {
                    MessageBox.Show("Se habilito la Rol");
                    CargarRol();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede habilitar la Rol");
                    Limpiar();
                }
            }
        }

        private void dgvRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                res = bal.RegistrarRol(obj);
                if (res == true)
                {
                    MessageBox.Show("Se registro la Rol");
                    CargarRol();
                    //limpiamos los controles
                    Limpiar();
                    //Bloqueamos
                    Bloquear();
                    //Desbloqueamos el boton nuevo
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede registrar la Rol");
                    Limpiar();
                }

            }
        }
    }
}