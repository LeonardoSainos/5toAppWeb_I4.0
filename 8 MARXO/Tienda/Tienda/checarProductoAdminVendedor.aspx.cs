using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class checarProductoAdminVendedor : System.Web.UI.Page
    {
        Funciones_login obj = new Funciones_login();
        protected void Page_Load(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            string mensaje = "";
            string l = "";
            obj.Consulta_imagen(Repeater1, ref mensaje);


        }
      
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
          
                string PkID = Convert.ToString(e.CommandArgument);
                string cantidad = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "nombre"));
                cantidad = txtnomproducto.Text;
            
        }

        protected void btninsertarproducto_Click(object sender, EventArgs e)
        {

            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            //  Obtener datos de la imagen
            int tam = FileUpload2.PostedFile.ContentLength;
            byte[] imgenOriginal = new byte[tam];
            FileUpload2.PostedFile.InputStream.Read(imgenOriginal, 0, tam);
            System.Drawing.Bitmap imagenOriginalBinaria = new System.Drawing.Bitmap(FileUpload2.PostedFile.InputStream);
            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(imgenOriginal);
            Image1.ImageUrl = ImagenDataURL64;
            //  Insertar en la BD
            string cadena = "";
            string mensaje = "";
            obj.Conectar(ref cadena);

            obj.ObtenerProductoImagen_Insertar(ref mensaje, txtnomproducto.Text, txtmarca.Text, txtstatus.Text, txtOrigen.Text, txtdescripcion.Text, txtexistencia.Text, Convert.ToInt32(txtusuario.Text), Convert.ToInt32(txtcategoria.Text), Convert.ToSingle(txtprecio.Text), txtunidadmedida.Text, imgenOriginal);
        }

        protected void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            //  Obtener datos de la imagen
            int tam = FileUpload2.PostedFile.ContentLength;
            byte[] imgenOriginal = new byte[tam];
            FileUpload2.PostedFile.InputStream.Read(imgenOriginal, 0, tam);
            System.Drawing.Bitmap imagenOriginalBinaria = new System.Drawing.Bitmap(FileUpload2.PostedFile.InputStream);
            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(imgenOriginal);
            Image1.ImageUrl = ImagenDataURL64;
            //  Insertar en la BD
            string cadena = "";
            string mensaje = "";
            obj.actualizarproducto(ref mensaje,Convert.ToInt32(txtid_producto.Text), txtnomproducto.Text, txtmarca.Text, txtstatus.Text, txtOrigen.Text, txtdescripcion.Text, txtexistencia.Text, Convert.ToInt32(txtusuario.Text), Convert.ToInt32(txtcategoria.Text), Convert.ToSingle(txtprecio.Text), txtunidadmedida.Text, imgenOriginal);
        }

        protected void btneliminarproducto_Click(object sender, EventArgs e)
        {
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            //  Obtener datos de la imagen
            //  Insertar en la BD
            string cadena = "";
            string mensaje = "";
            obj.Eliminarproducto(Convert.ToInt32(txtid_producto.Text),ref mensaje);
        }
    }
}