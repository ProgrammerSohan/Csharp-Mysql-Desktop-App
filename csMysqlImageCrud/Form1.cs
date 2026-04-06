using MySql.Data.MySqlClient;
using System.Data.Common;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Only Images|*.png;*.jpg;*.gif;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                textBoxImagePath.Text = ofd.FileName;
            }
        }
    }
}
