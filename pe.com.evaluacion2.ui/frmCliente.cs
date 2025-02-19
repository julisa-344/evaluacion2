using pe.com.evaluacion2.bal;
using pe.com.evaluacion2.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace pe.com.evaluacion2.ui
{
    public partial class frmCliente : Form
    {
        // Create objects for BAL and BO
        private ClienteBAL bal = new ClienteBAL();
        private ClienteBO obj = new ClienteBO();
        private DistritoBAL distritoBAL = new DistritoBAL(); // Instancia de DistritoBAL
        private TipoDocumentoBAL tipoDocumentoBAL = new TipoDocumentoBAL(); // Instancia de TipoDocumentoBAL

        private int cod = 0, indice = -1;
        private string nom, apeP, apeM, dir, tel, cel, cor;
        private bool est = false, res = false;

        public frmCliente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Bloquear();
            CargarCliente();
            SoloLectura();
            PersonalizarDataGridView();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Desbloquear();
            btnNuevo.Enabled = false;
            Limpiar();
            txtCod.Text = bal.MostrarCodigoCliente().ToString();
        }

        public void Bloquear()
        {
            txtCod.Enabled = false;
            txtNom.Enabled = false;
            txtApeP.Enabled = false;
            txtApeM.Enabled = false;
            cmbTipDoc.Enabled = false;
            txtDir.Enabled = false;
            txtTel.Enabled = false;
            txtCel.Enabled = false;
            txtCor.Enabled = false;
            cmbCodDis.Enabled = false;
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
            cmbTipDoc.Enabled = true;
            txtDir.Enabled = true;
            txtTel.Enabled = true;
            txtCel.Enabled = true;
            txtCor.Enabled = true;
            cmbCodDis.Enabled = true;
            chkEst.Enabled = true;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnHabilitar.Enabled = true;
        }

        public void CargarCliente()
        {
            List<ClienteBO> clientes = bal.MostrarClienteTodo();
            dgvCliente.DataSource = clientes;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
            dir = txtDir.Text;
            tel = txtTel.Text;
            cel = txtCel.Text;
            cor = txtCor.Text;
            est = chkEst.Checked;

            // Sending data to the object
            obj.nombre = nom;
            obj.apellidoPaterno = apeP;
            obj.apellidoMaterno = apeM;
            obj.direccion = dir;
            obj.telefono = tel;
            obj.celular = cel;
            obj.correoElectronico = cor;
            obj.estado = est;
            obj.distrito = new DistritoBO { codigo = Convert.ToInt32(cmbCodDis.SelectedValue) }; // Asignar el código del distrito
            obj.TipoDocumento = new TipoDocumentoBO { codigo = Convert.ToInt32(cmbTipDoc.SelectedValue) }; // Asignar el código del tipo de documento

            // Execute the function
            res = bal.RegistrarCliente(obj);
            if (res)
            {
                MessageBox.Show("Se registró el Cliente");
                CargarCliente();
                Limpiar();
                Bloquear();
                btnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se puede registrar el Cliente");
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtCod.Clear();
            txtNom.Clear();
            txtApeP.Clear();
            txtApeM.Clear();
            txtDir.Clear();
            txtTel.Clear();
            txtCel.Clear();
            txtCor.Clear();
            chkEst.Checked = false;
            txtNom.Focus();
        }

        private void SoloLectura()
        {
            txtCod.ReadOnly = true;
        }

        private void PersonalizarDataGridView()
        {
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCliente.AutoGenerateColumns = false;

            dgvCliente.Columns.Clear();
            dgvCliente.Columns.Add("codigo", "Codigo");
            dgvCliente.Columns["codigo"].DataPropertyName = "codigo";
            dgvCliente.Columns.Add("nombre", "Nombre");
            dgvCliente.Columns["nombre"].DataPropertyName = "nombre";
            dgvCliente.Columns.Add("apellidoPaterno", "Apellido Paterno");
            dgvCliente.Columns["apellidoPaterno"].DataPropertyName = "apellidoPaterno";
            dgvCliente.Columns.Add("apellidoMaterno", "Apellido Materno");
            dgvCliente.Columns["apellidoMaterno"].DataPropertyName = "apellidoMaterno";
            dgvCliente.Columns.Add("documento", "Documento");
            dgvCliente.Columns["documento"].DataPropertyName = "documento";
            dgvCliente.Columns.Add("direccion", "Direccion");
            dgvCliente.Columns["direccion"].DataPropertyName = "direccion";
            dgvCliente.Columns.Add("telefono", "Telefono");
            dgvCliente.Columns["telefono"].DataPropertyName = "telefono";
            dgvCliente.Columns.Add("celular", "Celular");
            dgvCliente.Columns["celular"].DataPropertyName = "celular";
            dgvCliente.Columns.Add("correo", "Correo");
            dgvCliente.Columns["correo"].DataPropertyName = "correoElectronico"; // Asegúrate de que coincida con la propiedad
            dgvCliente.Columns.Add("estado", "Estado");
            dgvCliente.Columns["estado"].DataPropertyName = "estado";
            dgvCliente.Columns.Add("codigoDis", "Codigo Dis");
            dgvCliente.Columns["codigoDis"].DataPropertyName = "distrito.codigo"; // Asegúrate de que coincida con la propiedad
            dgvCliente.Columns.Add("nombreDis", "Nombre Dis");
            dgvCliente.Columns["nombreDis"].DataPropertyName = "distrito.nombre"; // Asegúrate de que coincida con la propiedad

            // Asegúrate de agregar la columna para el tipo de documento
            dgvCliente.Columns.Add("codigoTipDoc", "Codigo Tipo Documento");
            dgvCliente.Columns["codigoTipDoc"].DataPropertyName = "TipoDocumento.codigo"; // Asegúrate de que coincida con la propiedad

            dgvCliente.CellFormatting += (s, e) =>
            {
                if (dgvCliente.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            foreach (DataGridViewColumn col in dgvCliente.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice >= 0)
            {
                Desbloquear();
                btnRegistrar.Enabled = false;
                DataGridViewRow filaSeleccionada = dgvCliente.Rows[indice];

                txtCod.Text = filaSeleccionada.Cells["codigo"].Value.ToString();
                txtNom.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtApeP.Text = filaSeleccionada.Cells["apellidoPaterno"].Value.ToString();
                txtApeM.Text = filaSeleccionada.Cells["apellidoMaterno"].Value.ToString();
                txtDir.Text = filaSeleccionada.Cells["direccion"].Value.ToString();
                txtTel.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                txtCel.Text = filaSeleccionada.Cells["celular"].Value.ToString();
                txtCor.Text = filaSeleccionada.Cells["correo"].Value.ToString();
                chkEst.Checked = Convert.ToBoolean(filaSeleccionada.Cells["estado"].Value);

                // Asignar el distrito
                var codigoDis = filaSeleccionada.Cells["codigoDis"].Value;
                if (codigoDis != null)
                {
                    cmbCodDis.SelectedValue = codigoDis;
                }

                // Asignar el tipo de documento
                var codigoTipDoc = filaSeleccionada.Cells["codigoTipDoc"].Value; // Asegúrate de que esta columna exista
                if (codigoTipDoc != null)
                {
                    cmbTipDoc.SelectedValue = codigoTipDoc;
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cod = Convert.ToInt32(txtCod.Text);
            nom = txtNom.Text;
            apeP = txtApeP.Text;
            apeM = txtApeM.Text;
            dir = txtDir.Text;
            tel = txtTel.Text;
            cel = txtCel.Text;
            cor = txtCor.Text;
            est = chkEst.Checked;

            obj.codigo = cod;
            obj.nombre = nom;
            obj.apellidoPaterno = apeP;
            obj.apellidoMaterno = apeM;
            obj.direccion = dir;
            obj.telefono = tel;
            obj.celular = cel;
            obj.correoElectronico = cor;
            obj.estado = est;
            obj.distrito = new DistritoBO { codigo = Convert.ToInt32(cmbCodDis.SelectedValue) }; // Asignar el código del distrito
            obj.TipoDocumento = new TipoDocumentoBO { codigo = Convert.ToInt32(cmbTipDoc.SelectedValue) }; // Asignar el código del tipo de documento

            res = bal.ActualizarCliente(obj);
            if (res)
            {
                MessageBox.Show("Se actualizó el Cliente");
                CargarCliente();
                Limpiar();
                Bloquear();
                btnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se puede actualizar el Cliente");
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cod = Convert.ToInt32(txtCod.Text);
            obj.codigo = cod;
            DialogResult resultado = MessageBox.Show("¿Quieres eliminar el Cliente?", "Eliminando Cliente", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                res = bal.EliminarCliente(obj);
                if (res)
                {
                    MessageBox.Show("Se eliminó el Cliente");
                    CargarCliente();
                    Limpiar();
                    Bloquear();
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el Cliente");
                    Limpiar();
                }
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            cod = Convert.ToInt32(txtCod.Text);
            obj.codigo = cod;
            DialogResult resultado = MessageBox.Show("¿Quieres habilitar el Cliente?", "Habilitando Cliente", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                res = bal.HabilitarCliente(obj);
                if (res)
                {
                    MessageBox.Show("Se habilitó el Cliente");
                    CargarCliente();
                    Limpiar();
                    Bloquear();
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede habilitar el Cliente");
                    Limpiar();
                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar los datos necesarios para los combos de distrito y tipo de documento
            CargarDistritos();
            CargarTiposDocumento();
        }

        private void CargarDistritos()
        {
            // Método para cargar los distritos en cmbCodDis
            var distritos = bal.MostrarDistrito(); // Asegúrate de que este método esté implementado
            cmbCodDis.DataSource = distritos;
            cmbCodDis.DisplayMember = "nombre"; // Asegúrate de que el nombre de la propiedad sea correcto
            cmbCodDis.ValueMember = "codigo"; // Asegúrate de que el nombre de la propiedad sea correcto
        }

        private void CargarTiposDocumento()
        {
            // Método para cargar los tipos de documento en cmbTipDoc
            var tiposDocumento = bal.MostrarTipoDocumento(); // Asegúrate de que este método esté implementado
            cmbTipDoc.DataSource = tiposDocumento;
            cmbTipDoc.DisplayMember = "nombre"; // Asegúrate de que el nombre de la propiedad sea correcto
            cmbTipDoc.ValueMember = "codigo"; // Asegúrate de que el nombre de la propiedad sea correcto
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}