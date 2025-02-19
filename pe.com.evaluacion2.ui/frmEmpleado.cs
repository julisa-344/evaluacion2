using pe.com.evaluacion2.bal;
using pe.com.evaluacion2.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace pe.com.evaluacion2.ui
{
    public partial class frmEmpleado : Form
    {
        private EmpleadoBAL bal = new EmpleadoBAL();
        private EmpleadoBO obj = new EmpleadoBO();
        private int cod = 0, indice = -1;
        private string nom, apeP, apeM, doc, dir, tel, cel, cor, usu, cla;
        private bool est = false, res = false;

        public frmEmpleado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Bloquear();
            CargarEmpleado();
            CargarDistritos();
            CargarTiposDocumento();
            CargarRoles();
            SoloLectura();
            PersonalizarDataGridView();
        }
        private void CargarDistritos()
        {
            var distritos = bal.MostrarDistritos();
            cmbDis.DataSource = distritos;
            cmbDis.DisplayMember = "nombre"; // Asegúrate de que el nombre de la propiedad sea correcto
            cmbDis.ValueMember = "codigo"; // Asegúrate de que el nombre de la propiedad sea correcto
        }
        private void CargarTiposDocumento()
        {
            var tiposDocumento = bal.MostrarTiposDocumento();
            cmbTipDoc.DataSource = tiposDocumento;
            cmbTipDoc.DisplayMember = "nombre"; // Asegúrate de que el nombre de la propiedad sea correcto
            cmbTipDoc.ValueMember = "codigo"; // Asegúrate de que el nombre de la propiedad sea correcto
        }

        private void CargarRoles()
        {
            var roles = bal.MostrarRoles();
            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "nombre"; // Asegúrate de que el nombre de la propiedad sea correcto
            cmbRol.ValueMember = "codigo"; // Asegúrate de que el nombre de la propiedad sea correcto
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Desbloquear();
            btnNuevo.Enabled = false;
            Limpiar();
            txtCod.Text = bal.MostrarCodigoEmpleado().ToString();
        }


        public void Bloquear()
        {
            txtCod.Enabled = false;
            txtNom.Enabled = false;
            txtApeP.Enabled = false;
            txtApeM.Enabled = false;
            txtDoc.Enabled = false;
            txtDir.Enabled = false;
            txtTel.Enabled = false;
            txtCel.Enabled = false;
            txtCor.Enabled = false;
            txtUsu.Enabled = false;
            txtCla.Enabled = false;
            cmbTipDoc.Enabled = false;
            cmbRol.Enabled = false;
            cmbDis.Enabled = false;
            chkEst.Enabled = false;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnHabilitar.Enabled = false;
        }

        public void Desbloquear()
        {
            txtNom.Enabled = true;
            txtApeP.Enabled = true;
            txtApeM.Enabled = true;
            txtDoc.Enabled = true;
            txtDir.Enabled = true;
            txtTel.Enabled = true;
            txtCel.Enabled = true;
            txtCor.Enabled = true;
            txtUsu.Enabled = true;
            txtCla.Enabled = true;
            cmbTipDoc.Enabled = true;
            cmbRol.Enabled = true;
            cmbDis.Enabled = true;
            chkEst.Enabled = true;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnHabilitar.Enabled = true;
        }

        public void CargarEmpleado()
        {
            List<EmpleadoBO> empleados = bal.MostrarEmpleadoTodo();
            dgvEmpleado.DataSource = empleados;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            // Validations
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Ingresa el Nombre");
                txtNom.Focus();
                return;
            }

            // Capturing values
            nom = txtNom.Text;
            apeP = txtApeP.Text;
            apeM = txtApeM.Text;
            doc = txtDoc.Text;
            dir = txtDir.Text;
            tel = txtTel.Text;
            cel = txtCel.Text;
            cor = txtCor.Text;
            usu = txtUsu.Text;
            cla = txtCla.Text;
            est = chkEst.Checked;

            // Sending data to the object
            obj.nombre = nom;
            obj.apellidoPaterno = apeP;
            obj.apellidoMaterno = apeM;
            obj.documento = doc;
            obj.direccion = dir;
            obj.telefono = tel;
            obj.celular = cel;
            obj.correoElectronico = cor;
            obj.usuario = usu;
            obj.clave = cla;
            obj.estado = est;
            obj.distrito = new DistritoBO { codigo = (int)cmbDis.SelectedValue }; // Asignar distrito
            obj.tipoDocumento = new TipoDocumentoBO { codigo = (int)cmbTipDoc.SelectedValue }; // Asignar tipo de documento
            obj.rol = new RolBO { codigo = (int)cmbRol.SelectedValue }; // Asignar rol

            // Execute the function
            res = bal.RegistrarEmpleado(obj);
            if (res)
            {
                MessageBox.Show("Se registró el empleado");
                CargarEmpleado();
                Limpiar();
                Bloquear();
                btnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se puede registrar el empleado");
                Limpiar();
            }
        }
        private void Limpiar()
        {
            txtCod.Clear();
            txtNom.Clear();
            txtApeP.Clear();
            txtApeM.Clear();
            txtDoc.Clear();
            txtDir.Clear();
            txtTel.Clear();
            txtCel.Clear();
            txtCor.Clear();
            txtUsu.Clear();
            txtCla.Clear();
            chkEst.Checked = false;
            txtNom.Focus();
        }

        private void SoloLectura()
        {
            txtCod.ReadOnly = true;
        }

        private void PersonalizarDataGridView()
        {
            dgvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleado.AutoGenerateColumns = false;

            dgvEmpleado.Columns.Clear();
            dgvEmpleado.Columns.Add("codigo", "Codigo");
            dgvEmpleado.Columns["codigo"].DataPropertyName = "codigo";
            dgvEmpleado.Columns.Add("nombre", "Nombre");
            dgvEmpleado.Columns["nombre"].DataPropertyName = "nombre";
            dgvEmpleado.Columns.Add("apellidoPaterno", "Apellido Paterno");
            dgvEmpleado.Columns["apellidoPaterno"].DataPropertyName = "apellidoPaterno";
            dgvEmpleado.Columns.Add("apellidoMaterno", "Apellido Materno");
            dgvEmpleado.Columns["apellidoMaterno"].DataPropertyName = "apellidoMaterno";
            dgvEmpleado.Columns.Add("documento", "Documento");
            dgvEmpleado.Columns["documento"].DataPropertyName = "documento";
            dgvEmpleado.Columns.Add("direccion", "Direccion");
            dgvEmpleado.Columns["direccion"].DataPropertyName = "direccion";
            dgvEmpleado.Columns.Add("telefono", "Telefono");
            dgvEmpleado.Columns["telefono"].DataPropertyName = "telefono";
            dgvEmpleado.Columns.Add("celular", "Celular");
            dgvEmpleado.Columns["celular"].DataPropertyName = "celular";
            dgvEmpleado.Columns.Add("correo", "Correo");
            dgvEmpleado.Columns["correo"].DataPropertyName = "correoElectronico"; // Asegúrate de que coincida con la propiedad
            dgvEmpleado.Columns.Add("usurio", "Usurio");
            dgvEmpleado.Columns["usurio"].DataPropertyName = "usurio";
            dgvEmpleado.Columns.Add("clave", "Clave");
            dgvEmpleado.Columns["clave"].DataPropertyName = "clave";
            dgvEmpleado.Columns.Add("estado", "Estado");
            dgvEmpleado.Columns["estado"].DataPropertyName = "estado";
            dgvEmpleado.Columns.Add("codigoDis", "Codigo Dis");
            dgvEmpleado.Columns["codigoDis"].DataPropertyName = "distrito.codigo";
            dgvEmpleado.Columns.Add("codigoRol", "Codigo Rol");
            dgvEmpleado.Columns["codigoRol"].DataPropertyName = "rol.codigo";
            dgvEmpleado.Columns.Add("codigoTipd", "Cod Tipo Doc");
            dgvEmpleado.Columns["codigoTipd"].DataPropertyName = "tipoDocumento.codigoTipd"; // Asegúrate de que coincida con la propiedad

            dgvEmpleado.CellFormatting += (s, e) =>
            {
                if (dgvEmpleado.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            foreach (DataGridViewColumn col in dgvEmpleado.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                Desbloquear();
                btnRegistrar.Enabled = false;
                DataGridViewRow filaSeleccionada = dgvEmpleado.Rows[indice];

                txtCod.Text = filaSeleccionada.Cells["codigo"].Value.ToString();
                txtNom.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtApeP.Text = filaSeleccionada.Cells["apellidoPaterno"].Value.ToString();
                txtApeM.Text = filaSeleccionada.Cells["apellidoMaterno"].Value.ToString();
                txtDoc.Text = filaSeleccionada.Cells["documento"].Value.ToString();
                txtDir.Text = filaSeleccionada.Cells["direccion"].Value.ToString();
                txtTel.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                txtCel.Text = filaSeleccionada.Cells["celular"].Value.ToString();
                txtCor.Text = filaSeleccionada.Cells["correo"].Value.ToString();
                chkEst.Checked = Convert.ToBoolean(filaSeleccionada.Cells["estado"].Value);

                // Asignar el distrito
                var codigoDis = filaSeleccionada.Cells["codigoDis"].Value;
                if (codigoDis != null)
                {
                    cmbDis.SelectedValue = codigoDis;
                }
                else
                {
                    cmbDis.SelectedIndex = -1; // O puedes establecer un valor predeterminado
                }

                // Asignar el tipo de documento
                var codigoTipDoc = filaSeleccionada.Cells["codigoTipd"].Value; // Asegúrate de que esta columna exista
                if (codigoTipDoc != null)
                {
                    cmbTipDoc.SelectedValue = codigoTipDoc;
                }
                else
                {
                    cmbTipDoc.SelectedIndex = -1; // O puedes establecer un valor predeterminado
                }

                // Asignar el rol
                var codigoRol = filaSeleccionada.Cells["codigoRol"].Value; // Asegúrate de que esta columna exista
                if (codigoRol != null)
                {
                    cmbRol.SelectedValue = codigoRol;
                }
                else
                {
                    cmbRol.SelectedIndex = -1; // O puedes establecer un valor predeterminado
                }
            }
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            cod = Convert.ToInt32(txtCod.Text);
            nom = txtNom.Text;
            apeP = txtApeP.Text;
            apeM = txtApeM.Text;
            doc = txtDoc.Text;
            dir = txtDir.Text;
            tel = txtTel.Text;
            cel = txtCel.Text;
            cor = txtCor.Text;
            usu = txtUsu.Text;
            cla = txtCla.Text;
            est = chkEst.Checked;

            obj.codigo = cod;
            obj.nombre = nom;
            obj.apellidoPaterno = apeP;
            obj.apellidoMaterno = apeM;
            obj.documento = doc;
            obj.direccion = dir;
            obj.telefono = tel;
            obj.celular = cel;
            obj.correoElectronico = cor;
            obj.usuario = usu;
            obj.clave = cla;
            obj.estado = est;

            res = bal.ActualizarEmpleado(obj);
            if (res)
            {
                MessageBox.Show("Se actualizó el empleado");
                CargarEmpleado();
                Limpiar();
                Bloquear();
                btnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se puede actualizar el empleado");
                Limpiar();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            cod = Convert.ToInt32(txtCod.Text);
            obj.codigo = cod;
            DialogResult resultado = MessageBox.Show("¿Quieres eliminar el empleado?", "Eliminando Empleado", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                res = bal.EliminarEmpleado(obj);
                if (res)
                {
                    MessageBox.Show("Se eliminó el empleado");
                    CargarEmpleado();
                    Limpiar();
                    Bloquear();
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el empleado");
                    Limpiar();
                }
            }
        }

        private void btnHabilitar_Click_1(object sender, EventArgs e)
        {
            cod = Convert.ToInt32(txtCod.Text);
            obj.codigo = cod;
            DialogResult resultado = MessageBox.Show("¿Quieres habilitar el empleado?", "Habilitando Empleado", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                res = bal.HabilitarEmpleado(obj);
                if (res)
                {
                    MessageBox.Show("Se habilitó el empleado");
                    CargarEmpleado();
                    Limpiar();
                    Bloquear();
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede habilitar el empleado");
                    Limpiar();
                }
            }
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}