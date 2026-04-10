namespace csMysqlImageCrud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            FIRSTNAME = new DataGridViewTextBoxColumn();
            LASTNAME = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            GENDER = new DataGridViewTextBoxColumn();
            LANGUAGE = new DataGridViewTextBoxColumn();
            COUNTRY = new DataGridViewTextBoxColumn();
            IMAGENAME = new DataGridViewTextBoxColumn();
            IMAGEPATH = new DataGridViewTextBoxColumn();
            IMAGE = new DataGridViewTextBoxColumn();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnImage = new Button();
            comboBox1 = new ComboBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            textBoxImagePath = new TextBox();
            textBoxImageName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnImage);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(radioButtonFemale);
            panel1.Controls.Add(radioButtonMale);
            panel1.Controls.Add(textBoxImagePath);
            panel1.Controls.Add(textBoxImageName);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxLastName);
            panel1.Controls.Add(textBoxFirstName);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1269, 739);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSalmon;
            pictureBox1.Location = new Point(409, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(582, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FIRSTNAME, LASTNAME, EMAIL, GENDER, LANGUAGE, COUNTRY, IMAGENAME, IMAGEPATH, IMAGE });
            dataGridView1.Location = new Point(0, 434);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1269, 305);
            dataGridView1.TabIndex = 26;
            // 
            // FIRSTNAME
            // 
            FIRSTNAME.HeaderText = "FIRSTNAME";
            FIRSTNAME.Name = "FIRSTNAME";
            FIRSTNAME.Resizable = DataGridViewTriState.True;
            FIRSTNAME.Width = 180;
            // 
            // LASTNAME
            // 
            LASTNAME.HeaderText = "LASTNAME";
            LASTNAME.Name = "LASTNAME";
            LASTNAME.Width = 140;
            // 
            // EMAIL
            // 
            EMAIL.HeaderText = "EMAIL";
            EMAIL.Name = "EMAIL";
            EMAIL.Width = 200;
            // 
            // GENDER
            // 
            GENDER.HeaderText = "GENDER";
            GENDER.Name = "GENDER";
            // 
            // LANGUAGE
            // 
            LANGUAGE.HeaderText = "LANGUAGE";
            LANGUAGE.Name = "LANGUAGE";
            // 
            // COUNTRY
            // 
            COUNTRY.HeaderText = "COUNTRY";
            COUNTRY.Name = "COUNTRY";
            COUNTRY.Width = 120;
            // 
            // IMAGENAME
            // 
            IMAGENAME.HeaderText = "IMAGENAME";
            IMAGENAME.Name = "IMAGENAME";
            IMAGENAME.Width = 120;
            // 
            // IMAGEPATH
            // 
            IMAGEPATH.HeaderText = "IMAGEPATH";
            IMAGEPATH.Name = "IMAGEPATH";
            IMAGEPATH.Width = 120;
            // 
            // IMAGE
            // 
            IMAGE.HeaderText = "IMAGE";
            IMAGE.Name = "IMAGE";
            IMAGE.Width = 150;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1046, 304);
            button5.Name = "button5";
            button5.Size = new Size(171, 38);
            button5.TabIndex = 25;
            button5.Text = "CLEAR";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(1046, 210);
            button4.Name = "button4";
            button4.Size = new Size(171, 38);
            button4.TabIndex = 24;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1046, 125);
            button3.Name = "button3";
            button3.Size = new Size(171, 38);
            button3.TabIndex = 23;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(1046, 30);
            button2.Name = "button2";
            button2.Size = new Size(171, 38);
            button2.TabIndex = 22;
            button2.Text = "INSERT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnImage
            // 
            btnImage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImage.Location = new Point(543, 350);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(340, 31);
            btnImage.TabIndex = 21;
            btnImage.Text = "CHOOSE IMAGE";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "USA", "UK", "Canada", "Australia", "India", "Bangladesh" });
            comboBox1.Location = new Point(166, 304);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 23);
            comboBox1.TabIndex = 20;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(271, 257);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(60, 19);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Arabic";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(166, 257);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "English";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(271, 210);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 17;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(166, 210);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 16;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxImagePath
            // 
            textBoxImagePath.Location = new Point(166, 387);
            textBoxImagePath.Name = "textBoxImagePath";
            textBoxImagePath.Size = new Size(614, 23);
            textBoxImagePath.TabIndex = 15;
            // 
            // textBoxImageName
            // 
            textBoxImageName.Location = new Point(166, 348);
            textBoxImageName.Name = "textBoxImageName";
            textBoxImageName.Size = new Size(195, 23);
            textBoxImageName.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(164, 167);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(195, 23);
            textBoxEmail.TabIndex = 13;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(164, 125);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(195, 23);
            textBoxLastName.TabIndex = 12;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(164, 84);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(195, 23);
            textBoxFirstName.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 10;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 379);
            label9.Name = "label9";
            label9.Size = new Size(148, 31);
            label9.TabIndex = 9;
            label9.Text = "IMAGE PATH";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 340);
            label8.Name = "label8";
            label8.Size = new Size(156, 31);
            label8.TabIndex = 8;
            label8.Text = "IMAGE NAME";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 296);
            label7.Name = "label7";
            label7.Size = new Size(126, 31);
            label7.TabIndex = 7;
            label7.Text = "COUNTRY";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 246);
            label6.Name = "label6";
            label6.Size = new Size(145, 31);
            label6.TabIndex = 6;
            label6.Text = "LANGUAGE";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 200);
            label5.Name = "label5";
            label5.Size = new Size(100, 31);
            label5.TabIndex = 5;
            label5.Text = "GENDER";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 159);
            label4.Name = "label4";
            label4.Size = new Size(100, 31);
            label4.TabIndex = 4;
            label4.Text = "EMAIL";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(137, 31);
            label3.TabIndex = 3;
            label3.Text = "LAST NAME";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(144, 31);
            label2.TabIndex = 2;
            label2.Text = "FIRST NAME";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 741);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBox1;
        private TextBox textBoxEmail;
        private TextBox textBoxImagePath;
        private TextBox textBoxImageName;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnImage;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn FIRSTNAME;
        private DataGridViewTextBoxColumn LASTNAME;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn GENDER;
        private DataGridViewTextBoxColumn LANGUAGE;
        private DataGridViewTextBoxColumn COUNTRY;
        private DataGridViewTextBoxColumn IMAGENAME;
        private DataGridViewTextBoxColumn IMAGEPATH;
        private DataGridViewTextBoxColumn IMAGE;
    }
}
