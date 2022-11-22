using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.IO;

//Para enviar a imprimir y definir tipo de letra
using System.Drawing;
using System.Drawing.Printing;

namespace pryArroyoGimnasio_IEFI
{
    internal class clsClientes
    {
        //Conexion con la base de datos
        private OleDbConnection ConexionBaseDatosClientes = new OleDbConnection();

        //Enviar una orden de que quiero de la base de datos

        private OleDbCommand QueQuieroDeLaBase = new OleDbCommand();

        //Adapto los datos que estan en la base de datos a datos reconocidos por .NET
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        //Ruta donde se encuentra la base de datos
        private string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseDeDatos_Clientes.accdb";

        private string Tabla = "Gimnasio";

        Int32 DNI_Socio;
        string Nombre_Apellido;
        string Direccion;
        Int32 Codigo_Barrio;
        Int32 Actividad;
        Int32 Saldo;

        private Int32 CantCli;
        private Int32 SaldTot;
        private Int32 PromSaldo;
        private Int32 SaldMayor = 0;
        private Int32 SaldMenor = 0;

        //creo las propiedades de las variables
        //Get: retorna el contenido de las variables
        //Set: Toma el valor y lo almacena
        public Int32 CantidadClientes
        {
            get { return CantCli; }
            set { CantCli = value; }
        }

        public Int32 SaldoTotal
        {
            get { return SaldTot; }
            set { SaldTot = value; }
        }

        public Int32 PromedioSaldo
        {
            get { return PromSaldo; }
            set { PromSaldo = value; }
        }

        public Int32 DniCliente
        {
            get { return DNI_Socio; }
            set { DNI_Socio = value; }
        }

        public string NombreyApellidoCliente
        {
            get { return Nombre_Apellido; }
            set { Nombre_Apellido = value; }
        }

        public string DireccionCliente
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public Int32 CodigoBarrioCliente
        {
            get { return Codigo_Barrio; }
            set { Codigo_Barrio = value; }
        }

        public Int32 ActividadCliente
        {
            get { return Actividad; }
            set { Actividad = value; }
        }

        public Int32 SaldoCliente
        {
            get { return Saldo; }
            set { Saldo = value; }
        }

        public Int32 SaldoMayor
        {
            get { return SaldMayor; }
            set { SaldMayor = value; }
        }

        public Int32 SaldoMenor
        {
            get { return SaldMenor; }
            set { SaldMenor = value; }
        }

        public void AgregarNuevoCliente()
        {
            try
            {
                ConexionBaseDatosClientes.ConnectionString = RutaBaseDeDatos;
                ConexionBaseDatosClientes.Open();
                QueQuieroDeLaBase.Connection = ConexionBaseDatosClientes;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = Tabla;
                //El adaptador trabajara con la condicion del comando
                Adaptador = new OleDbDataAdapter(QueQuieroDeLaBase);
                //creo un dataset
                DataSet DS = new DataSet();
                //lleno el data set con los datos de la tabla
                //El adaptador puede trabajar en doble sentido, es decir, nos trae los datos de la tabla para el dataset
                //y despues toma los datos del dataset para los datos
                Adaptador.Fill(DS, Tabla);
                //el data table recibe todo lo que tiene el dataset en la tabla Gimnasio
                DataTable tabla = DS.Tables[Tabla];
                //creo una nueva fila vacia en la tabla gimnasio
                DataRow Fila = tabla.NewRow();

                //lleno la fila
                //En esa fila, el campo [""] va a tomar el dato de una variable, por ejemplo DNI_Socio
                Fila["Dni_Socio"] = DNI_Socio;
                Fila["Nombre_Apellido"] = Nombre_Apellido;
                Fila["Direccion"] = Direccion;
                Fila["Codigo_Barrio"] = Codigo_Barrio;
                Fila["Actividad"] = Actividad;
                Fila["Saldo"] = Saldo;
                //inserto la fila en la tabla
                tabla.Rows.Add(Fila);
                //elemento que hace que se concilien los campos entre lo que esta en la memoria y en la base de datos
                OleDbCommandBuilder HacerCompatiblesLosCambios = new OleDbCommandBuilder(Adaptador);
                //Tomo los datos del Dataset y los envio a la base de datos, hago efectivo el cambio a traves del update
                Adaptador.Update(DS, Tabla);
                ConexionBaseDatosClientes.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show("No se pudo registrar cliente" + Mensaje.Message);
                //throw;
            }

        }

