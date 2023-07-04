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
    public partial class pagina10 : System.Web.UI.Page
    {
        public class Usuario
        {
            public int id_asesorados { get; set; } // Agrega esta propiedad
            public string nombre_asesorados { get; set; }
            public string Email { get; set; }
            public int Edad { get; set; }
        }

        public class Entrenador
        {
            public int id_entrenador { get; set; } // Agrega esta propiedad
            public string nombre_entrenador { get; set; }
            public string Email { get; set; }
            public string Numero { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Usuario> usuarios = ObtenerUsuarios();

                // Asignar los datos al GridView    
                GridView1.DataSource = usuarios;
                GridView1.DataBind();

                List<Entrenador> entrenadores = ObtenerEntrenadores();

                // Asignar los datos al GridView    
                GridView2.DataSource = entrenadores;
                GridView2.DataBind();
            }
        



            
              



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
            string sql = "SELECT * FROM admins WHERE id_admin = @id_adminis";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_adminis", userId); // Agrega el parámetro y su valor
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            no_user.Text = reader["nombre_admin"].ToString();
            corre_user.Text = reader["correo_admin"].ToString();
            reader.Close();
            conn.Close(); // Recuerda cerrar la conexión



        }

     
        private List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            // Lógica para obtener los datos de la base de datos
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conn.Open();
            string sql = "SELECT id_asesorados, nombre_asesorado, correo_asesorado, edad FROM asesorados";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id_asesorados"]);
                string nombre = reader["nombre_asesorado"].ToString();
                string email = reader["correo_asesorado"].ToString();
                int edad = Convert.ToInt32(reader["edad"]);

                usuarios.Add(new Usuario()
                {
                    id_asesorados = id,
                    nombre_asesorados = nombre,
                    Email = email,
                    Edad = edad
                });
            }

            reader.Close();
            conn.Close();

            return usuarios;
        }







        private List<Entrenador> ObtenerEntrenadores()
        {
            List<Entrenador> entrenadores = new List<Entrenador>();

            // Lógica para obtener los datos de la base de datos
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conn.Open();
            string sql = "SELECT id_entrenador, nombre_entrenador, correo_entrenador, correo_entrenador, numero_entrenador FROM entrenadores";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id_entrenador"]);
                string nombre = reader["nombre_entrenador"].ToString();
                string email = reader["correo_entrenador"].ToString();
                string telefono = reader["numero_entrenador"].ToString();


                entrenadores.Add (new Entrenador()
                {
                    id_entrenador = id,
                    nombre_entrenador = nombre,
                    Email = email,
                    Numero = telefono
                });
            }

            reader.Close();
            conn.Close();

            return entrenadores;
        }

            protected void botonConsultar_Click(object sender, EventArgs e)
        {
            Response.Redirect("consultarUsuarios.aspx");
        }

        protected void botonInsertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarUsuarios.aspx");
        }

        protected void botonActualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActualizarUsuarios.aspx");
        }

        protected void botonEliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarUsuarios.aspx");
        }

        protected void botonConsultarEntrenadores_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarEntrenadores.aspx");
        }

        protected void botonInsertarEntrenadores_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarEntrenadores.aspx");
        }

        protected void botonActualizarEntrenadores_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActualizarEntreandores.aspx");

        }

        protected void botonEliminarEntrenadores_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarEntrenadores.aspx");
        }
    }
}
