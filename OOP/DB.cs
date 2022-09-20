using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=OOP");

        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if(connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public DataTable SelectRequest(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter
            {
                SelectCommand = cmd
            };
            adapter.Fill(dt);

            return dt;
        }

        public void ChangeData(string request)
        {
            this.OpenConnection();
            MySqlCommand command = new MySqlCommand(request, connection);

            //MessageBox.Show(command.CommandText.ToString());

            command.ExecuteNonQuery();
            this.CloseConnection();
        }
    }
}
