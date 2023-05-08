using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class Compras : System.Web.UI.Page
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
            string variablerec = Request.QueryString.Get("Myvariable2");
            NombreUsuario.Text = variablerec;
            obj.mostrar_datos(Image1, NombreUsuario.Text, ref mensaje);
        }

        protected void BtnComprar_Click(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            string mensaje = "";
            int id = 0;
            int encontrado = 0;
            string usuario = "";
            float precio = 0;
            float encontradoprecio = 0;
            string variablerec = Request.QueryString.Get("Myvariable2");
            int idusu = 0;
            obj.obtener_id_usuario(ref mensaje, variablerec, ref idusu);

            obj.BuscarProducto(Image3, txtnombre.Text, ref id, ref precio, ref mensaje);
            encontrado = id;
            encontradoprecio = precio;
            String confirma2 = "";
            obj.Buscar2(GridView1, txtnombre.Text, ref mensaje);
      obj.Paso_parametros(ref mensaje, idusu, encontradoprecio, encontrado, Convert.ToInt32(txtpagar.Text)) ;
            CONFIRMAAA.Text = confirma2 + mensaje;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
           
            string mensaje = "";
            int id = 0;
            int encontrado = 0;
            string usuario = "";
            float precio = 0;
            float encontradoprecio = 0;
            obj.BuscarProducto(Image3, txtnombre.Text, ref id, ref precio, ref mensaje);
            encontrado = id;
            encontradoprecio = precio;
            obj.Buscar2(GridView1, txtnombre.Text, ref mensaje);
         
            obj.compra(ref id, encontrado, ref precio, encontradoprecio);
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable2");
            Response.Redirect("WebForm2.aspx?Myvariable2=" + variablerec);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable2");
            Response.Redirect("WebForm1.aspx?Myvariable2=" + variablerec);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("iniciar_seccion.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}