using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace phonebook
{
    public class Connector : Form
    {
        public MySqlConnection connection;
        public MySqlCommand command;
        public MySqlDataReader reader;

        public void DoConnect()
        {
            String string_connection = "Server = localhost; database = phonebook; user = root";
            connection = new MySqlConnection(string_connection);
            connection.Open();  
        }

        public void DoDisconnect()
        {
            connection.Close();
            connection.Dispose();              
        }

        public MySqlDataReader ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            return command.ExecuteReader();
        }

    }
}