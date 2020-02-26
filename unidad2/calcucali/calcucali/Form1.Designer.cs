namespace calcucali
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
            this.btnCapturar = new System.Windows.Forms.Button();
            this.texCali = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texReprobados = new System.Windows.Forms.TextBox();
            this.texAprobados = new System.Windows.Forms.TextBox();
            this.texPro = new System.Windows.Forms.TextBox();
            this.btnReportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "calificaciones";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(109, 69);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // texCali
            // 
            this.texCali.Location = new System.Drawing.Point(109, 33);
            this.texCali.Name = "texCali";
            this.texCali.Size = new System.Drawing.Size(100, 20);
            this.texCali.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reprobados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aprobados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Promedio";
            // 
            // texReprobados
            // 
            this.texReprobados.Location = new System.Drawing.Point(94, 165);
            this.texReprobados.Name = "texReprobados";
            this.texReprobados.Size = new System.Drawing.Size(100, 20);
            this.texReprobados.TabIndex = 6;
            // 
            // texAprobados
            // 
            this.texAprobados.Location = new System.Drawing.Point(94, 221);
            this.texAprobados.Name = "texAprobados";
            this.texAprobados.Size = new System.Drawing.Size(100, 20);
            this.texAprobados.TabIndex = 7;
            // 
            // texPro
            // 
            this.texPro.Location = new System.Drawing.Point(94, 258);
            this.texPro.Name = "texPro";
            this.texPro.Size = new System.Drawing.Size(100, 20);
            this.texPro.TabIndex = 8;
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(181, 287);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(75, 23);
            this.btnReportar.TabIndex = 9;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.texPro);
            this.Controls.Add(this.texAprobados);
            this.Controls.Add(this.texReprobados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texCali);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox texCali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texReprobados;
        private System.Windows.Forms.TextBox texAprobados;
        private System.Windows.Forms.TextBox texPro;
        private System.Windows.Forms.Button btnReportar;
    }
}

