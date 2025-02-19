namespace pe.com.evaluacion2.ui
{
    partial class frmRol
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
            dgvRol = new DataGridView();
            btnHabilitar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            btnNuevo = new Button();
            chkEst = new CheckBox();
            txtNom = new TextBox();
            txtCod = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRol).BeginInit();
            SuspendLayout();
            // 
            // dgvRol
            // 
            dgvRol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRol.Location = new Point(90, 331);
            dgvRol.Name = "dgvRol";
            dgvRol.Size = new Size(427, 272);
            dgvRol.TabIndex = 25;
            dgvRol.CellClick += dgvRol_CellClick;

            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = Color.Yellow;
            btnHabilitar.Location = new Point(442, 287);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 24;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(361, 287);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 192, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(280, 287);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.MenuHighlight;
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(189, 287);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 21;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_2;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ActiveCaptionText;
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(99, 287);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // chkEst
            // 
            chkEst.AutoSize = true;
            chkEst.Location = new Point(159, 241);
            chkEst.Name = "chkEst";
            chkEst.Size = new Size(71, 19);
            chkEst.TabIndex = 19;
            chkEst.Text = "Habilitar";
            chkEst.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(159, 200);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(211, 23);
            txtNom.TabIndex = 18;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(159, 156);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(137, 23);
            txtCod.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 203);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 16;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 241);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 15;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 161);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 14;
            label2.Text = "Codigo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 101);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 13;
            label1.Text = "Mantenimiento de Rol";
            // 
            // frmRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 705);
            Controls.Add(dgvRol);
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
            Name = "frmRol";
            Text = "frmRol";
            ((System.ComponentModel.ISupportInitialize)dgvRol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRol;
        private Button btnHabilitar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private Button btnNuevo;
        private CheckBox chkEst;
        private TextBox txtNom;
        private TextBox txtCod;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}