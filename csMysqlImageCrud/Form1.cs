using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace csMysqlImageCrud
{
    public partial class Form1 : Form
    {
        // ডাটাবেস ক্লাসের অবজেক্ট তৈরি
        MysqlDatabaseConnection dbCONN = new MysqlDatabaseConnection();

        MySqlCommand command;
        string InsertString = "INSERT INTO `csharpimagecrud`(`FirstName`,`LastName`, `Email`,`Gender`,`Language`,`Country`, `ImageName`, `ImagePath`,`ImageBlob`) VALUES (@FirstName,@LastName,@Email,@Gender,@Language,@Country, @ImageName, @ImagePath, @ImageBlob)";
        string radioButtonValueGender = "";
        string languageCheckBox = "";
        string countryCombobox;

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

            string sqlSelectAllData = "SELECT* FROM `csharpimagecrud` ";
            MySqlCommand command;
            MySqlDataAdapter adapter;
            DataTable table;

            try
            {
                command = new MySqlCommand(sqlSelectAllData, dbCONN.getDatabaseConnection());
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = table;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);


            }
            finally
            {

               // command.Dispose();
                dbCONN.closeDBConnection();
            }


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
                //check whick buttonn is checked
                if (radioButtonMale.Checked)
                {
                    radioButtonValueGender = "Male";

                }
                else
                if (radioButtonFemale.Checked)
                {

                    radioButtonValueGender = "Female";

                }

                //check which checkbox is checked
                if (checkBoxEnglish.Checked)
                {
                    languageCheckBox = "English";

                }
                else
                    if (checkBoxArabic.Checked)
                {
                    languageCheckBox = "Arabic";
                }
                countryCombobox = comboBoxCountry.SelectedItem.ToString();

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                Byte[] img = ms.ToArray();

                dbCONN.openDBConnection();
                command = new MySqlCommand(InsertString, dbCONN.getDatabaseConnection());
                command.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = textBoxFirstName.Text;
                command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = textBoxLastName.Text;
                command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
                command.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = radioButtonValueGender;
                command.Parameters.Add("@Language", MySqlDbType.VarChar).Value = languageCheckBox;
                command.Parameters.Add("@Country", MySqlDbType.VarChar).Value = countryCombobox;
                command.Parameters.Add("@ImageName", MySqlDbType.VarChar).Value = textBoxImageName.Text;
                command.Parameters.Add("@ImagePath", MySqlDbType.VarChar).Value = textBoxImagePath.Text;
                command.Parameters.Add("@ImageBlob", MySqlDbType.Blob).Value = img;



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

    }
}