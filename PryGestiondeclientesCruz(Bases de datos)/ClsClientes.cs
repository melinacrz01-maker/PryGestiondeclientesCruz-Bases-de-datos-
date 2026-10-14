using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;

namespace PryGestiondeclientesCruz_Bases_de_datos_
{
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private OleDbDataReader reader = null;


        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Clientesdb.mdb";
        private string Tabla = "Lista";


        //variables
        private Decimal deuda;
        private Int32 cantidad;


        private Int32 idCliente;
        private string nombreCliente;
        private Int32 deudaCliente;
        private decimal promedioDeuda;
        private decimal IdCliente;

        //PROPIEDADES
        public Decimal TotalDeuda
        {
            get { return deuda; }
        }

        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }


        public Int32 IdCliente1
        {
            get { return idCliente; }
            set { idCliente = value; }
        }


        public Decimal PromedioDeuda
        {
            get
            {
                //si no hay deudores devolvemos 0 para no dividir por cero
                if (cantidad == 0)
                {
                    return 0;
                }
                return deuda / cantidad;
            }
        }



        public void Listar(DataGridView Grilla)
        {

            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que tiempo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                //Adaptamos los datos de toda la tabla y se los cargamos a DS
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();             //data set llama a todos
                adaptador.Fill(DS);

              
                Grilla.DataSource = DS.Tables[0];


                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }

        }


        public void ReporteClientes()
        {
            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter AD = new StreamWriter("Reporte.csv", false, Encoding.UTF8);
                AD.WriteLine("Listado de Clientes\n");
                AD.WriteLine("Código;Nombre;Deuda");

                cantidad = 0;
                deuda = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        AD.Write(DR.GetInt32(0));
                        AD.Write(";");
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.WriteLine(DR.GetDecimal(2));

                        cantidad++;
                        deuda = deuda + DR.GetDecimal(2);

                    }
                    AD.Write("\nCantidad de clientes:;;");
                    AD.WriteLine(cantidad);
                    AD.Write("Deuda de los clientes:;;");
                    AD.WriteLine(deuda);
                }

                conexion.Close();
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void Deudores(DataGridView Grilla)
        {

            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();


                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();


                cantidad = 0;
                deuda = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetDecimal(2) > 0)
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2));
                            cantidad++;
                            deuda = deuda + DR.GetDecimal(2);
                        }
                    }
                }

                conexion.Close();
            }


            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }

        }
        private void BuscarCliente(Int32 IdCliente)
        {
            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
               


                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdCliente)
                        {
                                 idCliente = DR.GetInt32(0);
                            nombreCliente = DR.GetString(1);
                            deudaCliente = DR.GetInt32(2);
                            promedioDeuda = DR.GetDecimal(2);
                            IdCliente = DR.GetInt32(0);
                        }
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }
    }
}