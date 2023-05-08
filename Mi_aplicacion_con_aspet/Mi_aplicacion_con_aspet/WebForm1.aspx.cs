using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Input;

namespace Mi_aplicacion_con_aspet
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        WEBFORM obj = new WEBFORM();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string w = "";
 //           obj.BD = "Fotos";
              obj.BD = "UTP";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            Label1.Text= w;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //obj.BD = "Fotos";

                      obj.BD = "UTP";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mens = "";
            string setencia= "select * from Alumno";
            obj.mostrar_datos(GridView1,ref mens, setencia);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           // Obtener datos de la imagen
            int tam = FileUpload1.PostedFile.ContentLength;
            byte[] imgenOriginal = new byte[tam];
            FileUpload1.PostedFile.InputStream.Read(imgenOriginal, 0, tam);
            System.Drawing.Bitmap imagenOriginalBinaria = new System.Drawing.Bitmap(FileUpload1.PostedFile.InputStream);
            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(imgenOriginal);
            Image1.ImageUrl = ImagenDataURL64;
            string cadena = "";
          //  obj.BD = "Fotos";

                    obj.BD = "UTP";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref cadena);
            Label1.Text = cadena;
            //  string sentenciasql = "Insert into Persona Values('" + txtnombre.Text + "'," + "@foto)";
            string mensaje = "";
            obj.ObtenerImagen_Insertar(ref mensaje, txtNombre.Text,Convert.ToInt32(txtedad.Text) ,imgenOriginal);
            Label1.Text = mensaje;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string cadena = "";
           // obj.BD = "Fotos";

                  obj.BD = "UTP";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref cadena);
            Label1.Text = cadena;
            string mensaje = "";
            obj.Eliminar(Convert.ToInt32(txtId.Text),ref mensaje);
            Label1.Text = mensaje;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string cadena = "";
//            obj.BD = "Fotos";

            obj.BD = "UTP";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref cadena);
            Label1.Text = cadena;

            string mensaje = "";
            string sentenciaSQL = "update alumno set nombre = ' " + txtNombre.Text + "', edad = '" + Convert.ToInt32(txtedad.Text) + "', sexo = '" + txtSexo.Text + " ', redsocial ='" + txtRed.Text + "',id_grupo = '"+ txtGrupo.Text + " ' where no_control = " + " ' " + Convert.ToInt32(txtId.Text) +  "' ";
            obj.Actualizar_registro(sentenciaSQL, ref mensaje);
            Label1.Text = mensaje;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            string w = "";
//            obj.BD = "Fotos";

              obj.BD = "UTP";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            string mensaje = "";
            //  string savePath= @"C:\MemoriaMorada_2020\Enero_Abril_2021\AplicacionesWebParaI4.0\MiAplicacionWeb\MiAplicacionWeb\imagenes\";
            string savePath = @"~/Imagenes/";
            string filename = FileUpload1.FileName;
            savePath += filename;
           lblRuta.Text = savePath;
            string sentenciaSQL = "Insert into prueba (nombre,edad,foto) Values('" + txtNombre.Text + "','" +Convert.ToInt32(txtedad.Text) + "','" + lblRuta.Text + "')";

            obj.Insertar_Foto_URL(ref mensaje,sentenciaSQL) ;
            Label1.Text = mensaje;
            
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string cadena = "";
  //          obj.BD = "Fotos";

                obj.BD = "UTP";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref cadena);
            Label1.Text = cadena;
            string mensaje = "";
            string sentencia = "select no_control, nombre,edad, foto from prueba";
            obj.mostrar_datos(GridView1, ref mensaje, sentencia); 


        }
    }
}