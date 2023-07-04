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
    public partial class EliminarEntrenadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conn.Open();
            int id = int.Parse(IDentrenador.Text);
            string contras = contrasena.Text;
            string sql = @"DELETE FROM entrenadores WHERE id_entrenador = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                resultadoLabel.Text = "El entrenador se ha eliminado correctamente.";
            }
            else
            {
                resultadoLabel.Text = "Hubo un error al eliminar el entrenador.";
            }

        }

        protected void volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_administrador.aspx");
        }
    }
}