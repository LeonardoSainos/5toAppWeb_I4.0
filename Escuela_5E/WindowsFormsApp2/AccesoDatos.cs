using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
 using System.Drawing;
using System.IO;
using System.Data;

namespace WindowsFormsApp2
{
   class ADO
    {
        public string ServidorSQL { set; get; }
        public string BD { set; get; }

        public void Conectar(ref string cad)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            conexion.ConnectionString = "data source= " + ServidorSQL + "; Initial catalog= " + BD + "; Integrated security=true";
            try
            {
                conexion.Open();
                cad = "Conexion Abierta";
            }
            catch (Exception t)
            {
                conexion = null;
                cad = "ERROR: " + t.Message;
            }
        }
        public void Insertar(string consulta,  ref string  letrero)
        {
         
            SqlConnection carreteria = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            carreteria.ConnectionString = "data source= " + ServidorSQL + "; Initial catalog= " + BD + "; Integrated security=true";
            try
            {
               /* carreteria.Open();
                carrito.CommandText = consulta;
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                System.IO.MemoryStream ms = new MemoryStream();
                foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                carrito.Parameters["@foto"].Value = ms.GetBuffer();
                letrero = "conexion abierta ";
                //carrito.CommandText = " insert into Alumno (nombre,edad,sexo,redsocial,id_grupo, foto )Values('"+ nombre +"','" + edad + "','" + sexo + "','" + red + "','" +  id + "','"  + foto + "')";
                carrito.Connection = carreteria;
                int x = carrito.ExecuteNonQuery();
                letrero = "Registro insertado";
                carreteria.Close();
                */

                carreteria.Open();
                carrito.Connection = carreteria;
                carrito.CommandText = consulta;
              /*  carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                System.IO.MemoryStream ms = new MemoryStream();
                foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                carrito.Parameters["@foto"].Value = ms.GetBuffer();*/
                carrito.ExecuteNonQuery();
                letrero = "Registro insertado";
                carreteria.Close();
            }
            catch (Exception t)
            {
                carreteria = null;
                letrero = "Error : " + t.Message;
            }

        
        }
        public void Mostrar(ListBox lista, ref string cad, string tabla )
        {
            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            SqlDataReader contenedor;
            carretera.ConnectionString = "data source= " + ServidorSQL + "; Initial catalog= " + BD + "; Integrated security=true";
            try
            {
                carretera.Open();
                carrito.CommandText = "SELECT  * FROM "  + tabla;
                carrito.Connection = carretera;
                contenedor = carrito.ExecuteReader();
                while (contenedor.Read())
                {
                        lista.Items.Add(contenedor[0].ToString() + " , " +  contenedor[1].ToString() + " , " + contenedor[2].ToString() );//x columnas **** new ListItem(
                }
                carretera.Close();
                cad = "Consulta realizada";
            }
            catch (Exception t)
            {
                cad = t.Message;
            }
        }

        public void MostrarAVG(ListBox lista, ref string cad, int alumno, int materia )
        {
            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            SqlDataReader contenedor;
            carretera.ConnectionString = "data source= " + ServidorSQL + "; Initial catalog= " + BD + "; Integrated security=true";
            try
            {
                carretera.Open();
                carrito.CommandText = "Select  avg(promedio) from toma where clave_alumnoT = " + alumno + "and clave_materiaT= " + materia;
                carrito.Connection = carretera;
                contenedor = carrito.ExecuteReader();
                while (contenedor.Read())
                {
                    lista.Items.Add(contenedor[0].ToString());
                }
                carretera.Close();
                cad = "Consulta realizada";
            }
            catch (Exception t)
            {
                cad = t.Message;
            }
        }


