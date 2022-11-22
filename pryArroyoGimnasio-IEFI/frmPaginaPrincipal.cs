using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArroyoGimnasio_IEFI
{
    public partial class frmPaginaPrincipal : Form
    {
        public frmPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientesGimnasio newfrmListadoClientesGimnasio = new frmListadoClientesGimnasio();
            newfrmListadoClientesGimnasio.ShowDialog();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroClientes newRegistroCliente = new frmRegistroClientes();
            newRegistroCliente.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente newBusquedaCliente = new frmBusquedaCliente();
            newBusquedaCliente.ShowDialog();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientePorBarrio newclientePorBarrio = new frmConsultaClientePorBarrio();
            newclientePorBarrio.ShowDialog();
        }

        private void consultarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaActividad newfrmConsultaActividad = new frmConsultaActividad();
            newfrmConsultaActividad.ShowDialog();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
