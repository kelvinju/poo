namespace vehiculo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comCombustible = new System.Windows.Forms.ComboBox();
            this.comColor = new System.Windows.Forms.ComboBox();
            this.comVentanas = new System.Windows.Forms.ComboBox();
            this.comPuertas = new System.Windows.Forms.ComboBox();
            this.comLLantas = new System.Windows.Forms.ComboBox();
            this.comAlas = new System.Windows.Forms.ComboBox();
            this.comTurbinas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comElices = new System.Windows.Forms.ComboBox();
            this.comAereo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.texApagar = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo De Combustible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero De Ventanas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero De Puertas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero De Llantas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero De Alas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero D e Turbinas";
            // 
            // comCombustible
            // 
            this.comCombustible.FormattingEnabled = true;
            this.comCombustible.Items.AddRange(new object[] {
            "gasolina",
            "disel",
            "electrico"});
            this.comCombustible.Location = new System.Drawing.Point(133, 6);
            this.comCombustible.Name = "comCombustible";
            this.comCombustible.Size = new System.Drawing.Size(121, 21);
            this.comCombustible.TabIndex = 7;
            // 
            // comColor
            // 
            this.comColor.FormattingEnabled = true;
            this.comColor.Items.AddRange(new object[] {
            "blanco",
            "negro",
            "rojo",
            "azul",
            "verde",
            "amarillo",
            "rosita"});
            this.comColor.Location = new System.Drawing.Point(133, 46);
            this.comColor.Name = "comColor";
            this.comColor.Size = new System.Drawing.Size(121, 21);
            this.comColor.TabIndex = 8;
            this.comColor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comVentanas
            // 
            this.comVentanas.FormattingEnabled = true;
            this.comVentanas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comVentanas.Location = new System.Drawing.Point(133, 86);
            this.comVentanas.Name = "comVentanas";
            this.comVentanas.Size = new System.Drawing.Size(121, 21);
            this.comVentanas.TabIndex = 9;
            this.comVentanas.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comPuertas
            // 
            this.comPuertas.FormattingEnabled = true;
            this.comPuertas.Items.AddRange(new object[] {
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
            this.comPuertas.Location = new System.Drawing.Point(133, 122);
            this.comPuertas.Name = "comPuertas";
            this.comPuertas.Size = new System.Drawing.Size(121, 21);
            this.comPuertas.TabIndex = 10;
            this.comPuertas.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comLLantas
            // 
            this.comLLantas.FormattingEnabled = true;
            this.comLLantas.Items.AddRange(new object[] {
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
            this.comLLantas.Location = new System.Drawing.Point(133, 155);
            this.comLLantas.Name = "comLLantas";
            this.comLLantas.Size = new System.Drawing.Size(107, 21);
            this.comLLantas.TabIndex = 11;
            this.comLLantas.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comAlas
            // 
            this.comAlas.FormattingEnabled = true;
            this.comAlas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comAlas.Location = new System.Drawing.Point(172, 209);
            this.comAlas.Name = "comAlas";
            this.comAlas.Size = new System.Drawing.Size(121, 21);
            this.comAlas.TabIndex = 12;
            // 
            // comTurbinas
            // 
            this.comTurbinas.FormattingEnabled = true;
            this.comTurbinas.Items.AddRange(new object[] {
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
            this.comTurbinas.Location = new System.Drawing.Point(172, 245);
            this.comTurbinas.Name = "comTurbinas";
            this.comTurbinas.Size = new System.Drawing.Size(121, 21);
            this.comTurbinas.TabIndex = 13;
            this.comTurbinas.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numero De Elices";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo De Vehiculo Aereo";
            // 
            // comElices
            // 
            this.comElices.FormattingEnabled = true;
            this.comElices.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comElices.Location = new System.Drawing.Point(172, 280);
            this.comElices.Name = "comElices";
            this.comElices.Size = new System.Drawing.Size(121, 21);
            this.comElices.TabIndex = 16;
            // 
            // comAereo
            // 
            this.comAereo.FormattingEnabled = true;
            this.comAereo.Items.AddRange(new object[] {
            "avion de pasajeros",
            "elicoptero"});
            this.comAereo.Location = new System.Drawing.Point(172, 313);
            this.comAereo.Name = "comAereo";
            this.comAereo.Size = new System.Drawing.Size(144, 21);
            this.comAereo.TabIndex = 17;
            this.comAereo.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Arrancar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comPuertas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comCombustible);
            this.groupBox1.Controls.Add(this.comColor);
            this.groupBox1.Controls.Add(this.comLLantas);
            this.groupBox1.Controls.Add(this.comVentanas);
            this.groupBox1.Location = new System.Drawing.Point(44, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 199);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(407, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "nuevo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // texApagar
            // 
            this.texApagar.Location = new System.Drawing.Point(44, 382);
            this.texApagar.Name = "texApagar";
            this.texApagar.Size = new System.Drawing.Size(100, 20);
            this.texApagar.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 457);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.texApagar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comAereo);
            this.Controls.Add(this.comElices);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comTurbinas);
            this.Controls.Add(this.comAlas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comCombustible;
        private System.Windows.Forms.ComboBox comColor;
        private System.Windows.Forms.ComboBox comVentanas;
        private System.Windows.Forms.ComboBox comPuertas;
        private System.Windows.Forms.ComboBox comLLantas;
        private System.Windows.Forms.ComboBox comAlas;
        private System.Windows.Forms.ComboBox comTurbinas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comElices;
        private System.Windows.Forms.ComboBox comAereo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox texApagar;
        private System.Windows.Forms.Button button5;
    }
}

