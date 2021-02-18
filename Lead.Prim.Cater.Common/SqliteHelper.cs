using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Data;

namespace Lead.Prim.Cater.Common
{
    class SqliteHelper
    {
        private static string conn = ConfigurationManager.ConnectionStrings["Cater"].ConnectionString;

        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                SQLiteCommand command = new SQLiteCommand(sql,connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteScalar();
            }
        }

        public static DataTable GetDataTable(string sql,params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection connection  = new SQLiteConnection(conn))
            {
                //SQLiteCommand command = new SQLiteCommand(sql,connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql,connection);
                DataTable dataTable = new DataTable();
                adapter.SelectCommand.Parameters.AddRange(parameters);
                adapter.Fill(dataTable);
                //connection.Open();
                return dataTable;
            }
        }
    }
}
