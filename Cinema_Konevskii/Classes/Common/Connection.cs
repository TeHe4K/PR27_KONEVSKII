using MySql.Data.MySqlClient;

namespace Cinema_Konevskii.Classes.Common
{
    public class Connection
    {
        public static readonly string config = "server=127.0.0.1;uid=root;pwd=;database=cinema";
        public MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(config);
            connection.Open();
            return connection;
        }
        public MySqlDataReader Query(string SQL, MySqlConnection connection)
        {
            return new MySqlCommand(SQL,connection).ExecuteReader();
        }
        public void CloseConection(MySqlConnection connection) 
        {
            connection.Close();
            MySqlConnection.ClearAllPools();
        }
    }
}
