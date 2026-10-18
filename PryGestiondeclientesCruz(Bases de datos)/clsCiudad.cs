using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregamos los 3 espacios de nombre
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryGestiondeclientesCruz_Bases_de_datos_
{
    internal class clsCiudad
    {
        //Global
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Clientesdb.mdb";
        private string Tabla = "Ciudad";

        //Procedimiento
        public void Listar(ComboBox Combo) //Sobrecarga de funciones (tengo dos procedimientos que se llaman iguales pero tienen comportamientos diferentes)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando); //adapta los dato de la base de datos a datos que sean entendibles por .NET
                DataSet DS = new DataSet(); // creamos el DataSet
                adaptador.Fill(DS, Tabla); // llenamos el DataSet por medio del adapataor

                Combo.DataSource = DS.Tables[Tabla]; //donde decia Grilla lo cambio por Combo
                Combo.DisplayMember = "Nombre"; //los datos que queremos que se vean en el comboBox, ponemos el campo que tiene los nombres de las ciudades
                Combo.ValueMember = "idCiudad"; //el dato que es invisible en el Combo

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
