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
    public partial class Form2 : Form
    {
        public Form2(string firstName, string lastName, string mobile, string sex, string status, DateTime birthday, string location, string imagePath)
        {
            InitializeComponent();

            labelFirst.Text = "First Name: " + firstName;
            labelLast.Text = "Last Name: " + lastName;
            labelMobile.Text = "Mobile: " + mobile;
            labelSex.Text = "Sex: " + sex;
            labelStatus.Text = "Status: " + status;
            labelBirthday.Text = "Birthday: " + birthday.ToString("yyyy-MM-dd");
            labelLocation.Text = "Location: " + location;

            if (!string.IsNullOrEmpty(imagePath))
            {
                pictureBoxDisplay.Image = Image.FromFile(imagePath);
                pictureBoxDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
