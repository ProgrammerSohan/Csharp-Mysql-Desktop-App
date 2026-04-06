using MySql.Data.MySqlClient;
using System.Data; // এটি যোগ করা হয়েছে
using System;
using System.Drawing;
using System.Windows.Forms;

namespace csMysqlImageCrud
{
    public partial class Form1 : Form
    {
        MysqlDatabaseConnection dbCONN = new MysqlDatabaseConnection();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Only Images|*.png;*.jpg;*.gif;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                /*pictureBox1.Image = Image.FromFile(ofd.FileName);
                textBoxImagePath.Text = ofd.FileName;*/
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

                pictureBox1.Image = Image.FromFile(ofd.FileName);
                textBoxImagePath.Text = ofd.FileName;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //check the connection when the form loads
            //ctrl+k+s sorround with
            /*  try
              {
                  dbCONN.getDatabaseConnection().Open();
                  if(dbCONN.getDatabaseConnection().State == ConnectionState.Open)
                  {
                      MessageBox.Show("Connected To The Database.....");

                  }
              }
              catch (Exception err)
              {

                  MessageBox.Show("Error " + err.Message);
              }*/

            try
            {
                MySqlConnection conn = dbCONN.getDatabaseConnection();

                // যদি কানেকশন আগে থেকেই খোলা না থাকে তবে খুলুন
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connected To The Database Successfully!");

                    // চেক করা শেষ হলে কানেকশন বন্ধ করে দিন
                    conn.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            finally
            {
                // MySqlConnection অবজেক্টটি ব্যবহার করে কানেকশন বন্ধ করতে হবে
                MySqlConnection conn = dbCONN.getDatabaseConnection();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    // MessageBox.Show("Database Connection Closed...."); // বারবার মেসেজ আসা বিরক্তিকর হতে পারে
                }
            }

        }


    }
}
