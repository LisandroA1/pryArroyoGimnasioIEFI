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
    public partial class frmConsultaClientePorBarrio : Form
    {
        public frmConsultaClientePorBarrio()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaClientePorBarrio_Load(object sender, EventArgs e)
        {
            
       
            //Llamo a la clase ciudad 
            clsBarrio Barrio = new clsBarrio();
            //llamo el procedimiento CargaBarrio y le envio el combobox
            Barrio.CargaLstBarrio(lstSeleccionBarrio);

            lstSeleccionBarrio.SelectedIndex = -1;
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 IdBarrio = Convert.ToInt32(lstSeleccionBarrio.SelectedValue);
            
            clsClientes BusquedaxBarrio = new clsClientes();
            BusquedaxBarrio.ListarClientesPorBarrio(dgvDatosClientes, IdBarrio);

            
        }

        private void lstSeleccionBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSeleccionBarrio.SelectedIndex == -1)
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
