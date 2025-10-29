using System.Data;
using System.Data.SQLite;

namespace _9._2
{
    internal class Database
    {
        private static string connectionString = "Data Source=projects.db;Version=3;";

        public static void Initialize()
        {
            if (!System.IO.File.Exists("projects.db"))
            {
                SQLiteConnection.CreateFile("projects.db");

                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "CREATE TABLE Projects (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Description TEXT, StartDate TEXT, EndDate TEXT);" +
                        "CREATE TABLE Employees (Id INTEGER PRIMARY KEY AUTOINCREMENT, FullName TEXT, Position TEXT);" +
                        "CREATE TABLE Tasks (Id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT, Description TEXT, Status TEXT, ProjectId INTEGER, EmployeeId INTEGER," +
                        "FOREIGN KEY(ProjectId) REFERENCES Projects(Id)," +
                        "FOREIGN KEY(EmployeeId) REFERENCES Employees(Id));";

                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public static void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
