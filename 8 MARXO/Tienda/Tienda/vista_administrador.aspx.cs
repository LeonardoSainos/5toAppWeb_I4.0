using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class vista_administrador : System.Web.UI.Page
    {
        Funciones_login obj = new Funciones_login();

   
        protected void Page_Load(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);

      
            string variablerec = Request.QueryString.Get("Myvariable");
            string mensaje = "";
            Label12.Text = variablerec;
            obj.mostrar_datos(Image2, Label12.Text, ref mensaje);
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            string mensaje = "";
            obj.mostrar_datos2(GridView1, ref mensaje);
            


        }

        protected void btnusuario_Click(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            string mensaje = "";
            obj.mostrar_datos(Image1, txtnombre.Text, ref mensaje);
            obj.Buscar(GridView1, txtnombre.Text, ref mensaje);
       
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            string mensaje = "";

            int tam = FileUpload1.PostedFile.ContentLength;
            byte[] imgenOriginal = new byte[tam];
            FileUpload1.PostedFile.InputStream.Read(imgenOriginal, 0, tam);
            System.Drawing.Bitmap imagenOriginalBinaria = new System.Drawing.Bitmap(FileUpload1.PostedFile.InputStream);
            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(imgenOriginal);
            Image1.ImageUrl = ImagenDataURL64;
            obj.Actualizar(ref mensaje, txtnombre1.Text, txtapellidos.Text, Convert.ToInt32(txtidrol.Text),Convert.ToInt32(txtpermiso.Text),txtcorreo.Text, txtcontraseña.Text,Convert.ToInt32( txtid_usuario.Text), imgenOriginal);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void butneliminar_Click(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            string mensaje = "";
            obj.Eliminar(txtnombre.Text, ref mensaje);

        }

        protected void MyMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("iniciar_seccion.aspx");
        }

        protected void btncontrol_Click(object sender, EventArgs e)
        {
            Response.Redirect("checarProductoAdminVendedor.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable");
            Response.Redirect("Carrito.aspx?Myvariable=" + variablerec);
        }
    }
}