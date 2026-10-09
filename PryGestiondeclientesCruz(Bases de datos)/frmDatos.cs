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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void btnListarDatos_Click(object sender, EventArgs e)
        {
            clsClientes clientes = new clsClientes();
            clientes.Listar(Dgvgrilladatos);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            clsClientes objClientes = new clsClientes();
            objClientes.ReporteClientes();
            MessageBox.Show("Reporte Generado Correctamente");
        }
    }
}
