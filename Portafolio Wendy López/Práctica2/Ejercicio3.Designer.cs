namespace Práctica2
{
    partial class Ejercicio3
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDe = new System.Windows.Forms.ListBox();
            this.txtAnterior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(150, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(69, 201);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 13;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(124, 163);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.ReadOnly = true;
            this.txtNueva.Size = new System.Drawing.Size(100, 20);
            this.txtNueva.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstA);
            this.groupBox2.Location = new System.Drawing.Point(179, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 103);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "a";
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lstA.Location = new System.Drawing.Point(13, 30);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(102, 56);
            this.lstA.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDe);
            this.groupBox1.Location = new System.Drawing.Point(20, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 103);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De";
            // 
            // lstDe
            // 
            this.lstDe.FormattingEnabled = true;
            this.lstDe.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lstDe.Location = new System.Drawing.Point(10, 28);
            this.lstDe.Name = "lstDe";
            this.lstDe.Size = new System.Drawing.Size(102, 56);
            this.lstDe.TabIndex = 0;
            // 
            // txtAnterior
            // 
            this.txtAnterior.Location = new System.Drawing.Point(179, 6);
            this.txtAnterior.Name = "txtAnterior";
            this.txtAnterior.Size = new System.Drawing.Size(100, 20);
            this.txtAnterior.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Longitud convertida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Introduzca la longitud a convertir";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 237);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAnterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio 3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDe;
        private System.Windows.Forms.TextBox txtAnterior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}