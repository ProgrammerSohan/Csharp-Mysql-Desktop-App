using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace csMysqlImageCrud
{
    public partial class Form1 : Form
    {
        // ডাটাবেস ক্লাসের অবজেক্ট তৈরি
        MysqlDatabaseConnection dbCONN = new MysqlDatabaseConnection();

        MySqlCommand command;
        string InsertString = "INSERT INTO `csharpimagecrud`(`FirstName`,`LastName`, `Email`, `ImagePath`) VALUES (@FirstName,@LastName,@Email,@ImagePath)";

        public Form1()
        {
            InitializeComponent();
        }

        // ইমেজ সিলেক্ট করার বাটন (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Only Images|*.png;*.jpg;*.gif;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // আগের ইমেজ মেমোরি থেকে পরিষ্কার করা
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

                pictureBox1.Image = Image.FromFile(ofd.FileName);
                textBoxImagePath.Text = ofd.FileName;
                textBoxImageName.Text = Path.GetFileName(ofd.FileName);
            }
        }   

        // ফর্ম যখন লোড হবে তখন এই মেথডটি রান করবে
        private void Form1_Load(object sender, EventArgs e)
        {
            // আপনার ক্লাসের মেথডটির নাম 'openDBConnection' (সব ছোট হাতের)
            // তাই এখানেও হুবহু সেভাবেই কল করতে হবে
            dbCONN.openDBConnection();

            // চেক করা শেষ হলে কানেকশন ক্লোজ করে দিন
            dbCONN.closeDBConnection();
        }

        // এই মেথডগুলো অটো জেনারেটেড, এগুলো এভাবেই থাক
        private void label8_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert data into mysql database when user clicks insert button
            try
            {
                dbCONN.openDBConnection();
                command = new MySqlCommand(InsertString, dbCONN.getDatabaseConnection());
                command.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = textBoxFirstName.Text;
                command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = textBoxLastName.Text;
                command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
                command.Parameters.Add("@ImagePath", MySqlDbType.VarChar).Value = textBoxImagePath.Text;

                //check if data has been inserted
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted Successfully............");
                }
                else
                {
                    MessageBox.Show("Data Failed To Insert Successfully........");
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("Error " + err.Message);
            }
            finally
            {
                //release all command resources
                command.Dispose();
                //close database connection
                dbCONN.closeDBConnection();

            }

        }

        private void textBoxImageName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}