using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class login : System.Web.UI.Page
    {
        Funciones_login obj = new Funciones_login();
        protected void Page_Load(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            //  Obtener datos de la imagen
            int tam = FileUpload1.PostedFile.ContentLength;
            byte[] imgenOriginal = new byte[tam];
            FileUpload1.PostedFile.InputStream.Read(imgenOriginal, 0, tam);
            System.Drawing.Bitmap imagenOriginalBinaria = new System.Drawing.Bitmap(FileUpload1.PostedFile.InputStream);
            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(imgenOriginal);
            Image1.ImageUrl = ImagenDataURL64;
            //  Insertar en la BD
            string cadena = "";
            string mensaje = "";
            obj.Conectar(ref cadena);
            //  string sentenciasql = "Insert into Persona Values('" + txtnombre.Text + "'," + "@foto)";
            int idrol = 0;
            int idpermiso = 0;
            obj.ObtenerImagen_Insertar(ref mensaje, txtnombre.Text, Textapellidos.Text, idrol, idpermiso, Textcorreo.Text, txtcontraseña.Text, imgenOriginal);
        }

        protected void Btniniciarseccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("iniciar_seccion.aspx");
        }
    }
}