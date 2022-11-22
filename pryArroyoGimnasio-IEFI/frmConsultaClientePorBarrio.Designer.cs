namespace pryArroyoGimnasio_IEFI
{
    partial class frmConsultaClientePorBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaClientePorBarrio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstSeleccionBarrio = new System.Windows.Forms.ComboBox();
            this.lblConsultaBarrio = new System.Windows.Forms.Label();
            this.mrcDatosClientes = new System.Windows.Forms.GroupBox();
            this.dgvDatosClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mrcDatosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSeleccionBarrio
            // 
            this.lstSeleccionBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSeleccionBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSeleccionBarrio.FormattingEnabled = true;
            this.lstSeleccionBarrio.Location = new System.Drawing.Point(166, 18);
            this.lstSeleccionBarrio.Name = "lstSeleccionBarrio";
            this.lstSeleccionBarrio.Size = new System.Drawing.Size(557, 24);
            this.lstSeleccionBarrio.TabIndex = 7;
            this.lstSeleccionBarrio.SelectedIndexChanged += new System.EventHandler(this.lstSeleccionBarrio_SelectedIndexChanged);
            // 
            // lblConsultaBarrio
            // 
            this.lblConsultaBarrio.AutoSize = true;
            this.lblConsultaBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaBarrio.ForeColor = System.Drawing.Color.White;
            this.lblConsultaBarrio.Image = ((System.Drawing.Image)(resources.GetObject("lblConsultaBarrio.Image")));
            this.lblConsultaBarrio.Location = new System.Drawing.Point(7, 22);
            this.lblConsultaBarrio.Name = "lblConsultaBarrio";
            this.lblConsultaBarrio.Size = new System.Drawing.Size(153, 20);
            this.lblConsultaBarrio.TabIndex = 6;
            this.lblConsultaBarrio.Text = "Seleccione un barrio";
            // 
            // mrcDatosClientes
            // 
            this.mrcDatosClientes.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.mrcDatosClientes.Controls.Add(this.dgvDatosClientes);
            this.mrcDatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcDatosClientes.ForeColor = System.Drawing.Color.White;
            this.mrcDatosClientes.Location = new System.Drawing.Point(12, 60);
            this.mrcDatosClientes.Name = "mrcDatosClientes";
            this.mrcDatosClientes.Size = new System.Drawing.Size(711, 283);
            this.mrcDatosClientes.TabIndex = 8;
            this.mrcDatosClientes.TabStop = false;
            this.mrcDatosClientes.Text = "Datos Clientes";
            // 
            // dgvDatosClientes
            // 
            this.dgvDatosClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvDatosClientes.GridColor = System.Drawing.Color.Black;
            this.dgvDatosClientes.Location = new System.Drawing.Point(6, 25);
            this.dgvDatosClientes.Name = "dgvDatosClientes";
            this.dgvDatosClientes.Size = new System.Drawing.Size(693, 242);
            this.dgvDatosClientes.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.HeaderText = "Dni";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            this.Column2.Width = 240;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column5.HeaderText = "Saldo";
            this.Column5.Name = "Column5";
            // 
            // cmdListar
            // 
            this.cmdListar.Enabled = false;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.ForeColor = System.Drawing.Color.White;
            this.cmdListar.Image = ((System.Drawing.Image)(resources.GetObject("cmdListar.Image")));
            this.cmdListar.Location = new System.Drawing.Point(637, 346);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(86, 27);
            this.cmdListar.TabIndex = 9;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.White;
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(545, 346);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(86, 27);
            this.cmdSalir.TabIndex = 10;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmConsultaClientePorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.ClientSize = new System.Drawing.Size(739, 383);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.mrcDatosClientes);
            this.Controls.Add(this.lstSeleccionBarrio);
            this.Controls.Add(this.lblConsultaBarrio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaClientePorBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta cliente por barrio";
            this.Load += new System.EventHandler(this.frmConsultaClientePorBarrio_Load);
            this.mrcDatosClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstSeleccionBarrio;
        private System.Windows.Forms.Label lblConsultaBarrio;
        private System.Windows.Forms.GroupBox mrcDatosClientes;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridView dgvDatosClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}