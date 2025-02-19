namespace pe.com.evaluacion2.ui
{
    partial class frmMenu
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
            btnRol = new Button();
            btnMarca = new Button();
            btnTipoDoc = new Button();
            btnCliente = new Button();
            btnProducto = new Button();
            btnEmpleado = new Button();
            btnDistrito = new Button();
            btnCategoria = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 34);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // btnRol
            // 
            btnRol.Location = new Point(29, 79);
            btnRol.Name = "btnRol";
            btnRol.Size = new Size(75, 23);
            btnRol.TabIndex = 1;
            btnRol.Text = "Rol";
            btnRol.UseVisualStyleBackColor = true;
            btnRol.Click += btnRol_Click;
            // 
            // btnMarca
            // 
            btnMarca.Location = new Point(29, 119);
            btnMarca.Name = "btnMarca";
            btnMarca.Size = new Size(75, 23);
            btnMarca.TabIndex = 2;
            btnMarca.Text = "Marca";
            btnMarca.UseVisualStyleBackColor = true;
            btnMarca.Click += btnMarca_Click;
            // 
            // btnTipoDoc
            // 
            btnTipoDoc.Location = new Point(29, 157);
            btnTipoDoc.Name = "btnTipoDoc";
            btnTipoDoc.Size = new Size(75, 23);
            btnTipoDoc.TabIndex = 3;
            btnTipoDoc.Text = "Tipo Doc";
            btnTipoDoc.UseVisualStyleBackColor = true;
            btnTipoDoc.Click += btnTipoDoc_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(29, 195);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(75, 23);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(137, 195);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(75, 23);
            btnProducto.TabIndex = 8;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(137, 157);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(75, 23);
            btnEmpleado.TabIndex = 7;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnDistrito
            // 
            btnDistrito.Location = new Point(137, 119);
            btnDistrito.Name = "btnDistrito";
            btnDistrito.Size = new Size(75, 23);
            btnDistrito.TabIndex = 6;
            btnDistrito.Text = "Distrito";
            btnDistrito.UseVisualStyleBackColor = true;
            btnDistrito.Click += btnDistrito_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(137, 79);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(75, 23);
            btnCategoria.TabIndex = 5;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 261);
            Controls.Add(btnProducto);
            Controls.Add(btnEmpleado);
            Controls.Add(btnDistrito);
            Controls.Add(btnCategoria);
            Controls.Add(btnCliente);
            Controls.Add(btnTipoDoc);
            Controls.Add(btnMarca);
            Controls.Add(btnRol);
            Controls.Add(label1);
            Name = "frmMenu";
            Text = "frmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRol;
        private Button btnMarca;
        private Button btnTipoDoc;
        private Button btnCliente;
        private Button btnProducto;
        private Button btnEmpleado;
        private Button btnDistrito;
        private Button btnCategoria;
    }
}