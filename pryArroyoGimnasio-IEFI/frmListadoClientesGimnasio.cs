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
    public partial class frmListadoClientesGimnasio : Form
    {
        
        public frmListadoClientesGimnasio()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsClientes ListarTodos = new clsClientes();
            ListarTodos.ListarTodosLosClientes(dgvDatosClientes);
            lblCantidadClientes2.Text = Convert.ToString(ListarTodos.CantidadClientes);
            lblTotalSaldos2.Text = Convert.ToString(ListarTodos.SaldoTotal);
            lblPromedioSaldos2.Text = Convert.ToString(ListarTodos.PromedioSaldo);

            

            cmdImprimir.Enabled = true;
        }

        private void frmListadoClientesGimnasio_Load(object sender, EventArgs e)
        {

        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            //Asignamos a prtDocumento la impresora que seleccionamos en la ventana
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            //Indico que el documento debe ser impreso
            prtDocumento.Print();

            MessageBox.Show("Documento impreso con exito"); 
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs Reporte)
        {
            clsClientes objCliente = new clsClientes();
            objCliente.Imprimir(Reporte);
        }
    }
}
