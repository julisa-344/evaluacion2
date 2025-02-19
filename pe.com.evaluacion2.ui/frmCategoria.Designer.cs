namespace pe.com.evaluacion2.ui
{
    partial class frmCategoria
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCod = new TextBox();
            txtNom = new TextBox();
            chkEst = new CheckBox();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnHabilitar = new Button();
            dgvCategoria = new DataGridView();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 26);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 86);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 166);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 128);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(117, 81);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(137, 23);
            txtCod.TabIndex = 4;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(117, 125);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(211, 23);
            txtNom.TabIndex = 5;
            // 
            // chkEst
            // 
            chkEst.AutoSize = true;
            chkEst.Location = new Point(117, 166);
            chkEst.Name = "chkEst";
            chkEst.Size = new Size(71, 19);
            chkEst.TabIndex = 6;
            chkEst.Text = "Habilitar";
            chkEst.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ActiveCaptionText;
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(57, 212);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.MenuHighlight;
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(147, 212);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 192, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(238, 212);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(319, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = Color.Yellow;
            btnHabilitar.Location = new Point(400, 212);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 11;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click_1;
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(48, 256);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(427, 272);
            dgvCategoria.TabIndex = 12;
            dgvCategoria.CellClick += dgvCategoria_CellClick;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 699);
            Controls.Add(dgvCategoria);
            Controls.Add(btnHabilitar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(chkEst);
            Controls.Add(txtNom);
            Controls.Add(txtCod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCod;
        private TextBox txtNom;
        private CheckBox chkEst;
        private Button btnNuevo;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnHabilitar;
        private DataGridView dgvCategoria;
        private BindingSource bindingSource1;
    }
}