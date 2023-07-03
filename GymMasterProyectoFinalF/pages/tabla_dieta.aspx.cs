using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMasterProyectoFinalF.pages
{
    public partial class tabla_dieta : System.Web.UI.Page
    {
        public class Usuario
        {
            public string NombreAsesorado { get; set; }
            public string NombreDieta { get; set; }
            public string NombreAlimento { get; set; }
            public string CaloriasAlimento { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Usuario> usuarios = ObtenerUsuarios();
                GridView1.DataSource = usuarios;
                GridView1.DataBind();
            }
        }

        protected List<Usuario> ObtenerUsuarios()
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

            List<Usuario> usuarios = new List<Usuario>();

            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            string query = "SELECT a.nombre_asesorado, d.objetivo, al.nombre_alimento, al.Calorias_alimento " +
                           "FROM asesorados AS a " +
                           "INNER JOIN dietas AS d ON a.id_dieta = d.id_dieta " +
                           "INNER JOIN alimentos_dieta AS ad ON d.id_dieta = ad.id_dieta " +
                           "INNER JOIN alimentos AS al ON ad.id_alimento = al.id_alimento " +
                           "WHERE a.id_asesorados = @id_asesorados";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_asesorados", userId);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.NombreAsesorado = reader["nombre_asesorado"].ToString();
                        usuario.NombreDieta = reader["objetivo"].ToString();
                        usuario.NombreAlimento = reader["nombre_alimento"].ToString();
                        usuario.CaloriasAlimento = reader["Calorias_alimento"].ToString();
                        usuarios.Add(usuario);
                        Label1.Text = reader["nombre_asesorado"].ToString() + " tu rutina es" + " " + reader["objetivo"].ToString();
                    }

                    reader.Close();
                }
            }

            return usuarios;
        }
    }
}