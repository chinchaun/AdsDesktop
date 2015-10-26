using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using MySql.Data.MySqlClient;

namespace Negocio
{
    public class Estudio
    {
        public int cod_estudio { get; set; }
        public String desc_estudio { get; set; }

        public static List<Estudio> GetAll() {
           DBConnect db = new DBConnect();
            try
            {
                List<Estudio> estudios = new List<Estudio>();
                string query = "SELECT * FROM Estudios;";
                //Open connection
                db.OpenConnection();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var estudio = new Estudio();
                    estudio.cod_estudio = Convert.ToInt32(dataReader["cod_estudio"]);
                    estudio.desc_estudio = Convert.ToString(dataReader["desc_estudio"]);
                    estudios.Add(estudio);

                }


                dataReader.Close();


                db.CloseConnection();
                return estudios;
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                throw new Exception(ex.Message);
            }
            finally {
                if (db.OpenConnection() == true) {
                    db.CloseConnection();
                };
            }
        }

        public static void Insert(string desc_estudio) {
            var query = "INSERT INTO estudios (desc_estudio, estado_estudio) VALUES( " + "'" + desc_estudio + "'" + ", true)";
            DBConnect db = new DBConnect();
            db.Insert(query);
        }

        public static void Update(int cod_estudio, string desc_estudio) {
            string query = "UPDATE estudios SET desc_estudio=" + "'" + desc_estudio + "'" + " WHERE cod_estudio = " + cod_estudio + ";";
            DBConnect db = new DBConnect();
            db.Update(query);
        }
    }
}
