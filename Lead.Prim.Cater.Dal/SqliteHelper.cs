using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;

namespace Lead.Prim.Cater.Dal
{
    static class SqliteHelper
    {
        private static string conn = ConfigurationManager.ConnectionStrings["Cater"].ConnectionString;

        public static int ExecuteNonQuery(string sql,params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                SQLiteCommand command = new SQLiteCommand(sql,connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}
