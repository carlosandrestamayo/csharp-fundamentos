namespace InventarioProductosAppWF.views
{
    partial class FormMain
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
            panel1 = new Panel();
            label4 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnListar = new Button();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            listBoxProductos = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCodigo);
            panel1.Location = new Point(81, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 243);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 192);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(137, 189);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(166, 23);
            txtPrecio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 139);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(137, 136);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(166, 23);
            txtCantidad.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 91);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 38);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(137, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(166, 23);
            txtCodigo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(60, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 493);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnListar);
            panel3.Controls.Add(btnLimpiar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAgregar);
            panel3.Location = new Point(48, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 84);
            panel3.TabIndex = 5;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(339, 28);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(229, 28);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(124, 28);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(16, 28);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // listBoxProductos
            // 
            listBoxProductos.FormattingEnabled = true;
            listBoxProductos.Location = new Point(705, 50);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(405, 484);
            listBoxProductos.TabIndex = 2;
            listBoxProductos.SelectedIndexChanged += listBoxProductos_SelectedIndexChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 634);
            Controls.Add(listBoxProductos);
            Controls.Add(panel2);
            Name = "FormMain";
            Text = "FormMain";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtCantidad;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtCodigo;
        private Panel panel2;
        private Button btnLimpiar;
        private Button btnEditar;
        private Button btnAgregar;
        private Panel panel3;
        private Button btnListar;
        private ListBox listBoxProductos;
    }
}