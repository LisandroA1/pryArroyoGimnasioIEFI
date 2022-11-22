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
    public partial class frmConsultaActividad : Form
    {
        public frmConsultaActividad()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaActividad_Load(object sender, EventArgs e)
        {
            clsActividad Actividad = new clsActividad();
            Actividad.CargaLstActividad(lstSeleccionActividad);

            lstSeleccionActividad.SelectedIndex = -1;
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 IdActividad = Convert.ToInt32(lstSeleccionActividad.SelectedValue);

            clsClientes BusquedaxActividad = new clsClientes();
            BusquedaxActividad.ListarClientesPorActividad(dgvDatosClientes, IdActividad);
            lblTotalSaldos2.Text = Convert.ToString(BusquedaxActividad.SaldoTotal);
            lblPromedioSaldos2.Text = Convert.ToString(BusquedaxActividad.PromedioSaldo);
            lblSaldoMayor2.Text = Convert.ToString(BusquedaxActividad.SaldoMayor);
            lblSaldoMenor2.Text = Convert.ToString(BusquedaxActividad.SaldoMenor);

            cmdExportar.Enabled = true;


        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            dgvDatosClientes.Rows.Clear();
            lblPromedioSaldos2.Text = "";
            lblSaldoMayor2.Text = "";
            lblSaldoMenor2.Text = "";
            lblTotalSaldos2.Text = "";
            Int32 IdCliente = Convert.ToInt32(lstSeleccionActividad.SelectedValue);

            clsClientes GenerarReporteActividad = new clsClientes();
            GenerarReporteActividad.reporteCliente(IdCliente);
            MessageBox.Show("Archivo generado correctamente");
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void lstSeleccionActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSeleccionActividad.SelectedIndex == -1)
            {
                cmdListar.Enabled = false;
            }
            else
            {
                cmdListar.Enabled = true;
            }
        }
    }
}
