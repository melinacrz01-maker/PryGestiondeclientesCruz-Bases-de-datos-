using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestiondeclientesCruz_Bases_de_datos_
{
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes(); //creamos el objeto x que trae el archivo (la clase) clsClientes que es donde tenemos todos los procedimientos
            Int32 IdCliente = Convert.ToInt32(txtCodigo.Text); //declaramos una variable para poder poner el txtCodigo en x.Buscar(ACA)
            x.Buscar(IdCliente);

            if (x.idCliente != 0)  //para eso en la clase pusimos idCli = 0 si cambia se muestran los datos aca
            {
                lblNombre.Text = x.Nombre;
                lblDeuda.Text = x.Deuda.ToString();
                txtLimite.Text = x.Limite.ToString();
            }
            else
            {
                lblNombre.Text = "";
                lblDeuda.Text = "";
                txtLimite.Text = "";
                MessageBox.Show("Dato no encontrado!!!");

            }
            txtLimite.ReadOnly = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void frmBusquedaCliente_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void limpiar()
        {
            txtLimite.Text = "";
            lblNombre.Text = "";
            lblDeuda.Text = "";
            txtLimite.ReadOnly = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            txtLimite.ReadOnly = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCodigo.Text);
            clsClientes x = new clsClientes();
            x.Limite = Convert.ToDecimal(txtLimite.Text);
            x.Modificar(id);
            MessageBox.Show("Dato grabado exitosamente!!");

            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCodigo.Text);
            clsClientes x = new clsClientes();
            x.Eliminar(id);
            MessageBox.Show("Dato eliminado exitosamente");

            limpiar();
        }
    }
}
