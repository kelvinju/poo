﻿namespace GradosCentigrados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comGrados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texCantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.texResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo dde grado";
            // 
            // comGrados
            // 
            this.comGrados.FormattingEnabled = true;
            this.comGrados.Items.AddRange(new object[] {
            "Fahrenheit",
            "Centigrados"});
            this.comGrados.Location = new System.Drawing.Point(132, 22);
            this.comGrados.Name = "comGrados";
            this.comGrados.Size = new System.Drawing.Size(114, 21);
            this.comGrados.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grados";
            // 
            // texCantidad
            // 
            this.texCantidad.Location = new System.Drawing.Point(146, 76);
            this.texCantidad.Name = "texCantidad";
            this.texCantidad.Size = new System.Drawing.Size(100, 20);
            this.texCantidad.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Combertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texResultado
            // 
            this.texResultado.Location = new System.Drawing.Point(123, 184);
            this.texResultado.Name = "texResultado";
            this.texResultado.Size = new System.Drawing.Size(100, 20);
            this.texResultado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comvercion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comGrados);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comGrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texResultado;
        private System.Windows.Forms.Label label3;
    }
}

