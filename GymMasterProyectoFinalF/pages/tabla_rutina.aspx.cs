using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMasterProyectoFinalF.pages
{
    public partial class tabla_rutina : System.Web.UI.Page
    {
        public class Usuario
        {
            public string NombreRutina { get; set; }
            public string NombreEjercicio { get; set; }
            public string Repeticiones { get; set; }
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
            string query = "SELECT a.nombre_asesorado, r.nombre_rutina, e.nombre_ejercicio, e.Repeticiones " +
                           "FROM asesorados AS a " +
                           "INNER JOIN rutinas AS r ON a.id_rutina = r.id_rutina " +
                           "INNER JOIN ejercicios_rutina AS er ON r.id_rutina = er.id_rutina " +
                           "INNER JOIN ejercicios AS e ON er.id_ejercicio = e.id_ejercicio " +
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
                        usuario.NombreRutina = reader["nombre_rutina"].ToString();
                        usuario.NombreEjercicio = reader["nombre_ejercicio"].ToString();
                        usuario.Repeticiones = reader["Repeticiones"].ToString();
                        usuarios.Add(usuario);
                        Label1.Text = reader["nombre_asesorado"].ToString() + " tu rutina es" + " " + reader["nombre_rutina"].ToString();
                    }

                    reader.Close();
                }
            }

            return usuarios;
        }
    }
}