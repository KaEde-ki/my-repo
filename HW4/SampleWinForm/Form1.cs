using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinForm
{
    public partial class Form1 : Form
    {
        string imagePath = "";
        public Form1()
        {
            InitializeComponent();
            dateTimePickerBirthday.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthday.CustomFormat = "yyyy-MM-dd";
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirst.Text;
            string lastName = textBoxLast.Text;
            string mobile = textBoxMobile.Text;

            string gender = "";

            if (radioButtonMale.Checked)
                gender = "Male";
            else if (radioButtonFemale.Checked)
                gender = "Female";

            string status = comboStatus.Text;
            DateTime birthday = dateTimePickerBirthday.Value;
            string location = textBoxLocation.Text;

            Form2 f2 = new Form2(firstName, lastName, mobile, gender, status, birthday, location, imagePath);
            f2.Show();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                buttonBrowse.Hide();
            }
        }
    }
}