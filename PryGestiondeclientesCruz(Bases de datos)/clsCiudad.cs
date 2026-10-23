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
        internal class ClsCiudad
        {
            // Variables globales
            private OleDbConnection conexion = new OleDbConnection();
            private OleDbCommand comando = new OleDbCommand();
            private OleDbDataAdapter adaptador = new OleDbDataAdapter();

            private string CadenaConexion =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                + Application.StartupPath + @"\Clientesdb.mdb";

            private string Tabla = "Ciudad";

            // Carga las ciudades en el ComboBox
            public void Listar(ComboBox Combo)
            {
                try
                {
                    conexion.ConnectionString = CadenaConexion;
                    conexion.Open();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.TableDirect;
                    comando.CommandText = Tabla;

                    adaptador = new OleDbDataAdapter(comando);
                    DataSet DS = new DataSet();
                    adaptador.Fill(DS, Tabla);

                    Combo.DataSource = DS.Tables[Tabla];
                    Combo.DisplayMember = "Nombre";
                    Combo.ValueMember = "idCiudad";
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conexion.Close();
                }
            }

            // Busca una ciudad por su código y devuelve su nombre
            public string Buscar(Int32 IdCiudad)
            {
                try
                {

                    //Hacemos la conexion a la base de datos
                    conexion.ConnectionString = CadenaConexion;
                    conexion.Open();

                    // Configuramos el comando para buscar la ciudad por su código
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.TableDirect;
                    comando.CommandText = Tabla;

                    OleDbDataReader dr = comando.ExecuteReader();
                    String resultado = "";

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (Convert.ToInt32(dr["idCiudad"]) == IdCiudad)
                            {
                                resultado = dr["Nombre"].ToString();
                                break;
                            }
                        }
                    }

                    conexion.Close();

                    return resultado;

                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return "";
                }

            }
        }
    }
}


