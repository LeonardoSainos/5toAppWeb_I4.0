
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Data;
namespace Mi_aplicacion_con_aspet
{
    public class WEBFORM
    {
        public String ServidorSQL { set; get; }//Generico
        public String BD { set; get; }
        string nombre;//atributo
        public string Propiedad_nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        
        public System.Data.DataRowCollection Rows { get; }
        public void Conectar(ref string cad)
        {
            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated security=true";
            try
            {
                carretera.Open();
                cad = "Conexion Abierta";
            }
            catch (Exception t)
            {
                carretera = null;
                cad = "ERROR: " + t.Message;
            }
        }
        public SqlConnection mostrar_datos(System.Web.UI.WebControls.GridView grid, ref string mensaje, string sentenciaSQL)
        {
            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            //SqlDataReader contenedor;
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
               
               carrito.Connection = carretera;
                carrito.CommandText = sentenciaSQL;
                trailer.SelectCommand= carrito;
                trailer.Fill(resultado);
                grid.DataSource = resultado.Tables[0];
                
                grid.DataBind();
                mensaje = "Consulta Realizada";
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
         
            return carretera;
             
        }
        public void ObtenerImagen_Insertar(ref string mensaje, string nombre,int edad, byte[] foto)
        {
            SqlConnection carretera = new SqlConnection();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated Security=true";
            SqlCommand carrito = new SqlCommand();
            try
            {
                carretera.Open();
                carrito.CommandText = "Insert into Alumno(nombre,edad, foto) Values(@nombre,@edad ,@foto)";
                carrito.Parameters.Add("@nombre", System.Data.SqlDbType.Text).Value = nombre;
                carrito.Parameters.Add("@edad", System.Data.SqlDbType.Int).Value = edad;
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;

                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();

            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
        }
        public void Actualizar_registro(String sentenciaSQL, ref String mensaje)
        {
            SqlConnection carreteria = new SqlConnection();
            SqlCommand carrito = new SqlCommand();

            carreteria.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated security=true";

            try
            {
                carreteria.Open();
                carrito.CommandText = sentenciaSQL;
                carrito.Connection = carreteria;
                int variable = carrito.ExecuteNonQuery();
                mensaje = "Dato actualizado";
                carreteria.Close();
            }
            catch (Exception t)
            {
                carreteria = null;
                mensaje = "ERROR: " + t.Message;

            }
        }

        public void Eliminar(int no_control, ref string cad)
        {
            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated security=true";
            try
            {
                carretera.Open();
                carrito.CommandText = "Delete from Alumno where no_control= @no_control";
                carrito.Parameters.Add("@no_control", System.Data.SqlDbType.Int).Value = no_control;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                int x = carrito.ExecuteNonQuery();
                cad = "Alumno dado de baja";
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                cad = "ERROR: " + t.Message;
            }
        }

        public void Insertar_Foto_URL(ref string mensaje,  string sentenciaSQL)
        {
            //Método para insertar en la BD con campo foto string para alamcenar la URL
            SqlConnection carretera = new SqlConnection();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated Security=true";
            SqlCommand carrito = new SqlCommand();
            try
            {
                carretera.Open();
                carrito.CommandText = sentenciaSQL;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                mensaje = "Exito";
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }



            
            
        }
    }
}