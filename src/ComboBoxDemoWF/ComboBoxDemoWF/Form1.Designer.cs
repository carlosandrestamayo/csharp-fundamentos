namespace ComboBoxDemoWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAccion = new Button();
            comboBoxOpciones = new ComboBox();
            labelInfo = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAccion
            // 
            buttonAccion.Location = new Point(174, 89);
            buttonAccion.Name = "buttonAccion";
            buttonAccion.Size = new Size(131, 23);
            buttonAccion.TabIndex = 0;
            buttonAccion.Text = "Mostrar Accion";
            buttonAccion.UseVisualStyleBackColor = true;
            buttonAccion.Click += buttonAccion_Click;
            // 
            // comboBoxOpciones
            // 
            comboBoxOpciones.FormattingEnabled = true;
            comboBoxOpciones.Location = new Point(86, 31);
            comboBoxOpciones.Name = "comboBoxOpciones";
            comboBoxOpciones.Size = new Size(186, 23);
            comboBoxOpciones.TabIndex = 1;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(316, 34);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(72, 15);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "Informacion";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxOpciones);
            panel1.Controls.Add(buttonAccion);
            panel1.Controls.Add(labelInfo);
            panel1.Location = new Point(503, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 162);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 540);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAccion;
        private ComboBox comboBoxOpciones;
        private Label labelInfo;
        private Panel panel1;
    }
}
