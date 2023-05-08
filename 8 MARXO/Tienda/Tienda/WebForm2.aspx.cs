using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        Funciones_login objeto = new Funciones_login();
        protected void Page_Load(object sender, EventArgs e)
        {
            string w = "";
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            objeto.Conectar(ref w);

            string variablerec = Request.QueryString.Get("Myvariable2");
            string mensaje = "";
            NombreUsuario.Text = variablerec;
            objeto.mostrar_datosImageLeonardo(Image1, NombreUsuario.Text, ref mensaje);
         
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable2");
            Response.Redirect("WebForm1.aspx?Myvariable2=" + variablerec);


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("iniciar_seccion.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mens = "";
            string setencia = "select * from categoria";
            objeto.mostrar_datosLeonardo(GridView1,  ref mens, setencia);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mens = "";

            string setencia = "select * from rol";
            objeto.mostrar_datosLeonardo(GridView2, ref mens, setencia);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mens = "";

            string setencia = "select * from permiso";
            objeto.mostrar_datosLeonardo(GridView3, ref mens, setencia);

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mens = "";

            string setencia = "select nombre,marca,status,origen,descripcion,cantidades_existentes,precio,unidad_de_medidas from Productos";
            objeto.mostrar_datosLeonardo(GridView3, ref mens, setencia);

        }

        protected void Button8_Click(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable2");

            objeto.obtener_id_usuario(ref mensaje, variablerec, ref idusu);
            string setencia = " select numero_tarjeta,cvc,cvv,saldo,fecha_vencimiento from tarjeta where id_usuarioo=" +  idusu  ;
              objeto.mostrar_datosLeonardo(GridView2, ref mensaje, setencia);
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable2");
            Response.Redirect("Compras.aspx?Myvariable2=" + variablerec);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable2");

            objeto.obtener_id_usuario(ref mensaje, variablerec, ref idusu);
            string setencia = "select id_producto,total_compra,fecha_compra from compra where id_usuario = " + idusu ;
            objeto.mostrar_datosLeonardo(GridView4, ref mensaje, setencia);
        }
    }
}