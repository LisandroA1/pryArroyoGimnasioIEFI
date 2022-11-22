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
    public partial class frmBusquedaCliente : Form
    {

        clsBarrio objBarrio = new clsBarrio();
        clsActividad objActividad = new clsActividad();
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 IdCliente = Convert.ToInt32(mskDNICliente.Text);
            clsClientes Clientes = new clsClientes();
            Clientes.Buscar(IdCliente);
            if (Clientes.DniCliente != IdCliente)
            {
                MessageBox.Show("El cliente no se encuentra registrado");
                mskDNICliente.Text = "";
            }
            else
            {
                txtNombreyApellido.Text = Clientes.NombreyApellidoCliente;
                txtDireccion.Text = Clientes.DireccionCliente;
                mskSaldo.Text = Convert.ToString(Clientes.SaldoCliente);

                objBarrio.BuscarBarrio(Clientes.CodigoBarrioCliente);
                lstBarrio.Text = objBarrio.NombreBarrio;

                objActividad.BuscarActivid(Clientes.ActividadCliente);
                lstActividad.Text = objActividad.NombreActividad;
                
               

                
            }
            
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            
            cmdEliminar.Enabled = false;
            cmdActualizar.Enabled = false;
            cmdGuardar.Enabled = true;
            txtNombreyApellido.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            lstActividad.Enabled = true;
            lstBarrio.Enabled = true;
            mskSaldo.ReadOnly = false;


            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            
            Limpiar();
            
            Int32 DniCliente = Convert.ToInt32(mskDNICliente.Text);
            clsClientes ECliente = new clsClientes();
            ECliente.EliminarCliente(DniCliente);
            txtNombreyApellido.Text = "";
            lstActividad.SelectedIndex = -1;
            lstBarrio.SelectedIndex = -1;
            txtDireccion.Text = "";
            mskDNICliente.Text = "";
            mskSaldo.Text = "";
        }

        private void frmBusquedaCliente_Load(object sender, EventArgs e)
        {
            clsBarrio Barrio = new clsBarrio();
            Barrio.CargaLstBarrio(lstBarrio);

            clsActividad Actividad = new clsActividad();
            Actividad.CargaLstActividad(lstActividad);

            lstActividad.SelectedIndex = -1;
            lstBarrio.SelectedIndex = -1;
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombreyApellido.Text = "";
            txtDireccion.Text = "";
            
            mskSaldo.Text = "";
            txtNombreyApellido.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            lstBarrio.Enabled = false;
            lstActividad.Enabled = false;
            mskSaldo.ReadOnly = true;
            cmdEliminar.Enabled = false;
            cmdActualizar.Enabled = false;
            cmdGuardar.Enabled = false;

        }

        private void Habilitar()
        {
            if (txtNombreyApellido.Text == "" && txtDireccion.Text == ""  && mskSaldo.Text == "")
            {
                cmdActualizar.Enabled = false;
                cmdEliminar.Enabled = false;
            }
            else
            {
                cmdActualizar.Enabled = true;
                cmdEliminar.Enabled = true;
            }
        }

        private void mskDNICliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskDNICliente.Text != "")
            {
                cmdConsultar.Enabled = true;
            }
            else
            {
                cmdConsultar.Enabled = false;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Int32 DniCliente = Convert.ToInt32(mskDNICliente.Text);
            string NombreyApellido = txtNombreyApellido.Text;
            string DireccionCliente = txtDireccion.Text;
            Int32 Barrio = Convert.ToInt32(lstBarrio.SelectedValue);
            Int32 Actividad = Convert.ToInt32(lstActividad.SelectedValue);
            Int32 Saldo = Convert.ToInt32(mskSaldo.Text);

            clsClientes ECliente = new clsClientes();
            ECliente.NombreyApellidoCliente = NombreyApellido;
            ECliente.DireccionCliente = DireccionCliente;
            ECliente.CodigoBarrioCliente = Barrio;
            ECliente.ActividadCliente = Actividad;
            ECliente.SaldoCliente = Saldo;
            ECliente.DniCliente = DniCliente;
            ECliente.ModificarCliente(DniCliente);

            txtNombreyApellido.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtDireccion.Text = "";
            mskDNICliente.Text = "";
            mskSaldo.Text = "";
            MessageBox.Show("Cliente modificado con exito");
            Limpiar();
        }

        private void txtNombreyApellido_TextChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void txtBarrio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtActividad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mskSaldo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Habilitar();
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

        private void txtBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo se permiten letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtActividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo se permiten letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
