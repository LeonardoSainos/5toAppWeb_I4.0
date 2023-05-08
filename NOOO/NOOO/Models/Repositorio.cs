using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace NOOO.Models
{
    public class Repositorio
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

      public void Add_Registro(Persona per )
        {

            SqlCommand com = new SqlCommand("AgregarPersona",con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nombre", per.propiedad_nombre);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

        public void update_Registro(Persona per)
        {
            SqlCommand com = new SqlCommand("actualizar", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nombre", per.propiedad_nombre);
            com.Parameters.AddWithValue("@id", per.propiedad_id);
              con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataSet MostrarPorID(int id)
        {
            SqlCommand com = new SqlCommand("mostrarUno", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
              com.Parameters.AddWithValue("@id",id);
            SqlDataAdapter nee = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            nee.Fill(ds);
            return ds;
            
        }
        public DataSet Mostrar_registros()
        {
            SqlCommand com = new SqlCommand("mostrarTodos", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
         //   com.Parameters.AddWithValue("@id", id);
            SqlDataAdapter nee = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            nee.Fill(ds);
            return ds;
        }

        public void Eliminar_registro(int id)
        {
            SqlCommand com = new SqlCommand("eliminar", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
             com.Parameters.AddWithValue("@id", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

    }
}