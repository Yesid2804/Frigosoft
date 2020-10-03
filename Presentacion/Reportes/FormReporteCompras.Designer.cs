namespace Presentacion.Reportes
{
    partial class FormReporteCompras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboxFiltroFechas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(340, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Compras";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.comboxFiltroFechas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(63, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // comboxFiltroFechas
            // 
            this.comboxFiltroFechas.FormattingEnabled = true;
            this.comboxFiltroFechas.Items.AddRange(new object[] {
            "Dia",
            "Mes",
            "Año"});
            this.comboxFiltroFechas.Location = new System.Drawing.Point(88, 12);
            this.comboxFiltroFechas.Name = "comboxFiltroFechas";
            this.comboxFiltroFechas.Size = new System.Drawing.Size(130, 23);
            this.comboxFiltroFechas.TabIndex = 1;
            this.comboxFiltroFechas.Text = "Semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar por";
            // 
            // columnFecha
            // 
            this.columnFecha.HeaderText = "Column1";
            this.columnFecha.Name = "columnFecha";
            // 
            // columnProveedor
            // 
            this.columnProveedor.HeaderText = "Proveedor";
            this.columnProveedor.Name = "columnProveedor";
            this.columnProveedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnProveedor.Width = 120;
            // 
            // columnProducto
            // 
            this.columnProducto.HeaderText = "Producto";
            this.columnProducto.Name = "columnProducto";
            this.columnProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnProducto.Width = 120;
            // 
            // columnCantidad
            // 
            this.columnCantidad.HeaderText = "Cantidad";
            this.columnCantidad.Name = "columnCantidad";
            this.columnCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnCantidad.Width = 120;
            // 
            // columnTotalCompra
            // 
            this.columnTotalCompra.HeaderText = "Total Compra";
            this.columnTotalCompra.Name = "columnTotalCompra";
            this.columnTotalCompra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnTotalCompra.Width = 120;
            // 
            // columnsFecha
            // 
            this.columnsFecha.HeaderText = "Fecha";
            this.columnsFecha.Name = "columnsFecha";
            this.columnsFecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnsFecha.Width = 120;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProveedor,
            this.columnProducto,
            this.columnCantidad,
            this.columnTotalCompra,
            this.columnsFecha});
            this.dataGridView1.Location = new System.Drawing.Point(63, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 225);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // FormReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteCompras";
            this.Text = "FormReporteCompras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboxFiltroFechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsFecha;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}