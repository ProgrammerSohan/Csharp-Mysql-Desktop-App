using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace csMysqlImageCrud
{
    internal class MysqlDatabaseConnection
    {
        // কানেকশন স্ট্রিং ঠিক আছে কি না নিশ্চিত করুন (database name: csharpimagecrud)
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharpimagecrud;");

        // কানেকশন অবজেক্ট পাওয়ার ফাংশন
        public MySqlConnection getDatabaseConnection()
        {
            return connection;
        }

        // কানেকশন ওপেন করার মেথড
        public void openDBConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    MessageBox.Show("Connected To The Database Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        // কানেকশন ক্লোজ করার মেথড
        public void closeDBConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Close Error: " + ex.Message);
            }
        }
    }
}