namespace pryArroyoGimnasio_IEFI
{
    partial class frmConsultaActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaActividad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblConsultaActividad = new System.Windows.Forms.Label();
            this.lstSeleccionActividad = new System.Windows.Forms.ComboBox();
            this.mrcDatosClientes = new System.Windows.Forms.GroupBox();
            this.dgvDatosClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.lblPromedioSaldos2 = new System.Windows.Forms.Label();
            this.lblSaldoMenor2 = new System.Windows.Forms.Label();
            this.lblSaldoMayor2 = new System.Windows.Forms.Label();
            this.lblSaldoMenor = new System.Windows.Forms.Label();
            this.lblSaldoMayor = new System.Windows.Forms.Label();
            this.lblProemdiosSaldos = new System.Windows.Forms.Label();
            this.lblTotalSaldos = new System.Windows.Forms.Label();
            this.lblTotalSaldos2 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mrcDatosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaActividad
            // 
            this.lblConsultaActividad.AutoSize = true;
            this.lblConsultaActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaActividad.ForeColor = System.Drawing.Color.White;
            this.lblConsultaActividad.Image = ((System.Drawing.Image)(resources.GetObject("lblConsultaActividad.Image")));
            this.lblConsultaActividad.Location = new System.Drawing.Point(12, 16);
            this.lblConsultaActividad.Name = "lblConsultaActividad";
            this.lblConsultaActividad.Size = new System.Drawing.Size(184, 20);
            this.lblConsultaActividad.TabIndex = 4;
            this.lblConsultaActividad.Text = "Seleccione una actividad";
            // 
            // lstSeleccionActividad
            // 
            this.lstSeleccionActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSeleccionActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSeleccionActividad.FormattingEnabled = true;
            this.lstSeleccionActividad.Location = new System.Drawing.Point(202, 12);
            this.lstSeleccionActividad.Name = "lstSeleccionActividad";
            this.lstSeleccionActividad.Size = new System.Drawing.Size(523, 24);
            this.lstSeleccionActividad.TabIndex = 5;
            this.lstSeleccionActividad.SelectedIndexChanged += new System.EventHandler(this.lstSeleccionActividad_SelectedIndexChanged);
            // 
            // mrcDatosClientes
            // 
            this.mrcDatosClientes.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.mrcDatosClientes.Controls.Add(this.dgvDatosClientes);
            this.mrcDatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcDatosClientes.ForeColor = System.Drawing.Color.White;
            this.mrcDatosClientes.Location = new System.Drawing.Point(12, 51);
            this.mrcDatosClientes.Name = "mrcDatosClientes";
            this.mrcDatosClientes.Size = new System.Drawing.Size(713, 233);
            this.mrcDatosClientes.TabIndex = 6;
            this.mrcDatosClientes.TabStop = false;
            this.mrcDatosClientes.Text = "Datos Clientes";
            // 
            // dgvDatosClientes
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvDatosClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatosClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvDatosClientes.Location = new System.Drawing.Point(6, 25);
            this.dgvDatosClientes.Name = "dgvDatosClientes";
            this.dgvDatosClientes.Size = new System.Drawing.Size(695, 193);
            this.dgvDatosClientes.TabIndex = 1;
            // 
            // Column1
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column1.HeaderText = "DNI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 240;
            // 
            // Column3
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column5
            // 
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column5.HeaderText = "Saldo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.ForeColor = System.Drawing.Color.White;
            this.cmdListar.Image = ((System.Drawing.Image)(resources.GetObject("cmdListar.Image")));
            this.cmdListar.Location = new System.Drawing.Point(638, 474);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(86, 27);
            this.cmdListar.TabIndex = 7;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // cmdExportar
            // 
            this.cmdExportar.Enabled = false;
            this.cmdExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.ForeColor = System.Drawing.Color.White;
            this.cmdExportar.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.Image")));
            this.cmdExportar.Location = new System.Drawing.Point(546, 474);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(86, 27);
            this.cmdExportar.TabIndex = 9;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // lblPromedioSaldos2
            // 
            this.lblPromedioSaldos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioSaldos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos2.Location = new System.Drawing.Point(565, 388);
            this.lblPromedioSaldos2.Name = "lblPromedioSaldos2";
            this.lblPromedioSaldos2.Size = new System.Drawing.Size(160, 20);
            this.lblPromedioSaldos2.TabIndex = 15;
            // 
            // lblSaldoMenor2
            // 
            this.lblSaldoMenor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldoMenor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMenor2.Location = new System.Drawing.Point(565, 341);
            this.lblSaldoMenor2.Name = "lblSaldoMenor2";
            this.lblSaldoMenor2.Size = new System.Drawing.Size(160, 20);
            this.lblSaldoMenor2.TabIndex = 14;
            // 
            // lblSaldoMayor2
            // 
            this.lblSaldoMayor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldoMayor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMayor2.Location = new System.Drawing.Point(565, 296);
            this.lblSaldoMayor2.Name = "lblSaldoMayor2";
            this.lblSaldoMayor2.Size = new System.Drawing.Size(160, 20);
            this.lblSaldoMayor2.TabIndex = 13;
            // 
            // lblSaldoMenor
            // 
            this.lblSaldoMenor.AutoSize = true;
            this.lblSaldoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMenor.ForeColor = System.Drawing.Color.White;
            this.lblSaldoMenor.Image = ((System.Drawing.Image)(resources.GetObject("lblSaldoMenor.Image")));
            this.lblSaldoMenor.Location = new System.Drawing.Point(349, 341);
            this.lblSaldoMenor.Name = "lblSaldoMenor";
            this.lblSaldoMenor.Size = new System.Drawing.Size(99, 20);
            this.lblSaldoMenor.TabIndex = 12;
            this.lblSaldoMenor.Text = "Saldo Menor";
            // 
            // lblSaldoMayor
            // 
            this.lblSaldoMayor.AutoSize = true;
            this.lblSaldoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMayor.ForeColor = System.Drawing.Color.White;
            this.lblSaldoMayor.Image = ((System.Drawing.Image)(resources.GetObject("lblSaldoMayor.Image")));
            this.lblSaldoMayor.Location = new System.Drawing.Point(349, 297);
            this.lblSaldoMayor.Name = "lblSaldoMayor";
            this.lblSaldoMayor.Size = new System.Drawing.Size(97, 20);
            this.lblSaldoMayor.TabIndex = 11;
            this.lblSaldoMayor.Text = "Saldo Mayor";
            // 
            // lblProemdiosSaldos
            // 
            this.lblProemdiosSaldos.AutoSize = true;
            this.lblProemdiosSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProemdiosSaldos.ForeColor = System.Drawing.Color.White;
            this.lblProemdiosSaldos.Image = ((System.Drawing.Image)(resources.GetObject("lblProemdiosSaldos.Image")));
            this.lblProemdiosSaldos.Location = new System.Drawing.Point(349, 388);
            this.lblProemdiosSaldos.Name = "lblProemdiosSaldos";
            this.lblProemdiosSaldos.Size = new System.Drawing.Size(148, 20);
            this.lblProemdiosSaldos.TabIndex = 10;
            this.lblProemdiosSaldos.Text = "Promedio de saldos";
            // 
            // lblTotalSaldos
            // 
            this.lblTotalSaldos.AutoSize = true;
            this.lblTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldos.ForeColor = System.Drawing.Color.White;
            this.lblTotalSaldos.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalSaldos.Image")));
            this.lblTotalSaldos.Location = new System.Drawing.Point(349, 435);
            this.lblTotalSaldos.Name = "lblTotalSaldos";
            this.lblTotalSaldos.Size = new System.Drawing.Size(119, 20);
            this.lblTotalSaldos.TabIndex = 16;
            this.lblTotalSaldos.Text = "Total de Saldos";
            // 
            // lblTotalSaldos2
            // 
            this.lblTotalSaldos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSaldos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldos2.Location = new System.Drawing.Point(565, 434);
            this.lblTotalSaldos2.Name = "lblTotalSaldos2";
            this.lblTotalSaldos2.Size = new System.Drawing.Size(160, 20);
            this.lblTotalSaldos2.TabIndex = 17;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.White;
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(454, 474);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(86, 27);
            this.cmdSalir.TabIndex = 18;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmConsultaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.ClientSize = new System.Drawing.Size(738, 513);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblTotalSaldos2);
            this.Controls.Add(this.lblTotalSaldos);
            this.Controls.Add(this.lblPromedioSaldos2);
            this.Controls.Add(this.lblSaldoMenor2);
            this.Controls.Add(this.lblSaldoMayor2);
            this.Controls.Add(this.lblSaldoMenor);
            this.Controls.Add(this.lblSaldoMayor);
            this.Controls.Add(this.lblProemdiosSaldos);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.mrcDatosClientes);
            this.Controls.Add(this.lstSeleccionActividad);
            this.Controls.Add(this.lblConsultaActividad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Actividad";
            this.Load += new System.EventHandler(this.frmConsultaActividad_Load);
            this.mrcDatosClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaActividad;
        private System.Windows.Forms.ComboBox lstSeleccionActividad;
        private System.Windows.Forms.GroupBox mrcDatosClientes;
        private System.Windows.Forms.DataGridView dgvDatosClientes;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.Label lblPromedioSaldos2;
        private System.Windows.Forms.Label lblSaldoMenor2;
        private System.Windows.Forms.Label lblSaldoMayor2;
        private System.Windows.Forms.Label lblSaldoMenor;
        private System.Windows.Forms.Label lblSaldoMayor;
        private System.Windows.Forms.Label lblProemdiosSaldos;
        private System.Windows.Forms.Label lblTotalSaldos;
        private System.Windows.Forms.Label lblTotalSaldos2;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}