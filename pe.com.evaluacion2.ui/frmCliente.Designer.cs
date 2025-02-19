namespace pe.com.evaluacion2.ui
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHabilitar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            btnNuevo = new Button();
            label7 = new Label();
            label17 = new Label();
            txtCor = new TextBox();
            label13 = new Label();
            txtCel = new TextBox();
            label12 = new Label();
            txtTel = new TextBox();
            label11 = new Label();
            cmbDoc = new ComboBox();
            txtApeM = new TextBox();
            label10 = new Label();
            dgvCliente = new DataGridView();
            chkEst = new CheckBox();
            txtDir = new TextBox();
            txtApeP = new TextBox();
            txtNom = new TextBox();
            txtCod = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbCodDis = new ComboBox();
            cmbTipDoc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = Color.Yellow;
            btnHabilitar.Location = new Point(548, 431);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 82;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(467, 431);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 81;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 192, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(386, 431);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 80;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.MenuHighlight;
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(295, 431);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 79;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ActiveCaptionText;
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(205, 431);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 78;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 308);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 76;
            label7.Text = "Cod Tip Doc";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(459, 276);
            label17.Name = "label17";
            label17.Size = new Size(70, 15);
            label17.TabIndex = 72;
            label17.Text = "Cod Distrito";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(577, 217);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(100, 23);
            txtCor.TabIndex = 67;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(457, 217);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 66;
            label13.Text = "Correo";
            // 
            // txtCel
            // 
            txtCel.Location = new Point(577, 188);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(100, 23);
            txtCel.TabIndex = 65;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(457, 188);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 64;
            label12.Text = "Celular";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(241, 382);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(121, 382);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 62;
            label11.Text = "Telefono";
            // 
            // cmbDoc
            // 
            cmbDoc.FormattingEnabled = true;
            cmbDoc.Location = new Point(241, 324);
            cmbDoc.Name = "cmbDoc";
            cmbDoc.Size = new Size(121, 23);
            cmbDoc.TabIndex = 61;
            // 
            // txtApeM
            // 
            txtApeM.Location = new Point(242, 292);
            txtApeM.Name = "txtApeM";
            txtApeM.Size = new Size(100, 23);
            txtApeM.TabIndex = 60;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(123, 294);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 59;
            label10.Text = "Apellido Mat";
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(12, 486);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.Size = new Size(1031, 310);
            dgvCliente.TabIndex = 58;
            dgvCliente.CellClick += dgvCliente_CellClick;
            // 
            // chkEst
            // 
            chkEst.AutoSize = true;
            chkEst.Location = new Point(577, 251);
            chkEst.Name = "chkEst";
            chkEst.Size = new Size(71, 19);
            chkEst.TabIndex = 57;
            chkEst.Text = "Habilitar";
            chkEst.UseVisualStyleBackColor = true;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(243, 353);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(100, 23);
            txtDir.TabIndex = 56;
            // 
            // txtApeP
            // 
            txtApeP.Location = new Point(243, 262);
            txtApeP.Name = "txtApeP";
            txtApeP.Size = new Size(100, 23);
            txtApeP.TabIndex = 55;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(243, 225);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 54;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(243, 183);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(100, 23);
            txtCod.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(458, 251);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 52;
            label8.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 353);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 51;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 324);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 50;
            label5.Text = "Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 265);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 49;
            label4.Text = "Apellido Pat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 225);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 48;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 191);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 47;
            label2.Text = "Codigo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 128);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 46;
            label1.Text = "Mantenimiento de Cliente";
            // 
            // cmbCodDis
            // 
            cmbCodDis.FormattingEnabled = true;
            cmbCodDis.Location = new Point(577, 276);
            cmbCodDis.Name = "cmbCodDis";
            cmbCodDis.Size = new Size(121, 23);
            cmbCodDis.TabIndex = 83;
            // 
            // cmbTipDoc
            // 
            cmbTipDoc.FormattingEnabled = true;
            cmbTipDoc.Location = new Point(577, 305);
            cmbTipDoc.Name = "cmbTipDoc";
            cmbTipDoc.Size = new Size(121, 23);
            cmbTipDoc.TabIndex = 84;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 924);
            Controls.Add(cmbTipDoc);
            Controls.Add(cmbCodDis);
            Controls.Add(btnHabilitar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(label7);
            Controls.Add(label17);
            Controls.Add(txtCor);
            Controls.Add(label13);
            Controls.Add(txtCel);
            Controls.Add(label12);
            Controls.Add(txtTel);
            Controls.Add(label11);
            Controls.Add(cmbDoc);
            Controls.Add(txtApeM);
            Controls.Add(label10);
            Controls.Add(dgvCliente);
            Controls.Add(chkEst);
            Controls.Add(txtDir);
            Controls.Add(txtApeP);
            Controls.Add(txtNom);
            Controls.Add(txtCod);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCliente";
            Text = "frmCliente";
            Load += frmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHabilitar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private Button btnNuevo;
        private Label label7;
        private Label label17;
        private TextBox txtCor;
        private Label label13;
        private TextBox txtCel;
        private Label label12;
        private TextBox txtTel;
        private Label label11;
        private ComboBox cmbDoc;
        private TextBox txtApeM;
        private Label label10;
        private DataGridView dgvCliente;
        private CheckBox chkEst;
        private TextBox txtDir;
        private TextBox txtApeP;
        private TextBox txtNom;
        private TextBox txtCod;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbCodDis;
        private ComboBox cmbTipDoc;
    }
}