using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace PryGestiondeclientesCruz_Bases_de_datos_
{
    public partial class frmDeudores : Form
    {
        public frmDeudores()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Clientesdb.mdb;Persist Security Info=True";

                string consulta =
                    "SELECT [idCliente], [Nombre], [Deuda] FROM [Lista]";

                DataTable clientes = new DataTable();

                using (OleDbConnection cn = new OleDbConnection(conexion))
                using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, cn))
                {
                    adaptador.Fill(clientes);
                }

                dgvTabla.Rows.Clear();
                    dgvTabla.AllowUserToAddRows = false;

                foreach (DataRow cliente in clientes.Rows)
                {
                    dgvTabla.Rows.Add(
                        cliente["idCliente"],
                        cliente["Nombre"],
                        cliente["Deuda"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los clientes:\n" + ex.Message);
            }
        }

        private void frmDeudores_Load(object sender, EventArgs e)
        {

        }
    }
}
