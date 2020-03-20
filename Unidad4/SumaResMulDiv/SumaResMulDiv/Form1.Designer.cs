namespace SumaResMulDiv
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
            this.label2 = new System.Windows.Forms.Label();
            this.texValor1 = new System.Windows.Forms.TextBox();
            this.texValor2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.texSuma = new System.Windows.Forms.TextBox();
            this.texMultiplicacion = new System.Windows.Forms.TextBox();
            this.texDivicion = new System.Windows.Forms.TextBox();
            this.texResta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor2";
            // 
            // texValor1
            // 
            this.texValor1.Location = new System.Drawing.Point(66, 20);
            this.texValor1.Name = "texValor1";
            this.texValor1.Size = new System.Drawing.Size(100, 20);
            this.texValor1.TabIndex = 2;
            this.texValor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // texValor2
            // 
            this.texValor2.Location = new System.Drawing.Point(66, 64);
            this.texValor2.Name = "texValor2";
            this.texValor2.Size = new System.Drawing.Size(100, 20);
            this.texValor2.TabIndex = 3;
            this.texValor2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "suma";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "divicion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "multiplicacion";
            // 
            // texSuma
            // 
            this.texSuma.Location = new System.Drawing.Point(61, 171);
            this.texSuma.Name = "texSuma";
            this.texSuma.Size = new System.Drawing.Size(69, 20);
            this.texSuma.TabIndex = 9;
            // 
            // texMultiplicacion
            // 
            this.texMultiplicacion.Location = new System.Drawing.Point(217, 171);
            this.texMultiplicacion.Name = "texMultiplicacion";
            this.texMultiplicacion.Size = new System.Drawing.Size(65, 20);
            this.texMultiplicacion.TabIndex = 10;
            // 
            // texDivicion
            // 
            this.texDivicion.Location = new System.Drawing.Point(190, 215);
            this.texDivicion.Name = "texDivicion";
            this.texDivicion.Size = new System.Drawing.Size(67, 20);
            this.texDivicion.TabIndex = 11;
            // 
            // texResta
            // 
            this.texResta.Location = new System.Drawing.Point(61, 219);
            this.texResta.Name = "texResta";
            this.texResta.Size = new System.Drawing.Size(69, 20);
            this.texResta.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.texResta);
            this.Controls.Add(this.texDivicion);
            this.Controls.Add(this.texMultiplicacion);
            this.Controls.Add(this.texSuma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texValor2);
            this.Controls.Add(this.texValor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texValor1;
        private System.Windows.Forms.TextBox texValor2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texSuma;
        private System.Windows.Forms.TextBox texMultiplicacion;
        private System.Windows.Forms.TextBox texDivicion;
        private System.Windows.Forms.TextBox texResta;
    }
}

