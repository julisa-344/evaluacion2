namespace pe.com.evaluacion2.ui
{
    partial class frmTipoDocumento
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
            txtNom = new TextBox();
            txtCod = new TextBox();
            chkEst = new CheckBox();
            dgvTipoDocumento = new DataGridView();
            btnHabilitar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTipoDocumento).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 22);
            label1.Name = "label1";
            label1.Size = new Size(286, 21);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de Tipo de Documento";
            //label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 81);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            //label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 106);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 132);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // textBox1
            // 
            txtNom.Location = new Point(129, 81);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 4;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(133, 114);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(100, 23);
            txtCod.TabIndex = 5;
            // 
            // chkEst
            // 
            chkEst.AutoSize = true;
            chkEst.Location = new Point(132, 144);
            chkEst.Name = "chkEst";
            chkEst.Size = new Size(69, 19);
            chkEst.TabIndex = 6;
            chkEst.Text = "habilitar";
            chkEst.UseVisualStyleBackColor = true;
            // 
            // dgvTipoDocumento
            // 
            dgvTipoDocumento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoDocumento.Location = new Point(44, 208);
            dgvTipoDocumento.Name = "dgvTipoDocumento";
            dgvTipoDocumento.Size = new Size(438, 206);
            dgvTipoDocumento.TabIndex = 7;
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = Color.Yellow;
            btnHabilitar.Location = new Point(396, 172);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(75, 23);
            btnHabilitar.TabIndex = 16;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = false;
            //btnHabilitar.Click += btnHabilitar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(315, 172);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 192, 0);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(234, 172);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.MenuHighlight;
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(143, 172);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ActiveCaptionText;
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(53, 172);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // frmTipoDocumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 450);
            Controls.Add(btnHabilitar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvTipoDocumento);
            Controls.Add(chkEst);
            Controls.Add(txtCod);
            Controls.Add(txtNom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTipoDocumento";
            Text = "frmTipoDocumento";
            ((System.ComponentModel.ISupportInitialize)dgvTipoDocumento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNom;
        private TextBox txtCod;
        private CheckBox chkEst;
        private DataGridView dgvTipoDocumento;
        private Button btnHabilitar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private Button btnNuevo;
    }
}