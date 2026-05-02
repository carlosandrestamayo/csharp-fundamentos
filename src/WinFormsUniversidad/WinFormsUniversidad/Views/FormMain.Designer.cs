namespace WinFormsUniversidad.Views
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
            panelMain = new Panel();
            btnEstudiante = new Button();
            btnProfesor = new Button();
            btnMateria = new Button();
            panelMateria = new Panel();
            listBoxMaterias = new ListBox();
            btnAgregarMateria = new Button();
            txtNombreMateria = new TextBox();
            label5 = new Label();
            txtCodigoMateria = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panelProfesor = new Panel();
            listBoxProfesores = new ListBox();
            btnAgregarProfesor = new Button();
            label9 = new Label();
            comboBoxMateriasProfesor = new ComboBox();
            txtTelefonoProfesor = new TextBox();
            label10 = new Label();
            txtNombreProfesor = new TextBox();
            NOMBRE = new Label();
            txtIdProfesor = new TextBox();
            ID = new Label();
            label2 = new Label();
            panelEstudiante = new Panel();
            checkedListBoxMaterias = new CheckedListBox();
            btnAgregarEstudiante = new Button();
            listBoxEstudiantes = new ListBox();
            txttelefonoEstudiante = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtNombreEstudiante = new TextBox();
            txtIdEstudiante = new TextBox();
            label7 = new Label();
            panelMain.SuspendLayout();
            panelMateria.SuspendLayout();
            panelProfesor.SuspendLayout();
            panelEstudiante.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(btnEstudiante);
            panelMain.Controls.Add(btnProfesor);
            panelMain.Controls.Add(btnMateria);
            panelMain.Location = new Point(400, 48);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(600, 63);
            panelMain.TabIndex = 0;
            // 
            // btnEstudiante
            // 
            btnEstudiante.Location = new Point(465, 20);
            btnEstudiante.Name = "btnEstudiante";
            btnEstudiante.Size = new Size(75, 23);
            btnEstudiante.TabIndex = 2;
            btnEstudiante.Text = "Estudiante";
            btnEstudiante.UseVisualStyleBackColor = true;
            btnEstudiante.Click += btnEstudiante_Click;
            // 
            // btnProfesor
            // 
            btnProfesor.Location = new Point(254, 20);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new Size(75, 23);
            btnProfesor.TabIndex = 1;
            btnProfesor.Text = "Profesor";
            btnProfesor.UseVisualStyleBackColor = true;
            btnProfesor.Click += btnProfesor_Click;
            // 
            // btnMateria
            // 
            btnMateria.Location = new Point(50, 20);
            btnMateria.Name = "btnMateria";
            btnMateria.Size = new Size(75, 23);
            btnMateria.TabIndex = 0;
            btnMateria.Text = "Materia";
            btnMateria.UseVisualStyleBackColor = true;
            btnMateria.Click += btnMateria_Click;
            // 
            // panelMateria
            // 
            panelMateria.BorderStyle = BorderStyle.FixedSingle;
            panelMateria.Controls.Add(listBoxMaterias);
            panelMateria.Controls.Add(btnAgregarMateria);
            panelMateria.Controls.Add(txtNombreMateria);
            panelMateria.Controls.Add(label5);
            panelMateria.Controls.Add(txtCodigoMateria);
            panelMateria.Controls.Add(label4);
            panelMateria.Controls.Add(label1);
            panelMateria.Location = new Point(12, 132);
            panelMateria.Name = "panelMateria";
            panelMateria.Size = new Size(600, 211);
            panelMateria.TabIndex = 1;
            // 
            // listBoxMaterias
            // 
            listBoxMaterias.FormattingEnabled = true;
            listBoxMaterias.Location = new Point(344, 57);
            listBoxMaterias.Name = "listBoxMaterias";
            listBoxMaterias.Size = new Size(217, 124);
            listBoxMaterias.TabIndex = 6;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(205, 149);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(75, 23);
            btnAgregarMateria.TabIndex = 3;
            btnAgregarMateria.Text = "Agregar";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(100, 100);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(196, 23);
            txtNombreMateria.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 103);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 3;
            label5.Text = "NOMBRE";
            // 
            // txtCodigoMateria
            // 
            txtCodigoMateria.Location = new Point(100, 57);
            txtCodigoMateria.Name = "txtCodigoMateria";
            txtCodigoMateria.Size = new Size(196, 23);
            txtCodigoMateria.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 60);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 1;
            label4.Text = "CODIGO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Formulario Materias";
            // 
            // panelProfesor
            // 
            panelProfesor.BorderStyle = BorderStyle.FixedSingle;
            panelProfesor.Controls.Add(listBoxProfesores);
            panelProfesor.Controls.Add(btnAgregarProfesor);
            panelProfesor.Controls.Add(label9);
            panelProfesor.Controls.Add(comboBoxMateriasProfesor);
            panelProfesor.Controls.Add(txtTelefonoProfesor);
            panelProfesor.Controls.Add(label10);
            panelProfesor.Controls.Add(txtNombreProfesor);
            panelProfesor.Controls.Add(NOMBRE);
            panelProfesor.Controls.Add(txtIdProfesor);
            panelProfesor.Controls.Add(ID);
            panelProfesor.Controls.Add(label2);
            panelProfesor.Location = new Point(12, 367);
            panelProfesor.Name = "panelProfesor";
            panelProfesor.Size = new Size(600, 280);
            panelProfesor.TabIndex = 2;
            // 
            // listBoxProfesores
            // 
            listBoxProfesores.FormattingEnabled = true;
            listBoxProfesores.Location = new Point(344, 49);
            listBoxProfesores.Name = "listBoxProfesores";
            listBoxProfesores.Size = new Size(217, 199);
            listBoxProfesores.TabIndex = 7;
            // 
            // btnAgregarProfesor
            // 
            btnAgregarProfesor.Location = new Point(93, 244);
            btnAgregarProfesor.Name = "btnAgregarProfesor";
            btnAgregarProfesor.Size = new Size(110, 23);
            btnAgregarProfesor.TabIndex = 8;
            btnAgregarProfesor.Text = "Agregar";
            btnAgregarProfesor.UseVisualStyleBackColor = true;
            btnAgregarProfesor.Click += btnAgregarProfesor_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 189);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 12;
            label9.Text = "MATERIA";
            // 
            // comboBoxMateriasProfesor
            // 
            comboBoxMateriasProfesor.FormattingEnabled = true;
            comboBoxMateriasProfesor.Location = new Point(93, 189);
            comboBoxMateriasProfesor.Name = "comboBoxMateriasProfesor";
            comboBoxMateriasProfesor.Size = new Size(196, 23);
            comboBoxMateriasProfesor.TabIndex = 7;
            // 
            // txtTelefonoProfesor
            // 
            txtTelefonoProfesor.Location = new Point(93, 138);
            txtTelefonoProfesor.Name = "txtTelefonoProfesor";
            txtTelefonoProfesor.Size = new Size(196, 23);
            txtTelefonoProfesor.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 141);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 9;
            label10.Text = "TELEFONO";
            // 
            // txtNombreProfesor
            // 
            txtNombreProfesor.Location = new Point(93, 92);
            txtNombreProfesor.Name = "txtNombreProfesor";
            txtNombreProfesor.Size = new Size(196, 23);
            txtNombreProfesor.TabIndex = 5;
            // 
            // NOMBRE
            // 
            NOMBRE.AutoSize = true;
            NOMBRE.Location = new Point(15, 95);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(56, 15);
            NOMBRE.TabIndex = 7;
            NOMBRE.Text = "NOMBRE";
            // 
            // txtIdProfesor
            // 
            txtIdProfesor.Location = new Point(93, 49);
            txtIdProfesor.Name = "txtIdProfesor";
            txtIdProfesor.Size = new Size(196, 23);
            txtIdProfesor.TabIndex = 4;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(15, 52);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 5;
            ID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 20);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Formulario Profesor";
            // 
            // panelEstudiante
            // 
            panelEstudiante.BorderStyle = BorderStyle.FixedSingle;
            panelEstudiante.Controls.Add(checkedListBoxMaterias);
            panelEstudiante.Controls.Add(btnAgregarEstudiante);
            panelEstudiante.Controls.Add(listBoxEstudiantes);
            panelEstudiante.Controls.Add(txttelefonoEstudiante);
            panelEstudiante.Controls.Add(label3);
            panelEstudiante.Controls.Add(label6);
            panelEstudiante.Controls.Add(label8);
            panelEstudiante.Controls.Add(txtNombreEstudiante);
            panelEstudiante.Controls.Add(txtIdEstudiante);
            panelEstudiante.Controls.Add(label7);
            panelEstudiante.Location = new Point(633, 132);
            panelEstudiante.Name = "panelEstudiante";
            panelEstudiante.Size = new Size(769, 281);
            panelEstudiante.TabIndex = 2;
            // 
            // checkedListBoxMaterias
            // 
            checkedListBoxMaterias.FormattingEnabled = true;
            checkedListBoxMaterias.Location = new Point(334, 60);
            checkedListBoxMaterias.Name = "checkedListBoxMaterias";
            checkedListBoxMaterias.Size = new Size(142, 184);
            checkedListBoxMaterias.TabIndex = 12;
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.Location = new Point(122, 204);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(110, 23);
            btnAgregarEstudiante.TabIndex = 13;
            btnAgregarEstudiante.Text = "Agregar";
            btnAgregarEstudiante.UseVisualStyleBackColor = true;
            btnAgregarEstudiante.Click += btnAgregarEstudiante_Click;
            // 
            // listBoxEstudiantes
            // 
            listBoxEstudiantes.FormattingEnabled = true;
            listBoxEstudiantes.Location = new Point(514, 57);
            listBoxEstudiantes.Name = "listBoxEstudiantes";
            listBoxEstudiantes.Size = new Size(217, 199);
            listBoxEstudiantes.TabIndex = 17;
            // 
            // txttelefonoEstudiante
            // 
            txttelefonoEstudiante.Location = new Point(99, 146);
            txttelefonoEstudiante.Name = "txttelefonoEstudiante";
            txttelefonoEstudiante.Size = new Size(196, 23);
            txttelefonoEstudiante.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 20);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 1;
            label3.Text = "Formulario Estudiante";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 149);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 15;
            label6.Text = "TELEFONO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 60);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 11;
            label8.Text = "ID";
            // 
            // txtNombreEstudiante
            // 
            txtNombreEstudiante.Location = new Point(99, 100);
            txtNombreEstudiante.Name = "txtNombreEstudiante";
            txtNombreEstudiante.Size = new Size(196, 23);
            txtNombreEstudiante.TabIndex = 10;
            // 
            // txtIdEstudiante
            // 
            txtIdEstudiante.Location = new Point(99, 57);
            txtIdEstudiante.Name = "txtIdEstudiante";
            txtIdEstudiante.Size = new Size(196, 23);
            txtIdEstudiante.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 103);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 13;
            label7.Text = "NOMBRE";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 660);
            Controls.Add(panelEstudiante);
            Controls.Add(panelProfesor);
            Controls.Add(panelMateria);
            Controls.Add(panelMain);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            panelMain.ResumeLayout(false);
            panelMateria.ResumeLayout(false);
            panelMateria.PerformLayout();
            panelProfesor.ResumeLayout(false);
            panelProfesor.PerformLayout();
            panelEstudiante.ResumeLayout(false);
            panelEstudiante.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button btnEstudiante;
        private Button btnProfesor;
        private Button btnMateria;
        private Panel panelMateria;
        private Label label1;
        private Panel panelProfesor;
        private Label label2;
        private Panel panelEstudiante;
        private Label label3;
        private TextBox txtNombreMateria;
        private Label label5;
        private TextBox txtCodigoMateria;
        private Label label4;
        private TextBox txtTelefonoProfesor;
        private Label label10;
        private TextBox txtNombreProfesor;
        private Label NOMBRE;
        private TextBox txtIdProfesor;
        private Label ID;
        private TextBox txttelefonoEstudiante;
        private Label label6;
        private Label label8;
        private TextBox txtNombreEstudiante;
        private TextBox txtIdEstudiante;
        private Label label7;
        private ListBox listBoxMaterias;
        private Button btnAgregarMateria;
        private Label label9;
        private ComboBox comboBoxMateriasProfesor;
        private Button btnAgregarProfesor;
        private ListBox listBoxProfesores;
        private ListBox listBoxEstudiantes;
        private Button btnAgregarEstudiante;
        private CheckedListBox checkedListBoxMaterias;
    }
}