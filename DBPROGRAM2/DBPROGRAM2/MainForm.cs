using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DBPROGRAM2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CountryName.Text = "Введите название страны";
            CountryName.ForeColor = Color.Lavender;
            CodeCountry.Text = "Введите код страны";
            CodeCountry.ForeColor = Color.Lavender;
            Capital.Text = "Введите название столицы";
            Capital.ForeColor = Color.Lavender;
            Area.Text = "Введите площадь страны";
            Area.ForeColor = Color.Lavender;
            Population.Text = "Введите кол-во населения";
            Population.ForeColor = Color.Lavender;
            Region.Text = "Введите регион";
            Region.ForeColor = Color.Lavender;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // если поле пустое то будем оставлять текст по умолчанию, что бы потом проверять на вводимые данные для записи в БД
        private void CountryName_Enter(object sender, EventArgs e)
        {
            if (CountryName.Text == "Введите название страны")
            {
                CountryName.Text = "";
                CountryName.ForeColor = Color.Black;
            }
        }
        private void CountryName_Leave(object sender, EventArgs e)
        {
            if (CountryName.Text == "")
            {
                CountryName.Text = "Введите название страны";
                CountryName.ForeColor = Color.Lavender;
            }
        }
        private void CodeCountry_Enter(object sender, EventArgs e)
        {
            if (CodeCountry.Text == "Введите код страны")
            {
                CodeCountry.Text = "";
                CodeCountry.ForeColor = Color.Black;
            }
        }
        private void CodeCountry_Leave(object sender, EventArgs e)
        {
            if (CodeCountry.Text == "")
            {
                CodeCountry.Text = "Введите код страны";
                CodeCountry.ForeColor = Color.Lavender;
            }
        }

        private void Capital_Enter(object sender, EventArgs e)
        {
            if (Capital.Text == "Введите название столицы")
            {
                Capital.Text = "";
                Capital.ForeColor = Color.Black;
            }
        }
        private void Capital_Leave(object sender, EventArgs e)
        {
            if (Capital.Text == "")
            {
                Capital.Text = "Введите название столицы";
                Capital.ForeColor = Color.Lavender;
            }
        }

        private void Area_Enter(object sender, EventArgs e)
        {
            if (Area.Text == "Введите площадь страны")
            {
                Area.Text = "";
                Area.ForeColor = Color.Black;
            }
        }
        private void Area_Leave(object sender, EventArgs e)
        {
            if (Area.Text == "")
            {
                Area.Text = "Введите площадь страны";
                Area.ForeColor = Color.Lavender;
            }
        }

        private void Population_Enter(object sender, EventArgs e)
        {
            if (Population.Text == "Введите кол-во населения")
            {
                Population.Text = "";
                Population.ForeColor = Color.Black;
            }
        }
        private void Population_Leave(object sender, EventArgs e)
        {
            if (Population.Text == "")
            {
                Population.Text = "Введите кол-во населения";
                Population.ForeColor = Color.Lavender;
            }
        }

        private void Region_Enter(object sender, EventArgs e)
        {
            if (Region.Text == "Введите регион")
            {
                Region.Text = "";
                Region.ForeColor = Color.Black;
            }
        }
        private void Region_Leave(object sender, EventArgs e)
        {
            if (Region.Text == "")
            {
                Region.Text = "Введите регион";
                Region.ForeColor = Color.Lavender;
            }
        }
        //----------------------------------------------------------
        private void AddCountry_Click(object sender, EventArgs e)
        {
            //проверки на пустые поля (занчаения по умолчанию)
            if (CountryName.Text == "Введите название страны")
            {
                MessageBox.Show("Введите название страны!");
                return;
            }
            if (CodeCountry.Text == "Введите код страны")
            {
                MessageBox.Show("Введите код страны!");
                return;
            }
            if (Capital.Text == "Введите название столицы")
            {
                MessageBox.Show("Введите название столицы!");
                return;
            }
            if (Area.Text == "Введите площадь страны")
            {
                MessageBox.Show("Введите площадь страны!");
                return;
            }
            if (Population.Text == "Введите кол-во населения")
            {
                MessageBox.Show("Введите кол-во населения!");
                return;
            }
            if (Region.Text == "Введите регион")
            {
                MessageBox.Show("Введите регион!");
                return;
            }

            if (IsExist())
                return;

            double area = Convert.ToDouble(Area.Text);

            int population = Convert.ToInt32(Population.Text);
            int capitalid = 0;
            int regionid = 0;
            int id = 0;

            string capitalName = Capital.Text;

            //записываем в БД новую страну со всеми данными
            DB db = new DB();

            //записали в таблицу город
            MySqlCommand commandTown = new MySqlCommand
               ("INSERT INTO `town` (`townname`) " + "VALUES ( @townname)", db.GetConnection());
            commandTown.Parameters.Add("@townname", MySqlDbType.VarChar).Value = Capital.Text;

            //записали в таблицу регион
            MySqlCommand commandRegion = new MySqlCommand
               ("INSERT INTO `title` (`region`) " + "VALUES (@region)", db.GetConnection());
            commandRegion.Parameters.Add("@region", MySqlDbType.VarChar).Value = Region.Text;

            //записали в таблицу страны
            MySqlCommand commandCountry = new MySqlCommand
                ("INSERT INTO `countrys` (`namecountry`, `codecountry`, `capitalid`, `area`, `population`, `regionid`) " +
                "VALUES (@namecountry, @codecountry, @capitalid, @area, @population, @regionid)", db.GetConnection());

            commandCountry.Parameters.Add("@namecountry", MySqlDbType.VarChar).Value = CountryName.Text;
            commandCountry.Parameters.Add("@codecountry", MySqlDbType.VarChar).Value = CodeCountry.Text;
            commandCountry.Parameters.Add("@capitalid", MySqlDbType.Int32).Value = capitalid;
            commandCountry.Parameters.Add("@area", MySqlDbType.Double).Value = area;
            commandCountry.Parameters.Add("@population", MySqlDbType.Int32).Value = population;
            commandCountry.Parameters.Add("@regionid", MySqlDbType.Int32).Value = regionid;

            db.OpenConnection();
            //проверка записи
            if (commandTown.ExecuteNonQuery() == 1 & commandRegion.ExecuteNonQuery() == 1 & commandCountry.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные были записаны в БД!");
            }
            else
            {
                MessageBox.Show("Запись в БД не получилась!");
            }
            db.CloseConnection();

            //считываем id столицы и дописываем в страны идишник
            MySqlCommand commandIdCapital = new MySqlCommand
                ("SELECT id FROM town WHERE townname like '%" + capitalName + "%'", db.GetConnection());

           db.OpenConnection();
            MySqlDataReader readerIdCapital = commandIdCapital.ExecuteReader();

            List<string[]> dataIdCapital = new List<string[]>();

            while (readerIdCapital.Read())
            {
                dataIdCapital.Add(new string[1]);
                dataIdCapital[dataIdCapital.Count - 1][0] = readerIdCapital[0].ToString();
            }
            readerIdCapital.Close();
            db.CloseConnection();
            
            foreach (string[] s in dataIdCapital)
                dataGridView1.Rows.Add(s);

            capitalid = Convert.ToInt32(dataGridView1[0, 0].Value);
            id = capitalid - 2;

            dataGridView1.Rows.Clear();

            MySqlCommand commandUpdateCapital = new MySqlCommand
                ("UPDATE `countrys` SET `capitalid` = " + capitalid + " WHERE `id` = " + 0, db.GetConnection());
            
            db.OpenConnection();
            //проверка записи ID
            if (commandIdCapital.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("ID был записан в БД!");
            }
            else
            {
                MessageBox.Show("Запись в БД не получилась!");
            }
            db.CloseConnection();

            //считываем id региона и дописываем в страны идишник
            MySqlCommand commandIdRegion = new MySqlCommand
                ("SELECT id FROM title WHERE region like '%" + capitalName + "%'", db.GetConnection());
            db.OpenConnection();
            MySqlDataReader readerIdRegion = commandIdRegion.ExecuteReader();

            List<string[]> dataIdRegion = new List<string[]>();

            while (readerIdRegion.Read())
            {
                dataIdRegion.Add(new string[1]);
                dataIdRegion[dataIdRegion.Count - 1][0] = readerIdRegion[0].ToString();
            }
            readerIdRegion.Close();
            db.CloseConnection();

            foreach (string[] s in dataIdRegion)
                dataGridView1.Rows.Add(s);

            regionid = Convert.ToInt32(dataGridView1[0, 0].Value);
            id = regionid - 2;

            dataGridView1.Rows.Clear();

            MySqlCommand commandUpdateRegion = new MySqlCommand
                ("UPDATE `countrys` SET `regionid` = '%" + regionid + "%' WHERE `id` = '%" + id + "%'", db.GetConnection());

            db.OpenConnection();
            //проверка записи ID
            if (commandUpdateRegion.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("ID был записан в БД!");
            }
            else
            {
                MessageBox.Show("Запись в БД не получилась!");
            }
            db.CloseConnection();
        }

        //показать информацию о стране, по названию страны из БД
        private void LoadData(string sql)
        {
            if (CountryName.Text == "Введите название страны")
            {
                MessageBox.Show("Введите название страны!");
                return;
            }
            DB db = new DB();
            db.OpenConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM countrys WHERE namecountry like '%" + sql + "%'", db.GetConnection());
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            dataGridView1.DataSource = table;

            db.CloseConnection();
        }

        //проверка если есть такая страна в БД
        //требует усовершенствования
        //добавить проверку если есть город в таблице города, и регион
        public Boolean IsExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM countrys WHERE namecountry = @cL", db.GetConnection());
            command.Parameters.Add("@cL", MySqlDbType.VarChar).Value = CountryName.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такая страна уже есть в БД, введиите другую!");
                return true;
            }
            else
            {
                return false;
            }
        }

        //если нет страны
        public Boolean IsNotExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM countrys WHERE namecountry = @cL", db.GetConnection());
            command.Parameters.Add("@cL", MySqlDbType.VarChar).Value = CountryName.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Такой страны нет в Базе Данных!");
                return true;
            }
        }

        //вывести на форму данные из БД по названию страны
        private void ShowCountryData_Click(object sender, EventArgs e)
        {
            if (CountryName.Text == "Введите название страны")
            {
                MessageBox.Show("Введите название страны!");
                return;
            }

            if (dataGridView1.Columns.Count > 1)
            {
            }
            else
            {
                dataGridView1.Columns.Remove("id");
            }

            {
                if (IsNotExist())
                    return;
                LoadData(CountryName.Text);
            }
        }

        //показать информацию о стране, по названию страны
        //потом доделать запись с сайта в форму, для дальнейшего сохранения в БД
        //сайт json ответ
        private void SearchCountry_Click(object sender, EventArgs e)
        {
            if (CountryName.Text == "Введите название страны")
            {
                MessageBox.Show("Введите название страны!");
                return;
            }
            System.Diagnostics.Process.Start("https://restcountries.eu/rest/v2/name/" + CountryName.Text);
        }

        //показать полный список стран из БД
        private void ShowAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > 1)
            {
            }
            else
            {
                dataGridView1.Columns.Remove("id");
            }

            string connectString = "server=localhost;database=country;port=3306;username=root;password=root;SSL mode=none;";

            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM countrys";

            MySqlCommand command = new MySqlCommand(query, myConnection);
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            dataGridView1.DataSource = table;
        }
    }
}