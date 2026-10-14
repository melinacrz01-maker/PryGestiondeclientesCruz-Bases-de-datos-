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

            Int32 idCliente = Convert.ToInt32(txtcodigodelclienteingresado.Text);
            
           
        }
    }
}
