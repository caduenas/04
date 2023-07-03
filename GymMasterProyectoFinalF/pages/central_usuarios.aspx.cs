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
    public partial class central_usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = "";
            HttpCookie cookie = Request.Cookies["UserId"];
            if (cookie != null)
            {
                userId = cookie.Value;
                // Utiliza el userId como necesites
            }
            else
            {
                // La cookie no existe, maneja el caso en consecuencia
            }
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conn.Open();
            string sql = "SELECT * FROM asesorados WHERE id_asesorados = @id_user";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_user", userId); // Agrega el parámetro y su valor
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            no_user.Text = reader["nombre_asesorado"].ToString();
            corre_user.Text = reader["correo_asesorado"].ToString();
            reader.Close();
            conn.Close(); // Recuerda cerrar la conexión

        }

        protected void tablaAntripo_Click(object sender, EventArgs e)
        {

        }
    }
}