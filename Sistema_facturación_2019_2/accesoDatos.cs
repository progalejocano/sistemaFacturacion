using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Sistema_facturación_2019_2
{
    class accesoDatos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader lectorDatos = null;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void abrirDB()
        {
            try
            {
                conexion = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=dbFacturacion; Integrated Security=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Abrir " + ex);
            }
        }

        public void cerrarDB()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cerrar " + ex);
            }
        }

        public string validarUsuario(string strUsuario, string strClave)
        {
            try
            {
                string strEmpleado = "";
                string sentencia = $"SELECT e.strNombre, e.IdRolEmpleado FROM tblSeguridad AS s JOIN tblEmpleado AS e ON s.idEmpleado=e.idEmpleado WHERE strUsuario= '{strUsuario}' AND strClave='{strClave}'";

                abrirDB();
                cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 10;
                lectorDatos = cmd.ExecuteReader();

                while (lectorDatos.Read())
                {
                    strEmpleado = Convert.ToString(lectorDatos.GetValue(0));
                }

                if (lectorDatos != null)
                {
                    lectorDatos.Close();
                }

                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA: " + ex);
                return "";
            }
        }

        public DataTable cargarTabla(string tabla, string strCondicion)
        {
            try
            {
                abrirDB();
                string sql = "SELECT * FROM " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(sql, conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                cerrarDB();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Consulta " + ex);
                return null;
            }
        }

        public string ejecutarComando(string sentencia)
        {
            string salida = "Los datos se actuailizaron correctamente";
            try
            {
                int retornado;
                abrirDB();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                cerrarDB();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
                return salida;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo insercion: " + ex);
                return salida;
            }
            
        }

        public DataTable ejecutarComandoDatos(string cmd)
        {
            try
            {
                abrirDB();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                cerrarDB();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo Operacion: " + ex);
                return null;
            }
        }
    }
}
