using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class WebForm1 : System.Web.UI.Page
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

        protected void Button5_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string w = "";
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            objeto.Conectar(ref w);
            string mensaje = "";
              string variablerec = Request.QueryString.Get("Myvariable2");
            int idusu = 0;
            objeto.obtener_id_usuario(ref mensaje, variablerec, ref idusu);
            string sentenciaSql = "insert into Tarjeta(numero_tarjeta, cvv, saldo, fecha_vencimiento, id_usuarioo) values ('" + TextBox1.Text + " ', ' " + Convert.ToInt32(TextBox2.Text) + "', ' " + Convert.ToDouble(TextBox3.Text) + " ','" + TextBox4.Text + "' , '" + idusu + " ' )"; 
            

        

            objeto.InsertarGeneral(sentenciaSql, ref mensaje);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable2");
            Response.Redirect("WebForm2.aspx?Myvariable2=" + variablerec);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable2");
            Response.Redirect("Compras.aspx?Myvariable2=" + variablerec);
        }

        protected void Button13_Click(object sender, EventArgs e)
        {

            Response.Redirect("login.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {

            Response.Redirect("iniciar_seccion.aspx");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            string w = "";
            objeto.BD = "tienda_definiitiva";
            objeto.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            objeto.Conectar(ref w);
            string mensaje = "";
            string variablerec = Request.QueryString.Get("Myvariable2");
            int idusu = 0;
            objeto.obtener_id_usuario(ref mensaje, variablerec, ref idusu);
            string sentenciaSql = "insert into Tarjeta(numero_tarjeta, cvc, saldo, fecha_vencimiento, id_usuarioo) values ('" + TextBox1.Text + " ', ' " + Convert.ToInt32(TextBox2.Text) + "', ' " + Convert.ToDouble(TextBox3.Text) + " ','" + TextBox4.Text + "' , '" + idusu + " ' )";

            objeto.InsertarGeneral(sentenciaSql, ref mensaje);
        }
    }
}