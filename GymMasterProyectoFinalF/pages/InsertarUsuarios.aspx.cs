using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMasterProyectoFinalF.pages
{
    public partial class InsertarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botoninsertar_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conn.Open();
            string sql = @"INSERT INTO asesorados (contrasena_asesorado, nombre_asesorado, apellido_asesorado, numero_asesorado, correo_asesorado, Meta_Lograr, altura, peso, edad) 
                VALUES (@contras, @nombre, @apellido, @numero, @correo, @meta, @altura, @peso, @edad)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@contras", password.Text);
            cmd.Parameters.AddWithValue("@nombre", nombresComple.Text);
            cmd.Parameters.AddWithValue("@apellido", apellidosComple.Text);
            cmd.Parameters.AddWithValue("@numero", numero.Text);
            cmd.Parameters.AddWithValue("@correo", correoElect.Text);
            cmd.Parameters.AddWithValue("@meta", meta.Text);
            cmd.Parameters.AddWithValue("@altura", Convert.ToInt32(Altura.Text));
            cmd.Parameters.AddWithValue("@peso", Convert.ToInt32(Peso.Text));
            cmd.Parameters.AddWithValue("@edad", Convert.ToInt32(Edad.Text));

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            if (rowsAffected > 0)
            {
                resultadoLabel.Text = "El usuario se ha insertado correctamente.";
            }
            else
            {
                resultadoLabel.Text = "Hubo un error al insertar el usuario.";
            }


        }

        protected void volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_administrador.aspx");
        }
    }
}