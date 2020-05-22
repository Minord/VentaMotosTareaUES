using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace SistemaGestionMotosUES.Data
{
    class DataBasePort
    {

        //Data base directory 

        static string dbFile = "venta_motos.db";
        static string workingDirectory = Environment.CurrentDirectory;
        static string cs = Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName , @"data\", dbFile);

        private static SQLiteConnection crearConexion() {
            SQLiteConnection sqliteCon = new SQLiteConnection($"Data Source= { cs };Version=3;New=False;Compress=True;" );

            try
            {
                sqliteCon.Open();
            }
            catch (Exception ex){
                Console.Out.WriteLine(ex.Message);
            }
            return sqliteCon;
        }

        //public static bool realConection(string correo, string password)
        //{
        //    string queryText = $"SELECT vendedor_id FROM Vendedores WHERE correo = '{correo}'AND contraseña = '{password}';";
        //    SQLiteCommand db_command;
        //    SQLiteConnection db_connection = crearConexion();
        //    db_command = db_connection.CreateCommand();

        //    db_command.CommandText = queryText;
        //    SQLiteDataReader result = db_command.ExecuteReader();
        //    bool askingresult = result.HasRows;
        //    return askingresult;
        //}

        //Metodo que retorna el ID que el usuario usara para registrar sus reservas
        public static string user_ID(string correo, string password)
        {
            string sql = $"SELECT nombre FROM Vendedores WHERE correo = '{correo}'AND contraseña = '{password}';";
            string user_ID = "";
            SQLiteCommand command = new SQLiteCommand(sql, crearConexion());
           SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            user_ID = dt.Rows[0][0].ToString();
            return user_ID;
        }

        public static int insertarDatos(string queryText) {
            SQLiteCommand db_command;
            SQLiteConnection db_connection = crearConexion();
            db_command = db_connection.CreateCommand();

            db_command.CommandText = queryText;
            db_command.ExecuteNonQuery();

            db_command.CommandText = "select last_insert_rowid()";
            Int64 lastRowID64 = (Int64)db_command.ExecuteScalar();

            int lastRowID = (int)lastRowID64;

            db_connection.Close();

            return lastRowID;
        }

        public static void actualizarDatos(string queryText)
        {
            SQLiteCommand db_command;
            SQLiteConnection db_connection = crearConexion();
            db_command = db_connection.CreateCommand();

            db_command.CommandText = queryText;
            db_command.ExecuteNonQuery();
            db_connection.Close();

        }

        /// <summary>
        /// Este metodo es para obtener una lista de string usualmente sirven para rellenar comboxes de seleccion
        /// </summary>
        /// <returns></returns>
        public static List<string> getListOfStringQuery(string queryText) {
            List<string> resultado = new List<string>();

            SQLiteCommand db_command;
            SQLiteConnection db_connection = crearConexion();
            db_command = db_connection.CreateCommand();

            db_command.CommandText = queryText;

            SQLiteDataReader sqlite_datareader = db_command.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                resultado.Add(myreader);
            }

            return resultado;
        }

        public static DataTable getTableQuery(string queryText) {
            DataTable resultado = new DataTable();

            SQLiteCommand db_command;
            SQLiteConnection db_connection = crearConexion();
            db_command = db_connection.CreateCommand();

            db_command.CommandText = queryText;
            SQLiteDataReader result = db_command.ExecuteReader();          
            resultado.Load(result);

            return resultado;
        }

        public static float getScalarQuery(string queryText) {
            float? resultado = -1;
            try
            {
                SQLiteCommand db_command;
                SQLiteConnection db_connection = crearConexion();
                db_command = db_connection.CreateCommand();
                db_command.CommandText = queryText;

                object resultado_q = db_command.ExecuteScalar();
                db_connection.Close();

                if (!resultado_q.Equals(null))
                {
                    resultado = float.Parse(resultado_q.ToString());
                }
            }
            catch (Exception e)
            {

            }

            return (float) resultado;
        }
    }
}
