namespace Actividad1
{
    partial class DatosProceso
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
            this.label1 = new System.Windows.Forms.Label();
            this.textProgramador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboOperacion = new System.Windows.Forms.ComboBox();
            this.numericDato1 = new System.Windows.Forms.NumericUpDown();
            this.numericDato2 = new System.Windows.Forms.NumericUpDown();
            this.numericTimeMax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericId = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericDato1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDato2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programador";
            // 
            // textProgramador
            // 
            this.textProgramador.Location = new System.Drawing.Point(107, 29);
            this.textProgramador.Name = "textProgramador";
            this.textProgramador.Size = new System.Drawing.Size(165, 20);
            this.textProgramador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dato 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dato 2";
            // 
            // comboOperacion
            // 
            this.comboOperacion.DisplayMember = "+";
            this.comboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOperacion.FormattingEnabled = true;
            this.comboOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "residuo",
            "potencia",
            "porcentaje"});
            this.comboOperacion.Location = new System.Drawing.Point(107, 69);
            this.comboOperacion.Name = "comboOperacion";
            this.comboOperacion.Size = new System.Drawing.Size(165, 21);
            this.comboOperacion.TabIndex = 10;
            // 
            // numericDato1
            // 
            this.numericDato1.Location = new System.Drawing.Point(107, 109);
            this.numericDato1.Name = "numericDato1";
            this.numericDato1.Size = new System.Drawing.Size(165, 20);
            this.numericDato1.TabIndex = 11;
            this.numericDato1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericDato2
            // 
            this.numericDato2.Location = new System.Drawing.Point(107, 154);
            this.numericDato2.Name = "numericDato2";
            this.numericDato2.Size = new System.Drawing.Size(165, 20);
            this.numericDato2.TabIndex = 12;
            this.numericDato2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericTimeMax
            // 
            this.numericTimeMax.Location = new System.Drawing.Point(107, 193);
            this.numericTimeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTimeMax.Name = "numericTimeMax";
            this.numericTimeMax.Size = new System.Drawing.Size(165, 20);
            this.numericTimeMax.TabIndex = 14;
            this.numericTimeMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiempo Maximo";
            // 
            // numericId
            // 
            this.numericId.Location = new System.Drawing.Point(107, 232);
            this.numericId.Name = "numericId";
            this.numericId.Size = new System.Drawing.Size(165, 20);
            this.numericId.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(165, 286);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(107, 24);
            this.buttonIngresar.TabIndex = 17;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // DatosProceso
            // 
            this.AcceptButton = this.buttonIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 318);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.numericId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericTimeMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericDato2);
            this.Controls.Add(this.numericDato1);
            this.Controls.Add(this.comboOperacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textProgramador);
            this.Controls.Add(this.label1);
            this.Name = "DatosProceso";
            this.Text = "DatosProceso";
            ((System.ComponentModel.ISupportInitialize)(this.numericDato1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDato2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textProgramador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboOperacion;
        private System.Windows.Forms.NumericUpDown numericDato1;
        private System.Windows.Forms.NumericUpDown numericDato2;
        private System.Windows.Forms.NumericUpDown numericTimeMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonIngresar;
    }
}