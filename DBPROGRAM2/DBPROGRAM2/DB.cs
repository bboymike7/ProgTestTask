using MySql.Data.MySqlClient;

namespace DBPROGRAM2
{
    public class DB
    {
        MySqlConnection connnection = new MySqlConnection("server=localhost;port=3306;database=country;username=root;password=root;SSL mode=none;");

        public void OpenConnection ()
        {
            if (connnection.State == System.Data.ConnectionState.Closed)
                connnection.Open();
        }

        public void CloseConnection()
        {
            if (connnection.State == System.Data.ConnectionState.Open)
                connnection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connnection;
        }
    }
}
