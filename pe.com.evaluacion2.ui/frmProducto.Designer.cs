namespace pe.com.evaluacion2.ui
{
    partial class frmProducto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtCod = new TextBox();
            txtNom = new TextBox();
            txtDes = new TextBox();
            txtPre = new TextBox();
            txtCan = new TextBox();
            cboMarca = new ComboBox();
            cboCategoria = new ComboBox();
            chkEst = new CheckBox();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvProducto = new DataGridView();
            btnHabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 20);
            label1.Name = "label1";
            label1.Size = new Size(253, 25);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de producto";
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
            label3.Location = new Point(53, 146);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 106);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 179);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 208);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 240);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 6;
            label7.Text = "Marca";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 272);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 7;
            label8.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 302);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 8;
            label9.Text = "Estado";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(173, 64);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(100, 23);
            txtCod.TabIndex = 9;
            txtCod.TextChanged += txtCod_TextChanged;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(174, 106);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 10;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(173, 143);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(100, 23);
            txtDes.TabIndex = 11;
            // 
            // txtPre
            // 
            txtPre.Location = new Point(173, 176);
            txtPre.Name = "txtPre";
            txtPre.Size = new Size(100, 23);
            txtPre.TabIndex = 12;
            // 
            // txtCan
            // 
            txtCan.Location = new Point(173, 208);
            txtCan.Name = "txtCan";
            txtCan.Size = new Size(100, 23);
            txtCan.TabIndex = 13;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(172, 240);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(121, 23);
            cboMarca.TabIndex = 14;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(172, 275);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 15;
            // 
            // chkEst
            // 
            chkEst.AutoSize = true;
            chkEst.Location = new Point(172, 304);
            chkEst.Name = "chkEst";
            chkEst.Size = new Size(71, 19);
            chkEst.TabIndex = 16;
            chkEst.Text = "Habilitar";
            chkEst.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(444, 68);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(444, 101);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(444, 131);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actalizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(444, 161);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(53, 352);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.Size = new Size(466, 310);
            dgvProducto.TabIndex = 21;
            dgvProducto.CellClick += dgvProducto_CellClick;

            // 
            // btnHabilitar
            // 
            btnHabilitar.Location = new Point(444, 190);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 22;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = true;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 687);
            Controls.Add(btnHabilitar);
            Controls.Add(dgvProducto);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(chkEst);
            Controls.Add(cboCategoria);
            Controls.Add(cboMarca);
            Controls.Add(txtCan);
            Controls.Add(txtPre);
            Controls.Add(txtDes);
            Controls.Add(txtNom);
            Controls.Add(txtCod);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProducto";
            Text = "frmProducto";
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
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
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtCod;
        private TextBox txtNom;
        private TextBox txtDes;
        private TextBox txtPre;
        private TextBox txtCan;
        private ComboBox cboMarca;
        private ComboBox cboCategoria;
        private CheckBox chkEst;
        private Button btnNuevo;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvProducto;
        private Button btnHabilitar;
    }
}