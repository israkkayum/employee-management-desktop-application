using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TaskThree
{
    public partial class UpdateDeleteEmployeeForm : Form
    {
        public UpdateDeleteEmployeeForm()
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

        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            EMPLOYEE eMPLOYEE = new EMPLOYEE();
            int id = Convert.ToInt32(textBoxID.Text);
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

                if (eMPLOYEE.updateEmployee(id, fname, lname, bdate, phone, gender, address, pic))
                {
                    MessageBox.Show("Employee information update", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void removeInfoBtn_Click(object sender, EventArgs e)
        {

            EMPLOYEE eMPLOYEE = new EMPLOYEE();
            int id = Convert.ToInt32(textBoxID.Text);

            if (MessageBox.Show("Are you sure you want to delete this employee", "Delete employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            {
                if (eMPLOYEE.deleteEmployee(id))
                {
                    MessageBox.Show("Employee deleted", "Employee delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // clear field
                    textBoxID.Text = "";
                    textBoxFname.Text = "";
                    textBoxLname.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";
                    textBoxDate.Value = DateTime.Now;
                    pictureBoxEmp.Image = null;

                }
                else
                {
                    MessageBox.Show("Employee not deleted", "Employee delete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void findBtn_Click(object sender, EventArgs e)
        {

            EMPLOYEE eMPLOYEE = new EMPLOYEE();
            int id = Convert.ToInt32(textBoxID.Text);

            MySqlCommand command = new MySqlCommand("SELECT `id`, `first_name`, `last_name`, `birthdate`, `gender`, `phone`, `address`, `picture` FROM `employee` WHERE `id`=" + id);

            DataTable table = eMPLOYEE.getEmployees(command);

            if (table.Rows.Count > 0)
            {
                textBoxFname.Text = table.Rows[0]["first_name"].ToString();
                textBoxLname.Text = table.Rows[0]["last_name"].ToString();
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();

                textBoxDate.Value = (DateTime)table.Rows[0]["birthdate"];

                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = true;
                }

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxEmp.Image = Image.FromStream(picture);

            }
        }
    }
}