        public void MostrarAVG2(ListBox lista, ref string cad, int alumno)
        {
            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            SqlDataReader contenedor;
            carretera.ConnectionString = "data source= " + ServidorSQL + "; Initial catalog= " + BD + "; Integrated security=true";
            try
            {
                carretera.Open();
                carrito.CommandText = "Select  avg(promedio) from toma where clave_alumnoT = " + alumno;
                carrito.Connection = carretera;
                contenedor = carrito.ExecuteReader();
                while (contenedor.Read())
                {
                    lista.Items.Add(contenedor[0].ToString());
                }
                carretera.Close();
                cad = "Consulta realizada";
            }
            catch (Exception t)
            {
                cad = t.Message;
            }
        }


        public void Procedimiento_almacenado(TextBox lis, int lclv_al, int clave_materia, ref string cad)
        {
            SqlConnection carretera = new SqlConnection();

            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated security=true";

            try
            {
                carretera.Open(); //
                //pongo nombre de mi procedimiento almacenado
                string storeprocedure = "Calcular_el_promedio";
                SqlCommand carrito = new SqlCommand(storeprocedure, carretera); //coloco nombre aplicacion y conexion
                carrito.CommandType = CommandType.StoredProcedure; // le hago saber que es procedimiento almacenado
                SqlParameter ValorRetorno = new SqlParameter("@promedio", SqlDbType.Decimal); //tipo de elemento que devolvera
                ValorRetorno.Direction = ParameterDirection.ReturnValue; //retorna el valor
                //paso de parametros
                carrito.Parameters.Add(ValorRetorno); //retorna el valor 
                carrito.Parameters.AddWithValue("@clave_alumno", lclv_al);
                carrito.Parameters.AddWithValue("@clave_materia", clave_materia); // parametros de entrada

                //asignamos el valor de retorno

                carrito.ExecuteScalar(); //termina la consulta
                carretera.Close();
                double i = Convert.ToDouble(ValorRetorno.Value);
                //float i = Convert.ToSingle(ValorRetorno.Value);

                //ValorRetorno.Value = "@promedio";

                lis.Text = Convert.ToString(i);
                //[Variable procedimiento almacenado.]
                cad = "PROMEDIO";
            }
            catch (Exception t)
            {
                carretera = null;
                cad = "ERROR: " + t.Message;
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
                carrito.CommandText = "Delete from Alumno where no_control='" +
                no_control + "'";
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
            catch(Exception t)
            {
                carreteria = null;
                mensaje = "ERROR: " + t.Message;

            }
        }

        public System.Data.DataSet ConsultaDataset2(SqlConnection cna, string consulta, ref string mensaje)
        {
            System.Data.DataSet resultado = new System.Data.DataSet();
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();

            carrito.Connection = cna;
            carrito.CommandText = consulta;
            trailer.SelectCommand = carrito;
            try 
            {
                trailer.Fill(resultado, "miconsulta");
                mensaje = "Consulta correcta";
            }
            catch(Exception t)
            {
                resultado = null;
                mensaje = "Error" + t.Message;
            }
            cna.Close();
            cna.Dispose();
            return resultado;
        }
        public void CargarImagen(PictureBox pbx)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                pbx.Image = Image.FromFile(dialog.FileName);
        }

