using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArroyoGimnasio_IEFI
{
    internal class clsActividad
    {
        private OleDbConnection ConexionBaseDatos = new OleDbConnection();
        private OleDbCommand QueQuieroDeLaBase = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        private OleDbDataReader Lectora;
        public string NombreActividad;

        private string RutaBaseDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseDeDatos_Clientes.accdb";
        private string Tabla = "Actividad";

        public void CargaLstActividad(ComboBox combo)
        {
            try
            {
                //Conecto con la base de datos
                ConexionBaseDatos.ConnectionString = RutaBaseDatos;
                //Abro Conexion
                ConexionBaseDatos.Open();
                //Indico cual es la conexion que voy a utilizar
                QueQuieroDeLaBase.Connection = ConexionBaseDatos;
                //Indico que voy a trabajar directamente con table
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                //Indico Nombre de la tabla a travez de la variable tabla creada en la linea 19
                QueQuieroDeLaBase.CommandText = Tabla;
                //Elemento que me permite convertir los datos que se encuentran en la base de datos a un conjunto de valores que entienda .NET
                //le paso a adaptador el comando (quequierodelabase)
                Adaptador = new OleDbDataAdapter(QueQuieroDeLaBase);
                //creo objeto local
                DataSet DS = new DataSet();
                //llenamos el dataset con la informacion del adaptador
                Adaptador.Fill(DS, Tabla);
                combo.DataSource = DS.Tables[Tabla];
                //Indico que quiero que se muestre en el combobox
                combo.DisplayMember = "Detalle";
                //Codigo de los barrios
                combo.ValueMember = "Codigo_Actividad";
                //Cierro Conexion
                ConexionBaseDatos.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }

        }

        public void BuscarActivid(int codigo)
        {
            try
            {
                //Conecto con la base de datos
                ConexionBaseDatos.ConnectionString = RutaBaseDatos;
                //Abro Conexion
                ConexionBaseDatos.Open();
                //Indico cual es la conexion que voy a utilizar
                QueQuieroDeLaBase.Connection = ConexionBaseDatos;
                //Indico que voy a trabajar directamente con table
                QueQuieroDeLaBase.CommandType = CommandType.Text;
                //Indico Nombre de la tabla a travez de la variable tabla creada en la linea 19
                QueQuieroDeLaBase.CommandText = "SELECT * FROM Actividad WHERE Codigo_Actividad =" + codigo;
                //Elemento que me permite convertir los datos que se encuentran en la base de datos a un conjunto de valores que entienda .NET
                //le paso a adaptador el comando (quequierodelabase)
                Lectora = QueQuieroDeLaBase.ExecuteReader();

                while (Lectora.Read())
                {
                    NombreActividad = Lectora[1].ToString();
                }

                ConexionBaseDatos.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }
        }

        public string BuscarParaGrilla(Int32 CodigoActividad)
        {
            try
            {
                //Conecto con la base de datos
                ConexionBaseDatos.ConnectionString = RutaBaseDatos;
                //Abro Conexion
                ConexionBaseDatos.Open();
                //Indico cual es la conexion que voy a utilizar
                QueQuieroDeLaBase.Connection = ConexionBaseDatos;
                //Indico que voy a trabajar directamente con table
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                //Indico Nombre de la tabla a travez de la variable tabla creada en la linea 19
                QueQuieroDeLaBase.CommandText = Tabla;

                OleDbDataReader Lector = QueQuieroDeLaBase.ExecuteReader();
                string varDetalleActividad = "";
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == CodigoActividad)
                        {
                            varDetalleActividad = Lector.GetString(1);
                        }
                    }
                }
                ConexionBaseDatos.Close();
                return varDetalleActividad;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

