﻿namespace Actividad1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProcesosNuevos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TiempoRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.TiempoBloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesosBloqueadosBS = new System.Windows.Forms.BindingSource(this.components);
            this.procesosTerminadosBS = new System.Windows.Forms.BindingSource(this.components);
            this.procesoActualBS = new System.Windows.Forms.BindingSource(this.components);
            this.programadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dato1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dato2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesosListosBS = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programadorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dato1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dato2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoMaximoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoRestanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoTranscurridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoFinalización = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoMaximoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosBloqueadosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosTerminadosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoActualBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosListosBS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesos Nuevos: ";
            // 
            // labelProcesosNuevos
            // 
            this.labelProcesosNuevos.AutoSize = true;
            this.labelProcesosNuevos.Location = new System.Drawing.Point(152, 27);
            this.labelProcesosNuevos.Name = "labelProcesosNuevos";
            this.labelProcesosNuevos.Size = new System.Drawing.Size(13, 13);
            this.labelProcesosNuevos.TabIndex = 1;
            this.labelProcesosNuevos.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programadorDataGridViewTextBoxColumn,
            this.operacionDataGridViewTextBoxColumn,
            this.dato1DataGridViewTextBoxColumn,
            this.dato2DataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.tiempoMaximoDataGridViewTextBoxColumn,
            this.TiempoRestante});
            this.dataGridView1.DataSource = this.procesosListosBS;
            this.dataGridView1.Location = new System.Drawing.Point(25, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(360, 208);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // TiempoRestante
            // 
            this.TiempoRestante.DataPropertyName = "TiempoRestante";
            this.TiempoRestante.HeaderText = "TiempoRestante";
            this.TiempoRestante.Name = "TiempoRestante";
            this.TiempoRestante.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.programadorDataGridViewTextBoxColumn1,
            this.operacionDataGridViewTextBoxColumn1,
            this.dato1DataGridViewTextBoxColumn1,
            this.dato2DataGridViewTextBoxColumn1,
            this.tiempoMaximoDataGridViewTextBoxColumn1,
            this.tiempoRestanteDataGridViewTextBoxColumn,
            this.tiempoTranscurridoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.procesoActualBS;
            this.dataGridView2.Location = new System.Drawing.Point(54, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(820, 80);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.operacionDataGridViewTextBoxColumn2,
            this.resultadoDataGridViewTextBoxColumn,
            this.TiempoLlegada,
            this.TiempoFinalización,
            this.TiempoRetorno,
            this.TiempoRespuesta,
            this.TiempoEspera,
            this.TiempoServicio,
            this.tiempoMaximoDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.procesosTerminadosBS;
            this.dataGridView3.Location = new System.Drawing.Point(12, 425);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(899, 248);
            this.dataGridView3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reloj:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(741, 27);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(13, 13);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Proceso Actual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cola Listos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Procesos Terminados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.TiempoBloqueado});
            this.dataGridView4.DataSource = this.procesosBloqueadosBS;
            this.dataGridView4.Location = new System.Drawing.Point(626, 193);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(266, 208);
            this.dataGridView4.TabIndex = 13;
            // 
            // TiempoBloqueado
            // 
            this.TiempoBloqueado.DataPropertyName = "TiempoBloqueado";
            this.TiempoBloqueado.HeaderText = "TiempoBloqueado";
            this.TiempoBloqueado.Name = "TiempoBloqueado";
            this.TiempoBloqueado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Procesos Bloqueados";
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // procesosBloqueadosBS
            // 
            this.procesosBloqueadosBS.DataSource = typeof(Actividad1.Proceso);
            // 
            // procesosTerminadosBS
            // 
            this.procesosTerminadosBS.DataSource = typeof(Actividad1.Proceso);
            // 
            // procesoActualBS
            // 
            this.procesoActualBS.DataSource = typeof(Actividad1.Proceso);
            // 
            // programadorDataGridViewTextBoxColumn
            // 
            this.programadorDataGridViewTextBoxColumn.DataPropertyName = "Programador";
            this.programadorDataGridViewTextBoxColumn.HeaderText = "Programador";
            this.programadorDataGridViewTextBoxColumn.Name = "programadorDataGridViewTextBoxColumn";
            this.programadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.programadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // operacionDataGridViewTextBoxColumn
            // 
            this.operacionDataGridViewTextBoxColumn.DataPropertyName = "Operacion";
            this.operacionDataGridViewTextBoxColumn.HeaderText = "Operacion";
            this.operacionDataGridViewTextBoxColumn.Name = "operacionDataGridViewTextBoxColumn";
            this.operacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.operacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dato1DataGridViewTextBoxColumn
            // 
            this.dato1DataGridViewTextBoxColumn.DataPropertyName = "Dato1";
            this.dato1DataGridViewTextBoxColumn.HeaderText = "Dato1";
            this.dato1DataGridViewTextBoxColumn.Name = "dato1DataGridViewTextBoxColumn";
            this.dato1DataGridViewTextBoxColumn.ReadOnly = true;
            this.dato1DataGridViewTextBoxColumn.Visible = false;
            // 
            // dato2DataGridViewTextBoxColumn
            // 
            this.dato2DataGridViewTextBoxColumn.DataPropertyName = "Dato2";
            this.dato2DataGridViewTextBoxColumn.HeaderText = "Dato2";
            this.dato2DataGridViewTextBoxColumn.Name = "dato2DataGridViewTextBoxColumn";
            this.dato2DataGridViewTextBoxColumn.ReadOnly = true;
            this.dato2DataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoMaximoDataGridViewTextBoxColumn
            // 
            this.tiempoMaximoDataGridViewTextBoxColumn.DataPropertyName = "TiempoMaximo";
            this.tiempoMaximoDataGridViewTextBoxColumn.HeaderText = "TiempoMaximo";
            this.tiempoMaximoDataGridViewTextBoxColumn.Name = "tiempoMaximoDataGridViewTextBoxColumn";
            this.tiempoMaximoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procesosListosBS
            // 
            this.procesosListosBS.DataSource = typeof(Actividad1.Proceso);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // programadorDataGridViewTextBoxColumn1
            // 
            this.programadorDataGridViewTextBoxColumn1.DataPropertyName = "Programador";
            this.programadorDataGridViewTextBoxColumn1.HeaderText = "Programador";
            this.programadorDataGridViewTextBoxColumn1.Name = "programadorDataGridViewTextBoxColumn1";
            this.programadorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.programadorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // operacionDataGridViewTextBoxColumn1
            // 
            this.operacionDataGridViewTextBoxColumn1.DataPropertyName = "Operacion";
            this.operacionDataGridViewTextBoxColumn1.HeaderText = "Operacion";
            this.operacionDataGridViewTextBoxColumn1.Name = "operacionDataGridViewTextBoxColumn1";
            this.operacionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dato1DataGridViewTextBoxColumn1
            // 
            this.dato1DataGridViewTextBoxColumn1.DataPropertyName = "Dato1";
            this.dato1DataGridViewTextBoxColumn1.HeaderText = "Dato1";
            this.dato1DataGridViewTextBoxColumn1.Name = "dato1DataGridViewTextBoxColumn1";
            this.dato1DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dato2DataGridViewTextBoxColumn1
            // 
            this.dato2DataGridViewTextBoxColumn1.DataPropertyName = "Dato2";
            this.dato2DataGridViewTextBoxColumn1.HeaderText = "Dato2";
            this.dato2DataGridViewTextBoxColumn1.Name = "dato2DataGridViewTextBoxColumn1";
            this.dato2DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tiempoMaximoDataGridViewTextBoxColumn1
            // 
            this.tiempoMaximoDataGridViewTextBoxColumn1.DataPropertyName = "TiempoMaximo";
            this.tiempoMaximoDataGridViewTextBoxColumn1.HeaderText = "Tiempo Maximo";
            this.tiempoMaximoDataGridViewTextBoxColumn1.Name = "tiempoMaximoDataGridViewTextBoxColumn1";
            this.tiempoMaximoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tiempoMaximoDataGridViewTextBoxColumn1.Width = 120;
            // 
            // tiempoRestanteDataGridViewTextBoxColumn
            // 
            this.tiempoRestanteDataGridViewTextBoxColumn.DataPropertyName = "TiempoRestante";
            this.tiempoRestanteDataGridViewTextBoxColumn.HeaderText = "Tiempo Restante";
            this.tiempoRestanteDataGridViewTextBoxColumn.Name = "tiempoRestanteDataGridViewTextBoxColumn";
            this.tiempoRestanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiempoRestanteDataGridViewTextBoxColumn.Width = 120;
            // 
            // tiempoTranscurridoDataGridViewTextBoxColumn
            // 
            this.tiempoTranscurridoDataGridViewTextBoxColumn.DataPropertyName = "TiempoTranscurrido";
            this.tiempoTranscurridoDataGridViewTextBoxColumn.HeaderText = "Tiempo Transcurrido";
            this.tiempoTranscurridoDataGridViewTextBoxColumn.Name = "tiempoTranscurridoDataGridViewTextBoxColumn";
            this.tiempoTranscurridoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiempoTranscurridoDataGridViewTextBoxColumn.Width = 130;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 50;
            // 
            // operacionDataGridViewTextBoxColumn2
            // 
            this.operacionDataGridViewTextBoxColumn2.DataPropertyName = "Operacion";
            this.operacionDataGridViewTextBoxColumn2.HeaderText = "Operacion";
            this.operacionDataGridViewTextBoxColumn2.Name = "operacionDataGridViewTextBoxColumn2";
            this.operacionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // resultadoDataGridViewTextBoxColumn
            // 
            this.resultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.HeaderText = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.Name = "resultadoDataGridViewTextBoxColumn";
            this.resultadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TiempoLlegada
            // 
            this.TiempoLlegada.DataPropertyName = "TiempoLlegada";
            this.TiempoLlegada.HeaderText = "TiempoLlegada";
            this.TiempoLlegada.Name = "TiempoLlegada";
            this.TiempoLlegada.ReadOnly = true;
            // 
            // TiempoFinalización
            // 
            this.TiempoFinalización.DataPropertyName = "TiempoFinalización";
            this.TiempoFinalización.HeaderText = "TiempoFinalización";
            this.TiempoFinalización.Name = "TiempoFinalización";
            this.TiempoFinalización.ReadOnly = true;
            // 
            // TiempoRetorno
            // 
            this.TiempoRetorno.DataPropertyName = "TiempoRetorno";
            this.TiempoRetorno.HeaderText = "TiempoRetorno";
            this.TiempoRetorno.Name = "TiempoRetorno";
            this.TiempoRetorno.ReadOnly = true;
            // 
            // TiempoRespuesta
            // 
            this.TiempoRespuesta.DataPropertyName = "TiempoRespuesta";
            this.TiempoRespuesta.HeaderText = "TiempoRespuesta";
            this.TiempoRespuesta.Name = "TiempoRespuesta";
            this.TiempoRespuesta.ReadOnly = true;
            // 
            // TiempoEspera
            // 
            this.TiempoEspera.DataPropertyName = "TiempoEspera";
            this.TiempoEspera.HeaderText = "TiempoEspera";
            this.TiempoEspera.Name = "TiempoEspera";
            this.TiempoEspera.ReadOnly = true;
            // 
            // TiempoServicio
            // 
            this.TiempoServicio.DataPropertyName = "TiempoServicio";
            this.TiempoServicio.HeaderText = "TiempoServicio";
            this.TiempoServicio.Name = "TiempoServicio";
            this.TiempoServicio.ReadOnly = true;
            // 
            // tiempoMaximoDataGridViewTextBoxColumn2
            // 
            this.tiempoMaximoDataGridViewTextBoxColumn2.DataPropertyName = "TiempoMaximo";
            this.tiempoMaximoDataGridViewTextBoxColumn2.HeaderText = "TiempoMaximo";
            this.tiempoMaximoDataGridViewTextBoxColumn2.Name = "tiempoMaximoDataGridViewTextBoxColumn2";
            this.tiempoMaximoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.tiempoMaximoDataGridViewTextBoxColumn2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelProcesosNuevos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosBloqueadosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosTerminadosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoActualBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosListosBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProcesosNuevos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource procesosListosBS;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource procesosTerminadosBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource procesoActualBS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dato1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dato2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoMaximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoRestante;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource procesosBloqueadosBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoBloqueado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programadorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dato1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dato2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoMaximoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoRestanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoTranscurridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoFinalización;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoRetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoRespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoMaximoDataGridViewTextBoxColumn2;
    }
}