        public SqlConnection ConsultaDataSet(ref String mensaje, DataGridView data, string sentenciaSQL)
        {

            SqlConnection carretera = new SqlConnection();
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            System.Data.DataSet resultado = new System.Data.DataSet();
            carretera.ConnectionString =
             "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated Security=true";

            carretera.Open();
            carrito.Connection = carretera;
            carrito.CommandText = sentenciaSQL;
            trailer.SelectCommand = carrito;
            try
            {
                trailer.Fill(resultado);
                data.DataSource = resultado.Tables[0];
                //Tamaño de cada columna
                mensaje = "Consulta fue correcta en el DS";
            }
            catch (Exception w)
            {
                resultado = null;
                mensaje = "ERROR: " + w.Message;
            }
            return carretera;
        }
    public void Insertar_y_Actualizar_Registro(ref string mensaje, string sentenciaSQL, PictureBox img)
        {
            SqlConnection carretera = new SqlConnection(); carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated Security=true"; SqlCommand carrito = new SqlCommand();
            try
            {
                carretera.Open(); 
                carrito.Connection = carretera;
                carrito.CommandText = sentenciaSQL;
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                System.IO.MemoryStream ms = new MemoryStream();
                img.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                carrito.Parameters["@foto"].Value = ms.GetBuffer();
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

        public void PromedioGeneral(TextBox lis, int lclv_al, ref string cad)
        {
            SqlConnection carretera = new SqlConnection();

            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated security=true";

            try
            {
                // se abre la conexion
                carretera.Open(); // abro conexion
                //pongo nombre de mi procedimiento almacenado
                string storeprocedure = "CalcularPorMateria";
                SqlCommand carrito = new SqlCommand(storeprocedure, carretera); //coloco nombre aplicacion y conexion
                carrito.CommandType = CommandType.StoredProcedure; // le hago saber que es procedimiento almacenado
                SqlParameter ValorRetorno = new SqlParameter("@promedio", SqlDbType.Decimal); //tipo de elemento que devolvera
                ValorRetorno.Direction = ParameterDirection.ReturnValue; //retorna el valor
                //paso de parametros
                carrito.Parameters.Add(ValorRetorno); //se especifica add para valor retornar
                carrito.Parameters.AddWithValue("@clave_alumno", lclv_al);
               
                //asignamos el valor de retorno

                carrito.ExecuteScalar(); //termina la consulta
                carretera.Close(); //cerrar seccion
                                   //transformo parametro retornado double
                double i = Convert.ToDouble(ValorRetorno.Value);
                //float i = Convert.ToSingle(ValorRetorno.Value);

                //ValorRetorno.Value = "@promedio";

                lis.Text = "EL PROMEDIO GENERAL ES " + Convert.ToString(i);
                //[Variable procedimiento almacenado.]

            }
            catch (Exception t)
            {
                carretera = null;
                cad = "ERROR: " + t.Message;
            }


        }


        public void Paso_parametros(TextBox lis, int lclv_al, int clave_materia, ref string cad)
        {
            SqlConnection carretera = new SqlConnection();

            carretera.ConnectionString = "data source=" + ServidorSQL + "; Initial Catalog=" + BD + "; Integrated security=true";

            try
            {
                // se abre la conexion
                carretera.Open(); // abro conexion
                //pongo nombre de mi procedimiento almacenado
                string storeprocedure = "CalcularPorMateriaIndividual";
                SqlCommand carrito = new SqlCommand(storeprocedure, carretera); //coloco nombre aplicacion y conexion
                carrito.CommandType = CommandType.StoredProcedure; // le hago saber que es procedimiento almacenado
                SqlParameter ValorRetorno = new SqlParameter("@promedio", SqlDbType.Decimal); //tipo de elemento que devolvera
                ValorRetorno.Direction = ParameterDirection.ReturnValue; //retorna el valor
                //paso de parametros
                carrito.Parameters.Add(ValorRetorno); //se especifica add para valor retornar
                carrito.Parameters.AddWithValue("@clave_alumno", lclv_al);
                carrito.Parameters.AddWithValue("@clave_materia", clave_materia); // parametros de entrada

                //asignamos el valor de retorno

                carrito.ExecuteScalar(); //termina la consulta
                carretera.Close(); //cerrar seccion
                                   //transformo parametro retornado double
                double i = Convert.ToDouble(ValorRetorno.Value);
                //float i = Convert.ToSingle(ValorRetorno.Value);

                //ValorRetorno.Value = "@promedio";

                lis.Text = "EL PROMEDIO ES " + Convert.ToString(i);
                //[Variable procedimiento almacenado.]

            }
            catch (Exception t)
            {
                carretera = null;
                cad = "ERROR: " + t.Message;
            }


        }

    }
}