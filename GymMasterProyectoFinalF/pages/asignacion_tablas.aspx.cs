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
    public partial class asignacion_tablas : System.Web.UI.Page
    {
        public class Usuario
        {
            public int id_asesorados { get; set; } // Agrega esta propiedad
            public string nombre_asesorados { get; set; }
            public string Email { get; set; }
            public int Edad { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Usuario> usuarios = ObtenerUsuarios();

                // Asignar los datos al GridView    
                GridView1.DataSource = usuarios;
                GridView1.DataBind();
            }
        }


        protected void btnVer_Click(object sender, EventArgs e)
        {
            // Obtén el botón que se activó
            Button btnVer = (Button)sender;

            // Obtén la fila que contiene el botón
            GridViewRow row = (GridViewRow)btnVer.NamingContainer;

            // Obtén el índice de la fila
            int rowIndex = row.RowIndex;

            if (GridView1.Rows.Count > 0 && rowIndex >= 0 && rowIndex < GridView1.Rows.Count)
            {
                // Obtén el ID del usuario correspondiente al registro seleccionado
                int idUsuario = Convert.ToInt32(GridView1.DataKeys[rowIndex].Value);

                // Crea una cookie y establece el valor del ID del usuario
                HttpCookie cookie = new HttpCookie("Asesorado_seleccionado", idUsuario.ToString());
                Response.Cookies.Add(cookie);

                // Redirige a otra página o realiza cualquier otra acción necesaria
                Response.Redirect("edicion_tablas.aspx");
            }
            else
            {
                // Maneja el caso cuando el GridView no tiene filas o el índice está fuera de rango
            }
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

    }
}