using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace Tienda
{
    public partial class iniciar_seccion : System.Web.UI.Page
    {
        Funciones_login obj = new Funciones_login();
        protected void Page_Load(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
        }
        public System.Web.SessionState.HttpSessionState Session { get; }
        protected void Btniniciarseccion_Click(object sender, EventArgs e)
        {
            string w = "";
            obj.BD = "tienda_definiitiva";
            obj.ServidorSQL = @"LAPTOP-MOUFH7RA\SQLEXPRESS";
            obj.Conectar(ref w);
            string mensaje = "";
            string usuario = "";
            string contaseña = "";
            string nn = "";
            obj.autenticar1( ref mensaje,ref nn,ref usuario,ref contaseña, txtnombre.Text, txtcontraseña.Text);
           
            if(usuario== "Administrador")
            {
                 if(contaseña== "admin")
                {
                    
                    Response.Redirect("vista_administrador.aspx?Myvariable="+ usuario);
                }

            }
            else if (usuario != "")
                    {
                        if (usuario == txtnombre.Text)
                        {
                          if (contaseña == txtcontraseña.Text)
                            {
                               Response.Redirect("WebForm2.aspx?Myvariable2=" + usuario);
                 

                            }
                        }
                    }      
            else if(usuario=="")
            {
               
                Response.Redirect("login.aspx");
            }
            
           
        }

        protected void Btnregistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("login.aspx");
           
        }
    }
}