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


        //Declaro las Variables
        private Decimal deuda;
        private Int32 cantidad;

        private Int32 idCli;
        private String nom;
        private Decimal deu;
        private Decimal lim;
        private Int32 idCiu;



        //Declaro las PROPIEDADES
        public Decimal TotalDeuda
        {
            get { return deuda; }
        }
        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }
        public Decimal PromedioDeuda
        {
            get { return deuda / cantidad; }
        }


        public Int32 idCliente
        {
            get { return idCli; }
            set { idCli = value; }
        }
        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public Decimal Deuda
        {
            get { return deu; }
            set { deu = value; }
        }
        public Decimal Limite
        {
            get { return lim; }
            set { lim = value; }
        }
        public Int32 idCiudad
        {
            get { return idCiu; }
            set { idCiu = value; }
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


        public void Agregar()
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

                //Nuevo
                DataTable tabla = DS.Tables[Tabla]; //instaciamos el objeto tabla - Recibe todo lo que tiene el DS en la tabla clientes
                DataRow fila = tabla.NewRow(); //instanciamos el objeto fila de la tabla - A fila le asigno una nueva fila (vacia) de esa tabla

                //llenamos la fila
                fila["Nombre"] = nom; //le asignamos los valores de las variables a los campos de la fila.
                fila["Deuda"] = 0;
                fila["Limite"] = lim;
                fila["idCiudad"] = idCiu;

                //incertamos la fila en la tabla
                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adaptador); //concilia los campos que estan en la Base de Datos con los que está en la memoria
                adaptador.Update(DS, Tabla); //hago efectivo el cambio de datos

                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }


        public void Buscar(Int32 IdCliente)
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

                idCli = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdCliente)
                        {
                            idCli = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            deu = DR.GetDecimal(2);
                            lim = DR.GetDecimal(3);
                            idCiu = DR.GetInt32(4);
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