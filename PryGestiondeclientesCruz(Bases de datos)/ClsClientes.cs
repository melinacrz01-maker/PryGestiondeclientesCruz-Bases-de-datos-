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
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                Grilla.DataSource = null;
                Grilla.AutoGenerateColumns = false;
                Grilla.Rows.Clear();

                OleDbDataReader DR = comando.ExecuteReader();

                cantidad = 0;
                deuda = 0;

                while (DR.Read())
                {
                    Grilla.Rows.Add(
                        DR.GetInt32(0),
                        DR.GetString(1),
                        "Ciudad",
                        DR.GetDecimal(2),
                        DR.GetDecimal(3)
                    );

                    cantidad++;
                    deuda += DR.GetDecimal(2);
                }

                DR.Close();
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
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                //Nuevo
                DataTable tabla = DS.Tables[Tabla];
                DataRow fila = tabla.NewRow();

                fila["Nombre"] = nom;
                fila["Deuda"] = 0;
                fila["Limite"] = lim;
                fila["idCiudad"] = idCiu;


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
        public void ListarClientes(DataGridView Grilla)
        {
            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que tipo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                clsCiudad ciu = new clsCiudad();
                String NomCiu = "";

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), NomCiu, DR.GetDecimal(2), DR.GetDecimal(3));
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public string Buscar(Int32 IdCliente)
        {
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
                            if (DR.GetInt32(0) == IdCliente)
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
}
