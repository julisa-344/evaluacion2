namespace pe.com.evaluacion2.ui
{
    partial class frmEmpleado
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtCod = new TextBox();
            txtNom = new TextBox();
            txtApeP = new TextBox();
            txtDir = new TextBox();
            chkEst = new CheckBox();
            dgvEmpleado = new DataGridView();
            label10 = new Label();
            txtApeM = new TextBox();
            txtTel = new TextBox();
            label11 = new Label();
            txtCel = new TextBox();
            label12 = new Label();
            txtCor = new TextBox();
            label13 = new Label();
            txtUsu = new TextBox();
            label14 = new Label();
            txtCla = new TextBox();
            label15 = new Label();
            label7 = new Label();
            label16 = new Label();
            label17 = new Label();
            btnHabilitar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            btnNuevo = new Button();
            cmbDis = new ComboBox();
            cmbRol = new ComboBox();
            cmbTipDoc = new ComboBox();
            txtDoc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 25);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de Empleado";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 72);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 106);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 146);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido Pat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 205);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Documento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 234);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 5;
            label6.Text = "Direccion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(388, 185);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 7;
            label8.Text = "Estado";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(173, 64);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(100, 23);
            txtCod.TabIndex = 8;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(173, 106);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 9;
            // 
            // txtApeP
            // 
            txtApeP.Location = new Point(173, 143);
            txtApeP.Name = "txtApeP";
            txtApeP.Size = new Size(100, 23);
            txtApeP.TabIndex = 10;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(173, 234);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(100, 23);
            txtDir.TabIndex = 12;
            // 
            // chkEst
            // 
            chkEst.AutoSize = true;
            chkEst.Location = new Point(507, 185);
            chkEst.Name = "chkEst";
            chkEst.Size = new Size(71, 19);
            chkEst.TabIndex = 14;
            chkEst.Text = "Habilitar";
            chkEst.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Location = new Point(51, 367);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.Size = new Size(559, 310);
            dgvEmpleado.TabIndex = 19;
            dgvEmpleado.CellClick += dgvEmpleado_CellClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 175);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 22;
            label10.Text = "Apellido Mat";
            // 
            // txtApeM
            // 
            txtApeM.Location = new Point(172, 173);
            txtApeM.Name = "txtApeM";
            txtApeM.Size = new Size(100, 23);
            txtApeM.TabIndex = 23;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(171, 263);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 263);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 25;
            label11.Text = "Telefono";
            // 
            // txtCel
            // 
            txtCel.Location = new Point(507, 69);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(100, 23);
            txtCel.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(387, 69);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 27;
            label12.Text = "Celular";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(507, 98);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(100, 23);
            txtCor.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(387, 98);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 29;
            label13.Text = "Correo";
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(508, 127);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(100, 23);
            txtUsu.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(388, 127);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 31;
            label14.Text = "Usuario";
            // 
            // txtCla
            // 
            txtCla.Location = new Point(507, 156);
            txtCla.Name = "txtCla";
            txtCla.Size = new Size(100, 23);
            txtCla.TabIndex = 34;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(387, 156);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 33;
            label15.Text = "Clave";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(390, 268);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 39;
            label7.Text = "Cod Tip Doc";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(389, 239);
            label16.Name = "label16";
            label16.Size = new Size(49, 15);
            label16.TabIndex = 37;
            label16.Text = "Cod Rol";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(389, 210);
            label17.Name = "label17";
            label17.Size = new Size(70, 15);
            label17.TabIndex = 35;
            label17.Text = "Cod Distrito";
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = Color.Yellow;
            btnHabilitar.Location = new Point(478, 312);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 45;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(397, 312);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 44;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 192, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(316, 312);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 43;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.MenuHighlight;
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(225, 312);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 42;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ActiveCaptionText;
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(135, 312);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 41;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // cmbDis
            // 
            cmbDis.FormattingEnabled = true;
            cmbDis.Location = new Point(507, 210);
            cmbDis.Name = "cmbDis";
            cmbDis.Size = new Size(121, 23);
            cmbDis.TabIndex = 46;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(508, 239);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 47;
            // 
            // cmbTipDoc
            // 
            cmbTipDoc.FormattingEnabled = true;
            cmbTipDoc.Location = new Point(508, 268);
            cmbTipDoc.Name = "cmbTipDoc";
            cmbTipDoc.Size = new Size(121, 23);
            cmbTipDoc.TabIndex = 48;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(171, 205);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(100, 23);
            txtDoc.TabIndex = 49;
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 724);
            Controls.Add(txtDoc);
            Controls.Add(cmbTipDoc);
            Controls.Add(cmbRol);
            Controls.Add(cmbDis);
            Controls.Add(btnHabilitar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(label7);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(txtCla);
            Controls.Add(label15);
            Controls.Add(txtUsu);
            Controls.Add(label14);
            Controls.Add(txtCor);
            Controls.Add(label13);
            Controls.Add(txtCel);
            Controls.Add(label12);
            Controls.Add(txtTel);
            Controls.Add(label11);
            Controls.Add(txtApeM);
            Controls.Add(label10);
            Controls.Add(dgvEmpleado);
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
            Name = "frmEmpleado";
            Text = "frmEmpleado";
            Load += frmEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtCod;
        private TextBox txtNom;
        private TextBox txtApeP;
        private TextBox txtApel;
        private TextBox txtDir;
        private ComboBox cboCargo;
        private CheckBox chkEst;
        private DataGridView dgvEmpleado;
        private Label label10;
        private TextBox txtApeM;
        private TextBox textBox1;
        private TextBox txtTel;
        private Label label11;
        private TextBox txtCel;
        private Label label12;
        private TextBox txtCor;
        private Label label13;
        private TextBox txtUsu;
        private Label label14;
        private TextBox txtCla;
        private Label label15;
        private Label label7;
        private Label label16;
        private Label label17;
        private Button btnHabilitar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private Button btnNuevo;
        private ComboBox cmbDis;
        private ComboBox cmbRol;
        private ComboBox cmbTipDoc;
        private TextBox txtDoc;
    }
}
