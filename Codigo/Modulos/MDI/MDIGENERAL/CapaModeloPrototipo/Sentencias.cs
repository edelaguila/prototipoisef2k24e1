using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModeloPrototipo
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        public bool Guardar(string tabla, Dictionary<string, object> valores)
        {


            using (OdbcConnection conn = con.conexion())
            {
                string columnas = string.Join(", ", valores.Keys);
                string parametros = string.Join(", ", valores.Keys.Select(key => "?"));
                string consulta = $"INSERT INTO {tabla} ({columnas}) VALUES ({parametros})";

                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    foreach (var kvp in valores)
                    {
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }


        }

        public List<string> llenarCombo(string columna1, string tabla)
        {
            List<string> datos = new List<string>();
            try
            {

                string consulta = $"SELECT {columna1} FROM {tabla}";

                OdbcCommand command = new OdbcCommand(consulta, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader[columna1].ToString();
                    datos.Add(ID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return datos;

        }

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.conexion());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }

        public OdbcDataAdapter llenarDataGRID(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void Insertarasignacionalumno(string codigo_carrera, string codigo_sed, string codigo_jornada, string codigo_seccion, string codigo_aula, string codigo_curso, string carnet_alumno, double nota_asignacioncursoalumnos)
        {
            using (OdbcConnection connection = con.conexion())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insertar en la tabla tbl_asignacioncursosalumnos
                            string insertQuery = "INSERT INTO asignacioncursosalumnos (codigo_carrera,codigo_sed,codigo_jornada,codigo_seccion,codigo_aula,codigo_curso,carnet_alumno,nota_asignacioncursoalumnos) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@codigo_carrera", codigo_carrera);
                                cmd.Parameters.AddWithValue("@codigo_sed", codigo_sed);
                                cmd.Parameters.AddWithValue("@codigo_jornada", codigo_jornada);
                                cmd.Parameters.AddWithValue("@codigo_seccion", codigo_seccion);
                                cmd.Parameters.AddWithValue("@codigo_aula", codigo_aula);
                                cmd.Parameters.AddWithValue("@codigo_curso", codigo_curso);
                                cmd.Parameters.AddWithValue("@carnet_alumno", carnet_alumno);
                                cmd.Parameters.AddWithValue("@nota_asignacioncursoalumnos", nota_asignacioncursoalumnos);

                                cmd.ExecuteNonQuery();
                            }

                            // Confirmar la transacción si la inserción fue exitosa
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Revertir la transacción si ocurre algún error
                            transaction.Rollback();
                            Console.WriteLine($"Error al insertar asignacioncursosalumnos : {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
