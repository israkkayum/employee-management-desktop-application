using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskThree
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxEmp.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void addInfoBtn_Click(object sender, EventArgs e)
        {
            EMPLOYEE eMPLOYEE = new EMPLOYEE();
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = textBoxDate.Value;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string gender = "Male";

            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            int born_year = textBoxDate.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The employee age must be between 10 - 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                pictureBoxEmp.Image.Save(pic, pictureBoxEmp.Image.RawFormat);

                if (eMPLOYEE.insertEmployee(fname, lname, bdate, phone, gender, address, pic))
                {
                    MessageBox.Show("New employee added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        bool verify()
        {
            if ((textBoxFname.Text.Trim() == " ") || (textBoxLname.Text.Trim() == " ") || (textBoxPhone.Text.Trim() == "") || (textBoxAddress.Text.Trim() == "") || (pictureBoxEmp.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cancleInfoBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBoxGender_Enter(object sender, EventArgs e)
        {
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void EmployeeGroupBox_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBoxEmp_Click(object sender, EventArgs e)
        {
        }

        private void textBoxDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxLname_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
