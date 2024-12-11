using MySql.Data.MySqlClient;

namespace Cumulative.Models
{
    public class DbContext
    {
        private static string User { get { return "Himanshu"; } }
        private static string Password { get { return "Himanshu9"; } }
        private static string Database { get { return "school_backend"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        protected static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password
                    + "; Convert Zero Datetime = True";

            }
        }

        /// <summary>
        /// Connects to DB
        /// </summary>
        /// <example>
        /// private SchoolDbContext School = new SchoolDbContext();
        /// MySqlConnection Conn = School.AccessDatabase();
        /// </example>
        /// <returns>A MySqlConnection Object</returns>

        public MySqlConnection AccessDatabase()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
