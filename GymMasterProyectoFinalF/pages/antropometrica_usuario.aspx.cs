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
    public partial class antropometrica_usuario : System.Web.UI.Page
    {
        string id_tabla_antropmetrica = "";
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

            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT a.nombre_asesorado, a.altura, a.peso, a.edad, ant.*
                       FROM asesorados a
                       INNER JOIN antropometrias ant ON a.id_antropometria = ant.id_antropometria
                       WHERE a.id_asesorados = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string nombreAsesorado = reader["nombre_asesorado"].ToString();
                    altura.Attributes["placeholder"] = reader["altura"].ToString();
                    peso.Attributes["placeholder"] = reader["peso"].ToString();
                    edad.Attributes["placeholder"] = reader["edad"].ToString();
                    // Obtener los datos de la tabla antropometria
                    id_tabla_antropmetrica = reader["id_antropometria"].ToString();
                    Bicep_D.Attributes["placeholder"] = reader["Bicep_derecho"].ToString();
                    Bicep_I.Attributes["placeholder"] = reader["Bicep_izquierdo"].ToString();
                    cadera.Attributes["placeholder"] = reader["Cadera"].ToString();
                    muslo_derecho.Attributes["placeholder"] = reader["Muslo_D"].ToString();
                    muslo_izquierdo.Attributes["placeholder"] = reader["Muslo_I"].ToString();
                    abdomen_bajo.Attributes["placeholder"] = reader["Abdomen_bajo"].ToString();
                    abdomen_medio.Attributes["placeholder"] = reader["Abdomen_medio"].ToString();
                    abdomen_alto.Attributes["placeholder"] = reader["Abdomen_alto"].ToString();

                    // Realiza las operaciones que necesites con los datos obtenidos
                }
                reader.Close();
            }
        }

        protected void btnCambiar_Click(object sender, EventArgs e)
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

            string altur = altura.Text;
            string pes = peso.Text;
            string eda = edad.Text;
            string sql = @"UPDATE asesorados SET altura = @altura, peso = @peso, edad = @edad WHERE id_asesorados = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@altura", altur);
            cmd.Parameters.AddWithValue("@peso", pes);
            cmd.Parameters.AddWithValue("@edad", eda);
            cmd.Parameters.AddWithValue("@id", userId);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                // La actualización se realizó correctamente
            }
            else
            {
                // No se pudo realizar la actualización
                // Maneja el caso en consecuencia
            }
            conn.Close();

            SqlConnection conne = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conne.Open();

            string id_antropometri = id_tabla_antropmetrica; // Asegúrate de que id_tabla_antropmetrica tenga el valor correcto
            string bic_d = Bicep_D.Text;
            string bic_i = Bicep_I.Text;
            string cader = cadera.Text;
            string muslo_de = muslo_derecho.Text;
            string muslo_iz = muslo_izquierdo.Text;
            string abdomen_ba = abdomen_bajo.Text;
            string abdomen_me = abdomen_medio.Text;
            string abdomen_al = abdomen_alto.Text;

            string sql1 = @"UPDATE antropometrias SET Bicep_derecho = @Bicep_derecho, Bicep_izquierdo = @Bicep_izquierdo, Cadera = @Cadera, Muslo_D = @Muslo_D, Muslo_I = @Muslo_I, Abdomen_bajo = @Abdomen_bajo, Abdomen_medio = @Abdomen_medio, Abdomen_alto = @Abdomen_alto WHERE id_antropometria = @id";
            SqlCommand cmd1 = new SqlCommand(sql1, conne);
            cmd1.Parameters.AddWithValue("@Bicep_derecho", bic_d);
            cmd1.Parameters.AddWithValue("@Bicep_izquierdo", bic_i);
            cmd1.Parameters.AddWithValue("@Cadera", cader);
            cmd1.Parameters.AddWithValue("@Muslo_D", muslo_de);
            cmd1.Parameters.AddWithValue("@Muslo_I", muslo_iz);
            cmd1.Parameters.AddWithValue("@Abdomen_bajo", abdomen_ba);
            cmd1.Parameters.AddWithValue("@Abdomen_medio", abdomen_me);
            cmd1.Parameters.AddWithValue("@Abdomen_alto", abdomen_al);
            cmd1.Parameters.AddWithValue("@id", id_antropometri);

            int rowsAffected1 = cmd1.ExecuteNonQuery();
            if (rowsAffected1 > 0)
            {
                // La actualización se realizó correctamente
                Response.Redirect("asignacion_tablas.aspx");
            }
            else
            {
                // No se pudo realizar la actualización
                // Maneja el caso en consecuencia
            }

            conne.Close();
        }

    }
}