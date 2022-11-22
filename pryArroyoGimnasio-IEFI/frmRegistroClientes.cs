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
    public partial class frmRegistroClientes : Form
    {
        public frmRegistroClientes()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistroClientes_Load(object sender, EventArgs e)
        {
            clsBarrio Barrio = new clsBarrio();
            Barrio.CargaLstBarrio(lstBarrio);

            clsActividad Actividad = new clsActividad();
            Actividad.CargaLstActividad(lstActividad);

            lstActividad.SelectedIndex = -1;
            lstBarrio.SelectedIndex = -1;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            Inhabilitar();
            Int32 DNI = Convert.ToInt32(mskDNICliente.Text);
            clsClientes Clientes = new clsClientes();
            Clientes.Buscar(DNI);

            if (Clientes.DniCliente != DNI)
            {
                Clientes.DniCliente = Convert.ToInt32(mskDNICliente.Text);
                Clientes.NombreyApellidoCliente = txtNombreyApellido.Text;
                Clientes.DireccionCliente = txtDireccion.Text;
                Clientes.CodigoBarrioCliente = Convert.ToInt32(lstBarrio.SelectedValue);
                Clientes.ActividadCliente = Convert.ToInt32(lstActividad.SelectedValue);
                Clientes.SaldoCliente = Convert.ToInt32(txtSaldo.Text);
                Clientes.AgregarNuevoCliente();
                MessageBox.Show("Cliente registrado con exito");
                mskDNICliente.Text = "";
                txtNombreyApellido.Text = "";
                txtDireccion.Text = "";
                lstBarrio.SelectedIndex = -1;
                lstActividad.SelectedIndex = -1;
                txtSaldo.Text = "";
            }
            else
            {
                MessageBox.Show("El cliente ya se encuentra registrado");
                mskDNICliente.Text = "";
                txtNombreyApellido.Text = "";
                txtDireccion.Text = "";
                lstBarrio.SelectedIndex = -1;
                lstActividad.SelectedIndex = -1;
                txtSaldo.Text = "";
            }

            
            

        }

        private void Inhabilitar()
        {
            if (mskDNICliente.Text != "" && txtNombreyApellido.Text != "" && txtDireccion.Text != "" && txtSaldo.Text != "" && lstBarrio.SelectedIndex != -1 && lstActividad.SelectedIndex != -1)
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
                cmdRegistrar.Enabled = false;
            }
        }

        private void mskDNICliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Inhabilitar();
        }

        private void txtNombreyApellido_TextChanged(object sender, EventArgs e)
        {
            Inhabilitar();
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Inhabilitar();
           
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            Inhabilitar();
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

            Inhabilitar();
            
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {

            Inhabilitar();
        }

        private void txtNombreyApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo se permiten letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
