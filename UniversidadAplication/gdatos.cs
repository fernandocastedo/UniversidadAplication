using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadAplication
{
    public class gdatos
    {
        private string cadenaConexion = @"Data Source = FERCASTEDO; Initial Catalog = UniversidadDB2; Integrated Security = True";


        public DataTable EjecutarConsulta(string consulta)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Método para ejecutar consultas con parámetros
        public DataTable EjecutarConsultaConParametros(string consulta, SqlParameter[] parametros)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.Parameters.AddRange(parametros);  // Añadir los parámetros al comando
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Método para ejecutar comandos sin resultados (Insert, Update, Delete)
        public void EjecutarComando(string comando)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(comando, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
