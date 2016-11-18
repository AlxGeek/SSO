namespace Actividad1
{
    partial class BCP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.programadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dato1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dato2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoLlegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoFinalizaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoRetornoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoEsperaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoRestanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoRespuestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoTranscurridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoBloqueadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programadorDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.Estado,
            this.operacionDataGridViewTextBoxColumn,
            this.dato1DataGridViewTextBoxColumn,
            this.dato2DataGridViewTextBoxColumn,
            this.resultadoDataGridViewTextBoxColumn,
            this.tiempoLlegadaDataGridViewTextBoxColumn,
            this.tiempoFinalizaciónDataGridViewTextBoxColumn,
            this.tiempoRetornoDataGridViewTextBoxColumn,
            this.tiempoEsperaDataGridViewTextBoxColumn,
            this.tiempoServicioDataGridViewTextBoxColumn,
            this.tiempoRestanteDataGridViewTextBoxColumn,
            this.tiempoRespuestaDataGridViewTextBoxColumn,
            this.tiempoMaximoDataGridViewTextBoxColumn,
            this.tiempoTranscurridoDataGridViewTextBoxColumn,
            this.loteDataGridViewTextBoxColumn,
            this.tiempoBloqueadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.procesoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // programadorDataGridViewTextBoxColumn
            // 
            this.programadorDataGridViewTextBoxColumn.DataPropertyName = "Programador";
            this.programadorDataGridViewTextBoxColumn.HeaderText = "Programador";
            this.programadorDataGridViewTextBoxColumn.Name = "programadorDataGridViewTextBoxColumn";
            this.programadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.programadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // operacionDataGridViewTextBoxColumn
            // 
            this.operacionDataGridViewTextBoxColumn.DataPropertyName = "Operacion";
            this.operacionDataGridViewTextBoxColumn.HeaderText = "Operacion";
            this.operacionDataGridViewTextBoxColumn.Name = "operacionDataGridViewTextBoxColumn";
            this.operacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.operacionDataGridViewTextBoxColumn.Width = 50;
            // 
            // dato1DataGridViewTextBoxColumn
            // 
            this.dato1DataGridViewTextBoxColumn.DataPropertyName = "Dato1";
            this.dato1DataGridViewTextBoxColumn.HeaderText = "Dato1";
            this.dato1DataGridViewTextBoxColumn.Name = "dato1DataGridViewTextBoxColumn";
            this.dato1DataGridViewTextBoxColumn.ReadOnly = true;
            this.dato1DataGridViewTextBoxColumn.Width = 70;
            // 
            // dato2DataGridViewTextBoxColumn
            // 
            this.dato2DataGridViewTextBoxColumn.DataPropertyName = "Dato2";
            this.dato2DataGridViewTextBoxColumn.HeaderText = "Dato2";
            this.dato2DataGridViewTextBoxColumn.Name = "dato2DataGridViewTextBoxColumn";
            this.dato2DataGridViewTextBoxColumn.ReadOnly = true;
            this.dato2DataGridViewTextBoxColumn.Width = 70;
            // 
            // resultadoDataGridViewTextBoxColumn
            // 
            this.resultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.HeaderText = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.Name = "resultadoDataGridViewTextBoxColumn";
            this.resultadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoLlegadaDataGridViewTextBoxColumn
            // 
            this.tiempoLlegadaDataGridViewTextBoxColumn.DataPropertyName = "TiempoLlegada";
            this.tiempoLlegadaDataGridViewTextBoxColumn.HeaderText = "TiempoLlegada";
            this.tiempoLlegadaDataGridViewTextBoxColumn.Name = "tiempoLlegadaDataGridViewTextBoxColumn";
            this.tiempoLlegadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoFinalizaciónDataGridViewTextBoxColumn
            // 
            this.tiempoFinalizaciónDataGridViewTextBoxColumn.DataPropertyName = "TiempoFinalización";
            this.tiempoFinalizaciónDataGridViewTextBoxColumn.HeaderText = "TiempoFinalización";
            this.tiempoFinalizaciónDataGridViewTextBoxColumn.Name = "tiempoFinalizaciónDataGridViewTextBoxColumn";
            this.tiempoFinalizaciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoRetornoDataGridViewTextBoxColumn
            // 
            this.tiempoRetornoDataGridViewTextBoxColumn.DataPropertyName = "TiempoRetorno";
            this.tiempoRetornoDataGridViewTextBoxColumn.HeaderText = "TiempoRetorno";
            this.tiempoRetornoDataGridViewTextBoxColumn.Name = "tiempoRetornoDataGridViewTextBoxColumn";
            this.tiempoRetornoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoEsperaDataGridViewTextBoxColumn
            // 
            this.tiempoEsperaDataGridViewTextBoxColumn.DataPropertyName = "TiempoEspera";
            this.tiempoEsperaDataGridViewTextBoxColumn.HeaderText = "TiempoEspera";
            this.tiempoEsperaDataGridViewTextBoxColumn.Name = "tiempoEsperaDataGridViewTextBoxColumn";
            this.tiempoEsperaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoServicioDataGridViewTextBoxColumn
            // 
            this.tiempoServicioDataGridViewTextBoxColumn.DataPropertyName = "TiempoServicio";
            this.tiempoServicioDataGridViewTextBoxColumn.HeaderText = "TiempoServicio";
            this.tiempoServicioDataGridViewTextBoxColumn.Name = "tiempoServicioDataGridViewTextBoxColumn";
            this.tiempoServicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoRestanteDataGridViewTextBoxColumn
            // 
            this.tiempoRestanteDataGridViewTextBoxColumn.DataPropertyName = "TiempoRestante";
            this.tiempoRestanteDataGridViewTextBoxColumn.HeaderText = "TiempoRestante";
            this.tiempoRestanteDataGridViewTextBoxColumn.Name = "tiempoRestanteDataGridViewTextBoxColumn";
            this.tiempoRestanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiempoRestanteDataGridViewTextBoxColumn.Visible = false;
            // 
            // tiempoRespuestaDataGridViewTextBoxColumn
            // 
            this.tiempoRespuestaDataGridViewTextBoxColumn.DataPropertyName = "TiempoRespuesta";
            this.tiempoRespuestaDataGridViewTextBoxColumn.HeaderText = "TiempoRespuesta";
            this.tiempoRespuestaDataGridViewTextBoxColumn.Name = "tiempoRespuestaDataGridViewTextBoxColumn";
            this.tiempoRespuestaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoMaximoDataGridViewTextBoxColumn
            // 
            this.tiempoMaximoDataGridViewTextBoxColumn.DataPropertyName = "TiempoMaximo";
            this.tiempoMaximoDataGridViewTextBoxColumn.HeaderText = "TiempoMaximo";
            this.tiempoMaximoDataGridViewTextBoxColumn.Name = "tiempoMaximoDataGridViewTextBoxColumn";
            this.tiempoMaximoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiempoMaximoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tiempoTranscurridoDataGridViewTextBoxColumn
            // 
            this.tiempoTranscurridoDataGridViewTextBoxColumn.DataPropertyName = "TiempoTranscurrido";
            this.tiempoTranscurridoDataGridViewTextBoxColumn.HeaderText = "TiempoTranscurrido";
            this.tiempoTranscurridoDataGridViewTextBoxColumn.Name = "tiempoTranscurridoDataGridViewTextBoxColumn";
            this.tiempoTranscurridoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiempoTranscurridoDataGridViewTextBoxColumn.Visible = false;
            // 
            // loteDataGridViewTextBoxColumn
            // 
            this.loteDataGridViewTextBoxColumn.DataPropertyName = "Lote";
            this.loteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.loteDataGridViewTextBoxColumn.Name = "loteDataGridViewTextBoxColumn";
            this.loteDataGridViewTextBoxColumn.ReadOnly = true;
            this.loteDataGridViewTextBoxColumn.Visible = false;
            // 
            // tiempoBloqueadoDataGridViewTextBoxColumn
            // 
            this.tiempoBloqueadoDataGridViewTextBoxColumn.DataPropertyName = "TiempoBloqueado";
            this.tiempoBloqueadoDataGridViewTextBoxColumn.HeaderText = "TiempoBloqueado";
            this.tiempoBloqueadoDataGridViewTextBoxColumn.Name = "tiempoBloqueadoDataGridViewTextBoxColumn";
            this.tiempoBloqueadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiempoBloqueadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // procesoBindingSource
            // 
            this.procesoBindingSource.DataSource = typeof(Actividad1.Proceso);
            // 
            // BCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 530);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BCP";
            this.Text = "BCP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource procesoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn programadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dato1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dato2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoLlegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoFinalizaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoRetornoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoEsperaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoRestanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoRespuestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoMaximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoTranscurridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoBloqueadoDataGridViewTextBoxColumn;
    }
}