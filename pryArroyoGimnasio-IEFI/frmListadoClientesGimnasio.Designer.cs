namespace pryArroyoGimnasio_IEFI
{
    partial class frmListadoClientesGimnasio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientesGimnasio));
            this.mrcDatosClientes = new System.Windows.Forms.GroupBox();
            this.dgvDatosClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblTotalDeSaldos = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadClientes2 = new System.Windows.Forms.Label();
            this.lblPromedioSaldos2 = new System.Windows.Forms.Label();
            this.lblTotalSaldos2 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.mrcDatosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcDatosClientes
            // 
            this.mrcDatosClientes.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.mrcDatosClientes.Controls.Add(this.dgvDatosClientes);
            this.mrcDatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcDatosClientes.ForeColor = System.Drawing.Color.White;
            this.mrcDatosClientes.Location = new System.Drawing.Point(12, 12);
            this.mrcDatosClientes.Name = "mrcDatosClientes";
            this.mrcDatosClientes.Size = new System.Drawing.Size(1014, 327);
            this.mrcDatosClientes.TabIndex = 0;
            this.mrcDatosClientes.TabStop = false;
            this.mrcDatosClientes.Text = "Consulta de Datos";
            // 
            // dgvDatosClientes
            // 
            this.dgvDatosClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDatosClientes.Location = new System.Drawing.Point(6, 19);
            this.dgvDatosClientes.Name = "dgvDatosClientes";
            this.dgvDatosClientes.Size = new System.Drawing.Size(1004, 302);
            this.dgvDatosClientes.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "DNI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 240;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Barrio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Actividad";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.HeaderText = "Saldo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.ForeColor = System.Drawing.Color.White;
            this.cmdListar.Image = ((System.Drawing.Image)(resources.GetObject("cmdListar.Image")));
            this.cmdListar.Location = new System.Drawing.Point(900, 472);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(119, 27);
            this.cmdListar.TabIndex = 1;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lblTotalDeSaldos
            // 
            this.lblTotalDeSaldos.AutoSize = true;
            this.lblTotalDeSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeSaldos.ForeColor = System.Drawing.Color.White;
            this.lblTotalDeSaldos.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalDeSaldos.Image")));
            this.lblTotalDeSaldos.Location = new System.Drawing.Point(742, 440);
            this.lblTotalDeSaldos.Name = "lblTotalDeSaldos";
            this.lblTotalDeSaldos.Size = new System.Drawing.Size(119, 20);
            this.lblTotalDeSaldos.TabIndex = 2;
            this.lblTotalDeSaldos.Text = "Total de Saldos";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes.ForeColor = System.Drawing.Color.White;
            this.lblCantidadClientes.Image = ((System.Drawing.Image)(resources.GetObject("lblCantidadClientes.Image")));
            this.lblCantidadClientes.Location = new System.Drawing.Point(742, 349);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(156, 20);
            this.lblCantidadClientes.TabIndex = 3;
            this.lblCantidadClientes.Text = "Cantidad de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(742, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Promedio de saldos";
            // 
            // lblCantidadClientes2
            // 
            this.lblCantidadClientes2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadClientes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes2.Location = new System.Drawing.Point(907, 349);
            this.lblCantidadClientes2.Name = "lblCantidadClientes2";
            this.lblCantidadClientes2.Size = new System.Drawing.Size(119, 20);
            this.lblCantidadClientes2.TabIndex = 5;
            // 
            // lblPromedioSaldos2
            // 
            this.lblPromedioSaldos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioSaldos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos2.Location = new System.Drawing.Point(907, 393);
            this.lblPromedioSaldos2.Name = "lblPromedioSaldos2";
            this.lblPromedioSaldos2.Size = new System.Drawing.Size(119, 20);
            this.lblPromedioSaldos2.TabIndex = 6;
            // 
            // lblTotalSaldos2
            // 
            this.lblTotalSaldos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSaldos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldos2.Location = new System.Drawing.Point(907, 440);
            this.lblTotalSaldos2.Name = "lblTotalSaldos2";
            this.lblTotalSaldos2.Size = new System.Drawing.Size(119, 20);
            this.lblTotalSaldos2.TabIndex = 7;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.White;
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(662, 472);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(119, 27);
            this.cmdSalir.TabIndex = 8;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Enabled = false;
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.ForeColor = System.Drawing.Color.White;
            this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
            this.cmdImprimir.Location = new System.Drawing.Point(781, 472);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(119, 27);
            this.cmdImprimir.TabIndex = 9;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // frmListadoClientesGimnasio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.ClientSize = new System.Drawing.Size(1043, 510);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblTotalSaldos2);
            this.Controls.Add(this.lblPromedioSaldos2);
            this.Controls.Add(this.lblCantidadClientes2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantidadClientes);
            this.Controls.Add(this.lblTotalDeSaldos);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.mrcDatosClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoClientesGimnasio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado clientes gimnasio";
            this.Load += new System.EventHandler(this.frmListadoClientesGimnasio_Load);
            this.mrcDatosClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatosClientes;
        private System.Windows.Forms.DataGridView dgvDatosClientes;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lblTotalDeSaldos;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadClientes2;
        private System.Windows.Forms.Label lblPromedioSaldos2;
        private System.Windows.Forms.Label lblTotalSaldos2;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}