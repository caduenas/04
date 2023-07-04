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
    public partial class ActualizarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conn.Open();
            int id = int.Parse(IDusuario.Text);
            string nombre = nombreUser.Text;
            string correo = correoE.Text;
            string sql = @"UPDATE asesorados SET nombre_asesorado = @nombre, correo_asesorado = @correo WHERE id_asesorados = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@id", id);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowsAffected > 0)
            {
                resultadoLabel.Text = "Los campos se actualizaron correctamente.";
            }
            else
            {
                resultadoLabel.Text = "Hubo un error al actualizar los campos.";
            }


        }

        protected void volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_administrador.aspx");
        }
    }
}