using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace Tienda
{
    public class Funciones_login
    {
        public String ServidorSQL { set; get; } //Generico
        public String BD { set; get; }
        public System.Web.HttpResponse Response { get; }
        public System.Data.DataRowCollection Rows { get; }
        [System.ComponentModel.TypeConverter(typeof(System.Drawing.ImageFormatConverter))]
        public sealed class ImageFormat { }
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
        public SqlConnection VentaDiaria(ref string mensaje, ref float precio, int año , int mes, int dia)
        {
            SqlConnection carretera = new SqlConnection();
            SqlDataAdapter trailer = new SqlDataAdapter();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                string sentenciaSAQL = "Select sum(total_compra) as Venta_del_dia  from compra where MONTH(fecha_compra)=" + Convert.ToInt32(mes) + " and (YEAR(fecha_compra)= " + Convert.ToInt32(año) + " and Day(fecha_compra) = " + dia + ")";
                SqlCommand carrito = new SqlCommand(sentenciaSAQL, carretera);
                 precio = Convert.ToSingle(carrito.ExecuteScalar());
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                mensaje = "Consulta Realizada" + precio;
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
            return carretera;
        }
        public void InsertarGeneral(String sentenciaSQL, ref String mensaje)
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
                mensaje = "Tarjeta actualizada ";
                carreteria.Close();
            }
            catch (Exception t)
            {
                carreteria = null;
                mensaje = "ERROR: " + t.Message;
            }
        }
        public void ObtenerImagen_Insertar(ref string mensaje, string nombre, string apellidos, int id_rol, int id_permiso, string correo, string contrase, byte[] foto)
        {
            SqlConnection carretera = new SqlConnection();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated Security=true";
            SqlCommand carrito = new SqlCommand();
            try
            {
                carretera.Open();
                carrito.CommandText = "Insert into Usuario(Nombre,Apellidos,id_rol,id_permiso,correo,foto,contraseña) Values(@Nombre,@Apellido,@id_rol,@id_permiso, @correo,@foto,@contraseña)";
                carrito.Parameters.Add("@Nombre", System.Data.SqlDbType.Text).Value = nombre;
                carrito.Parameters.Add("@Apellido", System.Data.SqlDbType.Text).Value = apellidos;
                carrito.Parameters.Add("@id_rol", System.Data.SqlDbType.Int).Value = id_rol = 2;
                carrito.Parameters.Add("@id_permiso", System.Data.SqlDbType.Int).Value = id_permiso = 2;
                carrito.Parameters.Add("@correo", System.Data.SqlDbType.Text).Value = correo;
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;
                carrito.Parameters.Add("@contraseña", System.Data.SqlDbType.Text).Value = contrase;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
        }
        public void actualizarproducto(ref string mensaje, int id_producto, string nombre, string marca, string status, string origen, string descripcion, string existencia, int id_usuario, int id_categoria, float precio, string unidad, byte[] foto)
        {
            SqlConnection carretera = new SqlConnection();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated Security=true";
            SqlCommand carrito = new SqlCommand();
            try
            {
                carretera.Open();
                carrito.CommandText = "update Productos set nombre=@nombre,marca=@marca,status=@status,origen=@origen,descripcion=@descripcion,cantidades_existentes=@cantidades_existentes,id_usuario=@id_usuario,id_categoria=@id_categoria,precio=@precio,unidad_de_medidas=@unidad_de_medidas,foto=@foto where id_producto=@id_producto";
                carrito.Parameters.Add("@nombre", System.Data.SqlDbType.Text).Value = nombre;
                carrito.Parameters.Add("@marca", System.Data.SqlDbType.Text).Value = marca;
                carrito.Parameters.Add("@status", System.Data.SqlDbType.Text).Value = status;
                carrito.Parameters.Add("@origen", System.Data.SqlDbType.Text).Value = origen;
                carrito.Parameters.Add("@descripcion", System.Data.SqlDbType.Text).Value = descripcion;
                carrito.Parameters.Add("@cantidades_existentes", System.Data.SqlDbType.Int).Value = existencia;
                carrito.Parameters.Add("@id_usuario", System.Data.SqlDbType.Int).Value = id_usuario;
                carrito.Parameters.Add("@id_categoria", System.Data.SqlDbType.Int).Value = id_categoria;
                carrito.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = precio;
                carrito.Parameters.Add("@unidad_de_medidas", System.Data.SqlDbType.Text).Value = unidad;
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;
                carrito.Parameters.Add("@id_producto", System.Data.SqlDbType.Int).Value = id_producto;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
        }
        public void ObtenerProductoImagen_Insertar(ref string mensaje, string nombre, string marca, string status, string origen, string descripcion, string existencia, int id_usuario, int id_categoria, float precio, string unidad, byte[] foto)
        {
            SqlConnection carretera = new SqlConnection();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated Security=true";
            SqlCommand carrito = new SqlCommand();
            try
            {
                carretera.Open();
                carrito.CommandText = "Insert into Productos(nombre,marca,status,origen,descripcion,cantidades_existentes,id_usuario,id_categoria,precio,unidad_de_medidas,foto) Values(@nombre,@marca,@status,@origen,@descripcion,@cantidades_existentes,@id_usuario,@id_categoria,@precio,@unidad_de_medidas,@foto)";
                carrito.Parameters.Add("@nombre", System.Data.SqlDbType.Text).Value = nombre;
                carrito.Parameters.Add("@marca", System.Data.SqlDbType.Text).Value = marca;
                carrito.Parameters.Add("@status", System.Data.SqlDbType.Text).Value = status;
                carrito.Parameters.Add("@origen", System.Data.SqlDbType.Text).Value = origen;
                carrito.Parameters.Add("@descripcion", System.Data.SqlDbType.Text).Value = descripcion;
                carrito.Parameters.Add("@cantidades_existentes", System.Data.SqlDbType.Int).Value = existencia;
                carrito.Parameters.Add("@id_usuario", System.Data.SqlDbType.Int).Value = id_usuario;
                carrito.Parameters.Add("@id_categoria", System.Data.SqlDbType.Int).Value = id_categoria;
                carrito.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = precio;
                carrito.Parameters.Add("@unidad_de_medidas", System.Data.SqlDbType.Text).Value = unidad;
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
        }
        public void Actualizar_producto(ref string mensaje, string nombre, string marca, string status, string origen, string descripcion, string existencia, int id_usuario, int id_categoria, float precio, string unidad, byte[] foto)
        {
            SqlConnection carretera = new SqlConnection();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated Security=true";
            SqlCommand carrito = new SqlCommand();

            try
            {
                carretera.Open();
                carrito.CommandText = "Insert into Productos(nombre,marca,status,origen,descripcion,cantidades_existentes,id_usuario,id_categoria,precio,unidad_de_medidas,foto) Values(@nombre,@marca,@status,@origen,@descripcion,@cantidades_existentes,@id_usuario,@id_categoria,@precio,@unidad_de_medidas,@foto)";
                carrito.Parameters.Add("@nombre", System.Data.SqlDbType.Text).Value = nombre;
                carrito.Parameters.Add("@marca", System.Data.SqlDbType.Text).Value = marca;
                carrito.Parameters.Add("@status", System.Data.SqlDbType.Text).Value = status;
                carrito.Parameters.Add("@origen", System.Data.SqlDbType.Text).Value = origen;
                carrito.Parameters.Add("@descripcion", System.Data.SqlDbType.Text).Value = descripcion;
                carrito.Parameters.Add("@cantidades_existentes", System.Data.SqlDbType.Int).Value = existencia;
                carrito.Parameters.Add("@id_usuario", System.Data.SqlDbType.Int).Value = id_usuario;
                carrito.Parameters.Add("@id_categoria", System.Data.SqlDbType.Int).Value = id_categoria;
                carrito.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = precio;
                carrito.Parameters.Add("@unidad_de_medidas", System.Data.SqlDbType.Text).Value = unidad;
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;

                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
        }
        public SqlConnection Autenticar(ref string mensaje,  ref string nombre, ref string contraseña, string contrase)
        {

            SqlConnection carretera = new SqlConnection();
            SqlDataAdapter trailer = new SqlDataAdapter();

            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                 contraseña = " select contraseña from Usuario where correo =@correo and contraseña =@contraseña";
                SqlCommand carrito = new SqlCommand(contraseña, carretera);
               
                carrito.Parameters.Add("@correo", System.Data.SqlDbType.NVarChar).Value = nombre;
                carrito.Parameters.Add("@contraseña", System.Data.SqlDbType.NVarChar).Value = contrase;
                contraseña = Convert.ToString(carrito.ExecuteScalar());
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
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
        public SqlConnection obtener_id(ref string mensaje, ref string nombre, ref int  id_producto)
        {

            SqlConnection carretera = new SqlConnection();
            SqlDataAdapter trailer = new SqlDataAdapter();

            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                string id;
                id = " select id_producto from Productos where nombre =@Nombre";
                SqlCommand carrito = new SqlCommand(id, carretera);
                carrito.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar).Value = nombre;
                id_producto = Convert.ToInt32(carrito.ExecuteScalar());
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
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
        public SqlConnection obtener_id_usuario(ref string mensaje,  string nombre,ref int idusu)
        {
            SqlConnection carretera = new SqlConnection();
            SqlDataAdapter trailer = new SqlDataAdapter();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                string id;
                id = " select id_usuario from Usuario where Nombre =@Nombre";
                SqlCommand carrito = new SqlCommand(id, carretera);
                carrito.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar).Value = nombre;
                idusu = Convert.ToInt32(carrito.ExecuteScalar());
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
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

        public SqlConnection autenticar1(ref string mensaje, ref string usuario, ref string contraseña, string nombre, string contrase)
        {

            SqlConnection carretera = new SqlConnection();
            SqlDataAdapter trailer = new SqlDataAdapter();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                Autenticar(ref mensaje, ref nombre, ref contraseña, contrase);
                usuario = " select correo from Usuario where correo =@correo and contraseña =@contraseña";
                SqlCommand carrito = new SqlCommand(usuario, carretera);
                carrito.Parameters.Add("@correo", System.Data.SqlDbType.NVarChar).Value = nombre;
                carrito.Parameters.Add("@contraseña", System.Data.SqlDbType.NVarChar).Value = contrase;
                usuario = Convert.ToString(carrito.ExecuteScalar());
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.ExecuteNonQuery();
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

        
        public SqlConnection mostrar_datos(System.Web.UI.WebControls.Image grid, string nombre, ref string mensaje)
        {
            string sentenciaSQL;
            SqlConnection carretera = new SqlConnection();

            SqlDataAdapter trailer = new SqlDataAdapter();
            //   SqlDataAdapter contenedor;
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                sentenciaSQL = "select foto from Usuario where correo=@correo";
                SqlCommand carrito = new SqlCommand(sentenciaSQL, carretera);
                carrito.Parameters.Add("@correo", System.Data.SqlDbType.NVarChar).Value = nombre;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.CommandTimeout = 0;
                byte[] img = (byte[])carrito.ExecuteScalar();
                if (img != null && img.Length > 0)
                {
                    grid.ImageUrl = "data:image;base64," + Convert.ToBase64String(img);
                }

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
        public SqlConnection mostrar_datosprod2(System.Web.UI.WebControls.Image grid, string nombre, ref string mensaje)
        {
            string sentenciaSQL;
            SqlConnection carretera = new SqlConnection();

            SqlDataAdapter trailer = new SqlDataAdapter();
            //   SqlDataAdapter contenedor;
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                sentenciaSQL = "select foto from Productos where nombre=@Nombre";
                SqlCommand carrito = new SqlCommand(sentenciaSQL, carretera);
                carrito.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar).Value = nombre;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.CommandTimeout = 0;
                byte[] img = (byte[])carrito.ExecuteScalar();
                if (img != null && img.Length > 0)
                {
                    grid.ImageUrl = "data:image;base64," + Convert.ToBase64String(img);
                }

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
        public SqlConnection BuscarProducto(System.Web.UI.WebControls.Image grid, string nombre, ref int id,ref float precio, ref string mensaje)
        {
            string sentenciaSQL;
            SqlConnection carretera = new SqlConnection();

            SqlDataAdapter trailer = new SqlDataAdapter();
            //   SqlDataAdapter contenedor;
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                sentenciaSQL = "select foto from Productos where nombre=@nombre";
                SqlCommand carrito = new SqlCommand(sentenciaSQL, carretera);
                carrito.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar).Value = nombre;
                obtener_id(ref mensaje, ref nombre, ref id);
                string usuario = "";
                encontrarprecio(ref mensaje, ref usuario, ref precio,  nombre);
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.CommandTimeout = 0;
                byte[] img = (byte[])carrito.ExecuteScalar();
                if (img != null && img.Length > 0)
                {
                    grid.ImageUrl = "data:image;base64," + Convert.ToBase64String(img);
                }
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
        public SqlConnection mostrar_datosLeonardo(System.Web.UI.WebControls.GridView grid, ref string mensaje, string sentenciaSQL)
        {
            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                carrito.Connection = carretera;
                carrito.CommandText = sentenciaSQL;
                trailer.SelectCommand = carrito;
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
        public SqlConnection mostrar_datosImageLeonardo(System.Web.UI.WebControls.Image grid, string nombre, ref string mensaje)
        {
            string sentenciaSQL;
            SqlConnection carretera = new SqlConnection();

            SqlDataAdapter trailer = new SqlDataAdapter();
            //   SqlDataAdapter contenedor;
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                sentenciaSQL = "select foto from Usuario where correo=@correo";
                SqlCommand carrito = new SqlCommand(sentenciaSQL, carretera);
                carrito.Parameters.Add("@correo", System.Data.SqlDbType.NVarChar).Value = nombre;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                carrito.CommandTimeout = 0;
                byte[] img = (byte[])carrito.ExecuteScalar();
                if (img != null && img.Length > 0)
                {
                    grid.ImageUrl = "data:image;base64," + Convert.ToBase64String(img);
                }
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
        public void Paso_parametros( ref string cad,int idusuario, float precio,int id_producto,int id_monto)
        {
            SqlConnection carretera = new SqlConnection();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated security=true";
            try
            {
                // se abre la conexion
                carretera.Open(); // abro conexion
                int id_admin = 5;
                string storeprocedure = "TRANSACCIONES";
                SqlCommand carrito = new SqlCommand(storeprocedure, carretera); //coloco nombre aplicacion y conexion
                carrito.CommandType = CommandType.StoredProcedure; // le hago saber que es procedimiento almacena /se especifica add para valor retornar
                carrito.Parameters.AddWithValue("@origen", idusuario);
                carrito.Parameters.AddWithValue("@destino ", id_admin); // parametros de entrada
                carrito.Parameters.AddWithValue("@cantidad", precio);
                carrito.Parameters.AddWithValue("@idproducto", id_producto);
                carrito.Parameters.AddWithValue("@numero_cantidades", id_monto);
                carrito.ExecuteScalar(); //termina la consulta
                carretera.Close(); //cerrar seccion 
                    //ValorRetorno.Value = "@promedio";
                //[Variable procedimiento almacenado.]
                cad = "COMPRA REALIZADA CORRECTAMENTE";
            }
            catch (Exception t)
            {
                carretera = null;
                cad = t.Message + "ERROR  ALGO ESTA MAL, VERIFICA QUE TENGAS UNA TARJETA , NO TENGAS DOS TARJETAS O SI TU SALDO ES SUFICIENTE" ;
            }
        }
        public SqlConnection mostrar_datos2(System.Web.UI.WebControls.GridView grid, ref string mensaje)
        {

            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            //   SqlDataAdapter contenedor;
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                carrito.CommandText = "select*from Usuario";
                carrito.Connection = carretera;
                trailer.SelectCommand = carrito;
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

        public SqlConnection Buscar(System.Web.UI.WebControls.GridView grid, string nombre, ref string mensaje)
        {

            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            //   SqlDataAdapter contenedor;
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                carrito.CommandText = "select *from Usuario where Nombre=@Nombre";
                carrito.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar).Value = nombre;
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;
                trailer.SelectCommand = carrito;
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
        public SqlConnection encontrarprecio(ref string mensaje, ref string usuario,ref float precio, string nombre)
        {

            SqlConnection carretera = new SqlConnection();
            SqlDataAdapter trailer = new SqlDataAdapter();

            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                usuario = " select precio from Productos where nombre=@Nombre";
                SqlCommand carrito = new SqlCommand(usuario, carretera);
                carrito.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar).Value = nombre;
                precio= Convert.ToSingle(carrito.ExecuteScalar());
                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;



                carrito.ExecuteNonQuery();

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
        public void compra(ref int id,int id_producto,ref float precio,float precioproducto)
        {
            id_producto = id;
            precioproducto = precio;
        }
        public SqlConnection Buscar2(System.Web.UI.WebControls.GridView grid, string nombre, ref string mensaje)
        {

            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            //   SqlDataAdapter contenedor;
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {
                carretera.Open();
                carrito.CommandText = "select foto,descripcion,status,marca,precio from Productos where nombre =@Nombre";
                carrito.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar).Value = nombre;
                carrito.CommandType = System.Data.CommandType.Text;

                carrito.Connection = carretera;
                trailer.SelectCommand = carrito;
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
        public void Actualizar(ref string mensaje, string nombre, string apellidos, int id_rol, int id_permiso, string correo, string contraseña, int id_usuario, byte[] foto)
        {
            SqlConnection carretera = new SqlConnection();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated Security=true";
            SqlCommand carrito = new SqlCommand();


            try
            {
                carretera.Open();

                carrito.CommandText = "update Usuario set Nombre=@nombre,Apellidos=@Apellidos,id_rol=@id_rol,id_permiso=@id_permiso,correo=@correo,foto=@foto where id_usuario=@id_usuario";
                carrito.Parameters.Add("@nombre", System.Data.SqlDbType.Text).Value = nombre;
                carrito.Parameters.Add("@Apellidos", System.Data.SqlDbType.Text).Value = apellidos;
                carrito.Parameters.Add("@id_rol", System.Data.SqlDbType.Int).Value = id_rol;
                carrito.Parameters.Add("@id_permiso", System.Data.SqlDbType.Int).Value = id_permiso;
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image).Value = foto;
                carrito.Parameters.Add("@contraseña", System.Data.SqlDbType.Text).Value = contraseña;
                carrito.Parameters.Add("@correo", System.Data.SqlDbType.Text).Value = correo;
                carrito.Parameters.Add("@id_usuario", System.Data.SqlDbType.Int).Value = id_usuario;

                carrito.CommandType = System.Data.CommandType.Text;
                carrito.Connection = carretera;

                carrito.ExecuteNonQuery();
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
        }
        public void Eliminar(string id_usuario, ref string cad)
        {
            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated security=true";
            try
            {
                carretera.Open();
                carrito.CommandText = "Delete from Usuario where Nombre='" +
               id_usuario + "'";
                carrito.Connection = carretera;
                int x = carrito.ExecuteNonQuery();
                cad = "Usuario eliminada eliminado";
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                cad = "ERROR: " + t.Message;
            }


        }
        public void Eliminarproducto(int id_producto, ref string cad)
        {
            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated security=true";
            try
            {
                carretera.Open();
                carrito.CommandText = "Delete from Productos where id_producto='" +
               id_producto + "'";
                carrito.Connection = carretera;
                int x = carrito.ExecuteNonQuery();
                cad = "Usuario eliminada eliminado";
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                cad = "ERROR: " + t.Message;
            }


        }
        public SqlConnection Consulta_imagen(Repeater rp, ref string mensaje)
        {
            string sentenciaSQL;
            string[] arreglo;
            arreglo = new string[1];
            SqlConnection carretera = new SqlConnection();

            SqlDataAdapter trailer = new SqlDataAdapter();
            //   SqlDataAdapter contenedor;
            DataSet resultado = new DataSet();
            carretera.ConnectionString = "data source = " + ServidorSQL + "; Initial Catalog = " + BD + "; Integrated Security = true";
            try
            {

                sentenciaSQL = "select foto ,nombre from Productos ORDER BY id_producto ASC";
                SqlCommand carrito = new SqlCommand(sentenciaSQL, carretera);

                carrito.CommandType = CommandType.Text;
                carrito.Connection = carretera;
                carretera.Open();
                DataTable ImagenesBD = new DataTable();
                ImagenesBD.Load(carrito.ExecuteReader());
                rp.DataSource = ImagenesBD;
                rp.DataBind();
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
      
    }
}


