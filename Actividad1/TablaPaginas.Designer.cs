namespace Actividad1
{
    partial class TablaPaginas
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
            this.marcoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoriaUsadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProcesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.memoriaUsadaDataGridViewTextBoxColumn,
            this.idProcesoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.marcoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(419, 539);
            this.dataGridView1.TabIndex = 0;
            // 
            // marcoBindingSource
            // 
            this.marcoBindingSource.DataSource = typeof(Actividad1.Marco);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id Marco";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memoriaUsadaDataGridViewTextBoxColumn
            // 
            this.memoriaUsadaDataGridViewTextBoxColumn.DataPropertyName = "MemoriaUsada";
            this.memoriaUsadaDataGridViewTextBoxColumn.HeaderText = "Memoria y Estado";
            this.memoriaUsadaDataGridViewTextBoxColumn.Name = "memoriaUsadaDataGridViewTextBoxColumn";
            this.memoriaUsadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoriaUsadaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idProcesoDataGridViewTextBoxColumn
            // 
            this.idProcesoDataGridViewTextBoxColumn.DataPropertyName = "IdProceso";
            this.idProcesoDataGridViewTextBoxColumn.HeaderText = "Id Proceso";
            this.idProcesoDataGridViewTextBoxColumn.Name = "idProcesoDataGridViewTextBoxColumn";
            this.idProcesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TablaPaginas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 539);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablaPaginas";
            this.Text = "TablaPaginas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource marcoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoriaUsadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProcesoDataGridViewTextBoxColumn;
    }
}