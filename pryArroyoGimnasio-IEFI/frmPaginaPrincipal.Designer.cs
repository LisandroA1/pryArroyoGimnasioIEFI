namespace pryArroyoGimnasio_IEFI
{
    partial class frmPaginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaginaPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mnuGimnasio = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsp2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsp3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGimnasio.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(940, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mnuGimnasio
            // 
            this.mnuGimnasio.BackColor = System.Drawing.Color.Gray;
            this.mnuGimnasio.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.mnuGimnasio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnuGimnasio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mnuGimnasio.Location = new System.Drawing.Point(0, 0);
            this.mnuGimnasio.Name = "mnuGimnasio";
            this.mnuGimnasio.Size = new System.Drawing.Size(940, 24);
            this.mnuGimnasio.TabIndex = 1;
            this.mnuGimnasio.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.tsp1,
            this.buscarClienteToolStripMenuItem,
            this.tsp2,
            this.consultarActividadToolStripMenuItem,
            this.consultarClienteToolStripMenuItem,
            this.tsp3,
            this.listadoDeTodosLosClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.nuevoClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.buscarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.consultarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consulta cliente por barrio";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.listadoDeTodosLosClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // consultarActividadToolStripMenuItem
            // 
            this.consultarActividadToolStripMenuItem.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.consultarActividadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultarActividadToolStripMenuItem.Name = "consultarActividadToolStripMenuItem";
            this.consultarActividadToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.consultarActividadToolStripMenuItem.Text = "Consulta clientes por actividad";
            this.consultarActividadToolStripMenuItem.Click += new System.EventHandler(this.consultarActividadToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_para_barra;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsp1
            // 
            this.tsp1.AutoSize = false;
            this.tsp1.BackColor = System.Drawing.Color.White;
            this.tsp1.ForeColor = System.Drawing.Color.White;
            this.tsp1.Name = "tsp1";
            this.tsp1.Size = new System.Drawing.Size(233, 2);
            // 
            // tsp2
            // 
            this.tsp2.AutoSize = false;
            this.tsp2.Name = "tsp2";
            this.tsp2.Size = new System.Drawing.Size(233, 2);
            // 
            // tsp3
            // 
            this.tsp3.AutoSize = false;
            this.tsp3.Name = "tsp3";
            this.tsp3.Size = new System.Drawing.Size(233, 2);
            // 
            // frmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pryArroyoGimnasio_IEFI.Properties.Resources.fondo_inicio_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(940, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuGimnasio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuGimnasio;
            this.Name = "frmPaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio";
            this.mnuGimnasio.ResumeLayout(false);
            this.mnuGimnasio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip mnuGimnasio;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tsp1;
        private System.Windows.Forms.ToolStripSeparator tsp2;
        private System.Windows.Forms.ToolStripSeparator tsp3;
    }
}

