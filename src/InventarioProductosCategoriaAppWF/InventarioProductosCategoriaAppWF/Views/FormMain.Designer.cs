namespace InventarioProductosCategoriaAppWF
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
            label5 = new Label();
            cmbCategoria = new ComboBox();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btnCategoria = new Button();
            panel3 = new Panel();
            btnListar = new Button();
            bthLimpiar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            listBoxProductos = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(120, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 271);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 215);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(107, 212);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(206, 23);
            cmbCategoria.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 168);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(206, 23);
            txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 171);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(107, 125);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(206, 23);
            txtCantidad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 128);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Cantidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(206, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 85);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(107, 39);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(206, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(97, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 486);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnCategoria);
            panel4.Location = new Point(463, 360);
            panel4.Name = "panel4";
            panel4.Size = new Size(113, 75);
            panel4.TabIndex = 6;
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(19, 25);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(75, 23);
            btnCategoria.TabIndex = 1;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnListar);
            panel3.Controls.Add(bthLimpiar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAgregar);
            panel3.Location = new Point(29, 360);
            panel3.Name = "panel3";
            panel3.Size = new Size(415, 75);
            panel3.TabIndex = 5;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(308, 25);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // bthLimpiar
            // 
            bthLimpiar.Location = new Point(211, 25);
            bthLimpiar.Name = "bthLimpiar";
            bthLimpiar.Size = new Size(75, 23);
            bthLimpiar.TabIndex = 3;
            bthLimpiar.Text = "Limpiar";
            bthLimpiar.UseVisualStyleBackColor = true;
            bthLimpiar.Click += bthLimpiar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(112, 25);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 25);
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
            listBoxProductos.Location = new Point(763, 34);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(445, 484);
            listBoxProductos.TabIndex = 2;
            listBoxProductos.SelectedIndexChanged += listBoxProductos_SelectedIndexChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 585);
            Controls.Add(listBoxProductos);
            Controls.Add(panel2);
            Name = "FormMain";
            Text = "FormMain";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtCantidad;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Button btnCategoria;
        private Panel panel3;
        private Button btnListar;
        private Button bthLimpiar;
        private Button btnEditar;
        private Button btnAgregar;
        private Label label5;
        private ComboBox cmbCategoria;
        private ListBox listBoxProductos;
    }
}