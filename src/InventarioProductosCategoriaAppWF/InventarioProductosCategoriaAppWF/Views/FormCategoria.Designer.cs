namespace InventarioProductosCategoriaAppWF.Views
{
    partial class FormCategoria
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnListar = new Button();
            label3 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            listBoxCategorias = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(57, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 137);
            panel1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 85);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(185, 23);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(38, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(139, 23);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(240, 23);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(175, 34);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 4;
            label3.Text = "Categorías";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnListar);
            panel2.Location = new Point(57, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 66);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(144, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 360);
            panel3.TabIndex = 6;
            // 
            // listBoxCategorias
            // 
            listBoxCategorias.FormattingEnabled = true;
            listBoxCategorias.Location = new Point(656, 46);
            listBoxCategorias.Name = "listBoxCategorias";
            listBoxCategorias.Size = new Size(381, 364);
            listBoxCategorias.TabIndex = 7;
            listBoxCategorias.SelectedIndexChanged += listBoxCategorias_SelectedIndexChanged;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 592);
            Controls.Add(listBoxCategorias);
            Controls.Add(panel3);
            Name = "FormCategoria";
            Text = "FormCategoria";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnListar;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private ListBox listBoxCategorias;
    }
}