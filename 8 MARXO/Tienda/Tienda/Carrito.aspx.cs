using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class carrito : System.Web.UI.Page
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
            NombreUsuario.Text = variablerec;
            obj.mostrar_datosImageLeonardo(Image2, NombreUsuario.Text, ref mensaje);

            /* obj.Consulta_imagen(Repeater1, ref mensaje);
             txtprecioproducto.Enabled = false;
             txtpagar.Enabled = false;*/
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {/*
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
            obj.BuscarProducto(Image1, txtnombre.Text, ref id, ref precio, ref mensaje);
            encontrado = id;
            encontradoprecio = precio;
          txtprecioproducto.Text=Convert.ToString( precio);
            obj.Buscar2(GridView1, txtnombre.Text, ref mensaje);
            txtpagar.Enabled = true;*/
     
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {/*
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
            obj.BuscarProducto(Image1, txtnombre.Text, ref id, ref precio, ref mensaje);
            encontrado = id;
            encontradoprecio = precio;
            obj.Buscar2(GridView1, txtnombre.Text, ref mensaje);
            obj.compra(ref id, encontrado, ref precio, encontradoprecio);
            
            */
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            float venta = 0;
            string mensaje = "", letrero="Tu venta del dia seleccionado es : $";

            //  string sentenciaSAQL = "Select sum(total_compra) as Venta_del_dia  from compra where MONTH(fecha_compra)=" + Convert.ToInt32(TextBox2.Text) + " and (YEAR(fecha_compra)= " + Convert.ToInt32(TextBox3.Text) + " and Day(fecha_compra) = "+ Convert.ToInt32(TextBox1.Text) + ")";
            //obj.VentasDiarias(sentenciaSAQL, ref mensaje);
            //            VENTAS.Text = letrero + mensaje;
            obj.VentaDiaria(ref mensaje, ref venta, Convert.ToInt32(TextBox3.Text),Convert.ToInt32( TextBox2.Text),Convert.ToInt32( TextBox1.Text));
            VENTAS.Text = letrero + venta;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("iniciar_seccion.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            string mensaje = "";
            int idusu = 0;
            string variablerec = Request.QueryString.Get("Myvariable");
            Response.Redirect("vista_administrador.aspx?Myvariable=" + variablerec);
        }        
    }
}