        public void Buscar(Int32 Codigo)
        {
            try
            {
                ConexionBaseDatosClientes.ConnectionString = RutaBaseDeDatos;
                ConexionBaseDatosClientes.Open();
                QueQuieroDeLaBase.Connection = ConexionBaseDatosClientes;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = Tabla;

                OleDbDataReader Lector = QueQuieroDeLaBase.ExecuteReader();
                //si tiene filas
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == Codigo)
                        {
                            DNI_Socio = Lector.GetInt32(0);
                            Nombre_Apellido = Lector.GetString(1);
                            Direccion = Lector.GetString(2);
                            Codigo_Barrio = Lector.GetInt32(3);
                            Actividad = (Lector.GetInt32(4));
                            Saldo = (Lector.GetInt32(5));


                        }
                    }
                }

                ConexionBaseDatosClientes.Close();

            }
            catch (Exception MensajeAviso)
            {
                MessageBox.Show(MensajeAviso.Message);
                //throw;
            }


        }

        public void ListarClientesPorBarrio(DataGridView GrillaCxBarrio, Int32 CodigoBarrio)
        {
            try
            {
                ConexionBaseDatosClientes.ConnectionString = RutaBaseDeDatos;
                ConexionBaseDatosClientes.Open();
                QueQuieroDeLaBase.Connection = ConexionBaseDatosClientes;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = Tabla;

                OleDbDataReader DR = QueQuieroDeLaBase.ExecuteReader();
                GrillaCxBarrio.Rows.Clear();
                //si hay filas
                if (DR.HasRows)
                {
                    //Recorro la tabla 
                    while (DR.Read())
                    {
                        //Comparo el CodigoBarrio que seria el campo numero 3 con la ciudad que nos enviaron desde la interfaz grafica
                        if (DR.GetInt32(3) == CodigoBarrio)
                        {
                            GrillaCxBarrio.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetString(2), DR.GetInt32(5));
                        }
                    }
                }
                ConexionBaseDatosClientes.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }

        }
        public void ListarClientesPorActividad(DataGridView GrillaCxActividad, Int32 CodigoActividad)
        {
            try
            {
                ConexionBaseDatosClientes.ConnectionString = RutaBaseDeDatos;
                ConexionBaseDatosClientes.Open();
                QueQuieroDeLaBase.Connection = ConexionBaseDatosClientes;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = Tabla;

                OleDbDataReader DR = QueQuieroDeLaBase.ExecuteReader();
                GrillaCxActividad.Rows.Clear();
                CantCli = 0;
                SaldTot = 0;
                PromSaldo = 0;
                

                //si hay filas
                if (DR.HasRows)
                {
                    //Recorro la tabla 
                    while (DR.Read())
                    {
                        //Comparo el CodigoBarrio que seria el campo numero 3 con la ciudad que nos enviaron desde la interfaz grafica
                        if (DR.GetInt32(4) == CodigoActividad)
                        {
                            GrillaCxActividad.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetString(2), DR.GetInt32(5));
                            SaldoMenor = DR.GetInt32(5);
                            CantCli++;
                            SaldTot = SaldTot + DR.GetInt32(5);
                            PromSaldo = SaldTot / CantCli;
                            if (SaldoMenor > SaldoMayor)
                            {
                                SaldoMayor = SaldoMenor;
                            }

                        }

                    }
                }
                ConexionBaseDatosClientes.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }

        }
        public void ListarTodosLosClientes(DataGridView GrillaGeneral)
        {
            try
            {
                ConexionBaseDatosClientes.ConnectionString = RutaBaseDeDatos;
                ConexionBaseDatosClientes.Open();
                QueQuieroDeLaBase.Connection = ConexionBaseDatosClientes;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = Tabla;

                OleDbDataReader DR = QueQuieroDeLaBase.ExecuteReader();
                GrillaGeneral.Rows.Clear();
                CantCli = 0;
                SaldTot = 0;
                PromSaldo = 0;

                string DetalleBarrio = "";
                string DetalleActividad = "";
                clsActividad objActividad = new clsActividad();
                clsBarrio objBarrio = new clsBarrio();


                //si hay filas
                if (DR.HasRows)
                {
                    //Recorro la tabla 
                    while (DR.Read())
                    {
                        DetalleActividad = objActividad.BuscarParaGrilla(DR.GetInt32(4));
                        DetalleBarrio = objBarrio.BuscarParaGrilla(DR.GetInt32(3));
                        GrillaGeneral.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetString(2), DetalleBarrio , DetalleActividad, DR.GetInt32(5));
                        CantCli++;
                        SaldTot = SaldTot + DR.GetInt32(5);
                        PromSaldo = SaldTot / CantCli;
                    }
                }
                ConexionBaseDatosClientes.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }

        }

        public void EliminarCliente(Int32 CodigoCliente)
        {


            try
            {
                //sentencia sql para modificar

                string ECliente = "DELETE FROM Gimnasio " + "WHERE(" + CodigoCliente + "=[Dni_Socio])";


                ConexionBaseDatosClientes.ConnectionString = RutaBaseDeDatos;
                ConexionBaseDatosClientes.Open();
                QueQuieroDeLaBase.Connection = ConexionBaseDatosClientes;
                QueQuieroDeLaBase.CommandType = CommandType.Text;
                QueQuieroDeLaBase.CommandText = ECliente;
                QueQuieroDeLaBase.ExecuteNonQuery();
                ConexionBaseDatosClientes.Close();

                MessageBox.Show("Cliente eliminado con exito");





            }
            catch (Exception Mensaje)
            {

                MessageBox.Show("El cliente no se pudo eliminar" + Mensaje.Message);
                //throw;
            }


        }

        public void ModificarCliente(Int32 CodigoCliente)
        {


            try
            {
                //sentencia sql para modificar

                string MCliente = "UPDATE GIMNASIO SET DNI_SOCIO= " + DniCliente + ", NOMBRE_APELLIDO='" + NombreyApellidoCliente + "', DIRECCION='" + DireccionCliente + "', CODIGO_BARRIO=" + CodigoBarrioCliente + ", ACTIVIDAD=" + Actividad + ", SALDO=" + Saldo + " WHERE [DNI_SOCIO] = " + CodigoCliente + "";


                ConexionBaseDatosClientes.ConnectionString = RutaBaseDeDatos;
                ConexionBaseDatosClientes.Open();
                QueQuieroDeLaBase.Connection = ConexionBaseDatosClientes;
                QueQuieroDeLaBase.CommandType = CommandType.Text;
                QueQuieroDeLaBase.CommandText = MCliente;
                QueQuieroDeLaBase.ExecuteNonQuery();
                ConexionBaseDatosClientes.Close();

                MessageBox.Show("Cliente modificado con exito");





            }
            catch (Exception Mensaje)
            {

                MessageBox.Show("El cliente no se pudo modificar" + Mensaje.Message);
                //throw;
            }
        }

        public void reporteCliente(Int32 CodigoCiudad)
        {
            try
            {
                
                ConexionBaseDatosClientes.ConnectionString = RutaBaseDeDatos;
                ConexionBaseDatosClientes.Open();
                QueQuieroDeLaBase.Connection = ConexionBaseDatosClientes;
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect;
                QueQuieroDeLaBase.CommandText = "Gimnasio";
                OleDbDataReader DR = QueQuieroDeLaBase.ExecuteReader();
                
                //Abro el archivo
                StreamWriter Archivo = new StreamWriter("ReporteClientes.csv", false);
                //grabo el archivo 
                Archivo.WriteLine("Listado de clientes por actividad\n");
                Archivo.WriteLine();
                Archivo.WriteLine("DNI;NOMBRE_APELLIDO;DIRECCION;SALDO");

                Int32 Cantidad = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(4) == CodigoCiudad)
                        {
                            Archivo.Write(DR.GetInt32(0));
                            Archivo.Write(";");
                            Archivo.Write(DR.GetString(1));
                            Archivo.Write(";");
                            Archivo.Write(DR.GetString(2));
                            Archivo.Write(";");
                            Archivo.WriteLine(DR.GetInt32(5));
                            
                            Cantidad++;
                            Archivo.Write("\n");
                        }
                    }
                    Archivo.Write("Cantidad de Clientes:;;");
                    Archivo.WriteLine(Cantidad);
                }
                ConexionBaseDatosClientes.Close();
                Archivo.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Imprimir(PrintPageEventArgs Reporte) //Declaro que este metodo va a recibir un objeto de tipo printPageEventArgs 
        {
            try
            {
                
                Font LetraTituloPrincipal = new Font("Times New Roman", 25);
                Font LetraSubtitulo = new Font("Times New Roman", 15);
                Font LetraTexto = new Font("Times New Roman", 11);
                Int32 F = 200;

                //Imprimo Titulo    //el metodo DrawString nos permite escribir 
                Reporte.Graphics.DrawString("Listado de Clientes", LetraTituloPrincipal, Brushes.Black, 100, 100);
                Reporte.Graphics.DrawString("DNI Socio", LetraSubtitulo, Brushes.Red, 100, 150);
                Reporte.Graphics.DrawString("Nombre y Apellido", LetraSubtitulo, Brushes.Red, 200, 150);
                Reporte.Graphics.DrawString("Direccion", LetraSubtitulo, Brushes.Red, 400, 150);
                Reporte.Graphics.DrawString("Saldo", LetraSubtitulo, Brushes.Red, 550, 150);

                //Establezco cadena de conexion
                ConexionBaseDatosClientes.ConnectionString = RutaBaseDeDatos;
                //Abro cadena de conexion 
                ConexionBaseDatosClientes.Open();
                //Configuracion del comando
                QueQuieroDeLaBase.Connection = ConexionBaseDatosClientes; //aqui le decimos que va a utilizar la conexion que esta abierta
                QueQuieroDeLaBase.CommandType = CommandType.TableDirect; //tipo de comando es acceso directo a una tabla
                QueQuieroDeLaBase.CommandText = Tabla; //el nombre de la tabla es el que se encuentra en la variable tabla
                Adaptador = new OleDbDataAdapter(QueQuieroDeLaBase); //ejecutamos el comando
                DataSet DS = new DataSet(); //Declaro un DataSet
                Adaptador.Fill(DS, Tabla); //llenamos el dataSet y le asignamos un nombre

                if (DS.Tables[Tabla].Rows.Count > 0 ) //Si el DS tiene filas
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows) //mostramos la informacion
                    {
                        //El metodo que imprime necesita un string, un tipo de letra, un color de letra y las coordenadas de columnas y filas
                        Reporte.Graphics.DrawString(fila["Dni_Socio"].ToString(), LetraTexto, Brushes.Black, 100, F);
                        Reporte.Graphics.DrawString(fila["Nombre_Apellido"].ToString(), LetraTexto, Brushes.Black, 200, F);
                        Reporte.Graphics.DrawString(fila["Direccion"].ToString(), LetraTexto, Brushes.Black, 400, F);
                        Reporte.Graphics.DrawString(fila["Saldo"].ToString(), LetraTexto, Brushes.Black, 550, F);
                        F = F + 20;
                    }
                }
                
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                
            }
        }
    }
}
