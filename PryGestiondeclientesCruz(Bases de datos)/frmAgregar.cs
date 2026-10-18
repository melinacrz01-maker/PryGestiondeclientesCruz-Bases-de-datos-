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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.Nombre = txtNombre.Text;
            x.Limite = Convert.ToDecimal(txtLimite.Text);
            x.idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
            x.Agregar();

            MessageBox.Show("Datos Grabados!!!!");
            txtNombre.Text = "";
            txtLimite.Text = "";
            cmbCiudad.SelectedIndex = 0;
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            clsCiudad ciu = new clsCiudad();
            ciu.Listar(cmbCiudad);
        }
    }
}
