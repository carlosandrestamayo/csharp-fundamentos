namespace PedidoAppWF
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
            panel1 = new Panel();
            labelTotal = new Label();
            checkTocineta = new CheckBox();
            checkPapas = new CheckBox();
            checkQueso = new CheckBox();
            radioGrande = new RadioButton();
            radioMediano = new RadioButton();
            radioPequeno = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(checkTocineta);
            panel1.Controls.Add(checkPapas);
            panel1.Controls.Add(checkQueso);
            panel1.Controls.Add(radioGrande);
            panel1.Controls.Add(radioMediano);
            panel1.Controls.Add(radioPequeno);
            panel1.Location = new Point(166, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 173);
            panel1.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(113, 115);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(36, 15);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "Total:";
            // 
            // checkTocineta
            // 
            checkTocineta.AutoSize = true;
            checkTocineta.Location = new Point(190, 41);
            checkTocineta.Name = "checkTocineta";
            checkTocineta.Size = new Size(114, 19);
            checkTocineta.TabIndex = 5;
            checkTocineta.Text = "Tocineta (+3000)";
            checkTocineta.UseVisualStyleBackColor = true;
            checkTocineta.CheckedChanged += CalcularTotal;
            // 
            // checkPapas
            // 
            checkPapas.AutoSize = true;
            checkPapas.Location = new Point(190, 66);
            checkPapas.Name = "checkPapas";
            checkPapas.Size = new Size(100, 19);
            checkPapas.TabIndex = 4;
            checkPapas.Text = "Papas (+4000)";
            checkPapas.UseVisualStyleBackColor = true;
            checkPapas.CheckedChanged += CalcularTotal;
            // 
            // checkQueso
            // 
            checkQueso.AutoSize = true;
            checkQueso.Location = new Point(191, 16);
            checkQueso.Name = "checkQueso";
            checkQueso.Size = new Size(103, 19);
            checkQueso.TabIndex = 3;
            checkQueso.Text = "Queso (+2000)";
            checkQueso.UseVisualStyleBackColor = true;
            checkQueso.CheckedChanged += CalcularTotal;
            // 
            // radioGrande
            // 
            radioGrande.AutoSize = true;
            radioGrande.Location = new Point(15, 64);
            radioGrande.Name = "radioGrande";
            radioGrande.Size = new Size(110, 19);
            radioGrande.TabIndex = 2;
            radioGrande.TabStop = true;
            radioGrande.Text = "Grande ($20000)";
            radioGrande.UseVisualStyleBackColor = true;
            radioGrande.CheckedChanged += CalcularTotal;
            // 
            // radioMediano
            // 
            radioMediano.AutoSize = true;
            radioMediano.Location = new Point(15, 39);
            radioMediano.Name = "radioMediano";
            radioMediano.Size = new Size(119, 19);
            radioMediano.TabIndex = 1;
            radioMediano.TabStop = true;
            radioMediano.Text = "Mediano ($15000)";
            radioMediano.UseVisualStyleBackColor = true;
            radioMediano.CheckedChanged += CalcularTotal;
            // 
            // radioPequeno
            // 
            radioPequeno.AutoSize = true;
            radioPequeno.Location = new Point(15, 14);
            radioPequeno.Name = "radioPequeno";
            radioPequeno.Size = new Size(119, 19);
            radioPequeno.TabIndex = 0;
            radioPequeno.TabStop = true;
            radioPequeno.Text = "Pequeño ($10000)";
            radioPequeno.UseVisualStyleBackColor = true;
            radioPequeno.CheckedChanged += CalcularTotal;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton radioGrande;
        private RadioButton radioMediano;
        private RadioButton radioPequeno;
        private CheckBox checkTocineta;
        private CheckBox checkPapas;
        private CheckBox checkQueso;
        private Label labelTotal;
    }
}
