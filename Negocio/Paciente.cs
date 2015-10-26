using Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Paciente
    {
        public int cod_paciente { get; set; }
        public String nombre { get; set; }
        public String Apellido { get; set; }

        public static List<Paciente> GetAll()
        {
            DBConnect db = new DBConnect();
            try
            {
                List<Paciente> pacientes = new List<Paciente>();
                string query = "SELECT * FROM pacientes;";
                //Open connection
                db.OpenConnection();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var paciente = new Paciente();
                    paciente.cod_paciente = Convert.ToInt32(dataReader["cod_paciente"]);
                    paciente.nombre = Convert.ToString(dataReader["nombre"]);
                    paciente.Apellido = Convert.ToString(dataReader["Apellido"]);
                    pacientes.Add(paciente);

                }


                dataReader.Close();


                db.CloseConnection();
                return pacientes;
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                throw new Exception(ex.Message);
            }
            finally
            {
                if (db.OpenConnection() == true)
                {
                    db.CloseConnection();
                };
            }
        }

        public static void Insert(string nombre, string apellido) {
            DBConnect db = new DBConnect();
            var query = "INSERT INTO pacientes (nombre, Apellido, sexo) VALUES( " + "'" + nombre + "'" + ", " + "'" + apellido + "'" + ", 'Femenino')";
            db.Insert(query);
        }
    }
}
