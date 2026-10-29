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

            public String Buscar(Int32 IdCiudad)
            {
                try
                {
                    conexion.ConnectionString = CadenaConexion;
                    conexion.Open();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.TableDirect;
                    comando.CommandText = Tabla;

                    OleDbDataReader DR = comando.ExecuteReader();
                    String Resultado = "";

                    if (DR.HasRows)
                    {
                        while (DR.Read())
                        {
                            if (DR.GetInt32(0) == IdCiudad)
                            {
                                Resultado = DR.GetString(1);
                            }
                        }
                    }
                    conexion.Close();

                    return Resultado;
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
    }
}


