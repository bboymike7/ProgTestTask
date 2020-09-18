using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBPROGRAM2
{
    public class Country
    {
        private static string conn = "server=localhost;database=country;port=3306;username=root;password=root;SSL mode=none;";
        private MySqlConnection connection = new MySqlConnection(conn);

        public DataTable GetInfoAboutCountry(string sql)
        {
            string s = "select " +
            "countrys.id, countrys.namecountry,countrys.codecountry,countrys.area,countrys.population," +
            "town.townname," +
            "title.region " +
            "from " +
            "countrys,town,title " +
            "where " +
            "countrys.regionid = title.id and " +
            "countrys.capitalid = town.id and " +
            "town.townname like '%" + sql + "%';";
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(s, connection);
                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                connection.Open();
                
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())// построчно считываем данные
                {
                    MessageBox.Show(reader.GetString(0), reader.GetString(1));
                }

                reader.Close();
                
                connection.Close();
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            MessageBox.Show(s);
            
            connection.Close();
            return null;
        }
    }
}
//требует доработки не пригодилось