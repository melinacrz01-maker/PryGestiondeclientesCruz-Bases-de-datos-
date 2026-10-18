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
            clsClientes x = new clsClientes();

            Int32 cliente = Convert.ToInt32(txtCodigo.Text);
            x.Buscar(cliente);

            if(x.idCliente != 0)
            {
                lblNombre.Text = x.Nombre;
                lblDeuda.Text = x.Deuda.ToString();
                lblLimite.Text = x.Limite.ToString();
            }
            else
            {
                lblNombre.Text = "";
                lblDeuda.Text = "";
                lblLimite.Text = "";
                MessageBox.Show("Cliente no existente");
            }

        }
    }
}
