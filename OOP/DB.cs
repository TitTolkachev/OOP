using MySql.Data.MySqlClient;
using System;
using System.Data;

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
            OpenConnection();
            MySqlCommand command = new MySqlCommand(request, connection);

            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
