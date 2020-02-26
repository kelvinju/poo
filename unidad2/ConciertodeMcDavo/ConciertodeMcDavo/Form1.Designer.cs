namespace ConciertodeMcDavo
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
            this.comPersonas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comEntrada = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.texbebes = new System.Windows.Forms.TextBox();
            this.texniños = new System.Windows.Forms.TextBox();
            this.texadultos = new System.Windows.Forms.TextBox();
            this.textercera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "personas";
            // 
            // comPersonas
            // 
            this.comPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPersonas.FormattingEnabled = true;
            this.comPersonas.Items.AddRange(new object[] {
            "bebes",
            "niños",
            "adultos",
            "tercera edad"});
            this.comPersonas.Location = new System.Drawing.Point(132, 26);
            this.comPersonas.Name = "comPersonas";
            this.comPersonas.Size = new System.Drawing.Size(121, 21);
            this.comPersonas.TabIndex = 1;
            this.comPersonas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entradas";
            // 
            // comEntrada
            // 
            this.comEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comEntrada.FormattingEnabled = true;
            this.comEntrada.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comEntrada.Location = new System.Drawing.Point(151, 81);
            this.comEntrada.Name = "comEntrada";
            this.comEntrada.Size = new System.Drawing.Size(52, 21);
            this.comEntrada.TabIndex = 3;
            this.comEntrada.SelectedIndexChanged += new System.EventHandler(this.comEntrada_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Capturar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reportar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "bebes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "niños";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "adultos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "terceredad";
            // 
            // texbebes
            // 
            this.texbebes.Location = new System.Drawing.Point(68, 222);
            this.texbebes.Name = "texbebes";
            this.texbebes.Size = new System.Drawing.Size(67, 20);
            this.texbebes.TabIndex = 10;
            // 
            // texniños
            // 
            this.texniños.Location = new System.Drawing.Point(70, 270);
            this.texniños.Name = "texniños";
            this.texniños.Size = new System.Drawing.Size(60, 20);
            this.texniños.TabIndex = 11;
            // 
            // texadultos
            // 
            this.texadultos.Location = new System.Drawing.Point(211, 218);
            this.texadultos.Name = "texadultos";
            this.texadultos.Size = new System.Drawing.Size(42, 20);
            this.texadultos.TabIndex = 12;
            // 
            // textercera
            // 
            this.textercera.Location = new System.Drawing.Point(227, 274);
            this.textercera.Name = "textercera";
            this.textercera.Size = new System.Drawing.Size(51, 20);
            this.textercera.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.textercera);
            this.Controls.Add(this.texadultos);
            this.Controls.Add(this.texniños);
            this.Controls.Add(this.texbebes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comPersonas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comEntrada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texbebes;
        private System.Windows.Forms.TextBox texniños;
        private System.Windows.Forms.TextBox texadultos;
        private System.Windows.Forms.TextBox textercera;
    }
}

