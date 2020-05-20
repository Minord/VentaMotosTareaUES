using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SistemaGestionMotosUES.Data
{
    class DataBasePort
    {

        //Data base directory 
        string cs = @"URI=file:C:\sqlite\db\venta_motos.db";

        private static SQLiteConnection crearConexion() {
            SQLiteConnection sqliteCon = new SQLiteConnection("Data Source=" +
            "database.db; Version = 3; New = True; Compress = True; ");

            try
            {
                sqliteCon.Open();
            }
            catch (Exception ex){

            }
            return sqliteCon;
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

            resultado.Load(db_command.ExecuteReader());

            return resultado;
        }
    }
}
