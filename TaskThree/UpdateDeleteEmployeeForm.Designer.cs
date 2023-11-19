namespace TaskThree
{
    partial class UpdateDeleteEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxGender = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            editInfoBtn = new Button();
            removeInfoBtn = new Button();
            uploadButton = new Button();
            pictureBoxEmp = new PictureBox();
            textBoxDate = new DateTimePicker();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxLname = new TextBox();
            textBoxFname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            EmployeeGroupBox = new GroupBox();
            findBtn = new Button();
            textBoxID = new TextBox();
            label8 = new Label();
            textBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmp).BeginInit();
            panel1.SuspendLayout();
            EmployeeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxGender
            // 
            textBoxGender.Controls.Add(radioButtonFemale);
            textBoxGender.Controls.Add(radioButtonMale);
            textBoxGender.Location = new Point(473, 401);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.Size = new Size(306, 58);
            textBoxGender.TabIndex = 19;
            textBoxGender.TabStop = false;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(178, 16);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(122, 36);
            radioButtonFemale.TabIndex = 20;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Checked = true;
            radioButtonMale.Location = new Point(6, 16);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(98, 36);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // editInfoBtn
            // 
            editInfoBtn.BackColor = SystemColors.Highlight;
            editInfoBtn.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editInfoBtn.Location = new Point(916, 624);
            editInfoBtn.Name = "editInfoBtn";
            editInfoBtn.Size = new Size(150, 46);
            editInfoBtn.TabIndex = 18;
            editInfoBtn.Text = "Edit";
            editInfoBtn.UseVisualStyleBackColor = false;
            editInfoBtn.Click += editInfoBtn_Click;
            // 
            // removeInfoBtn
            // 
            removeInfoBtn.BackColor = SystemColors.Highlight;
            removeInfoBtn.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeInfoBtn.Location = new Point(1155, 624);
            removeInfoBtn.Name = "removeInfoBtn";
            removeInfoBtn.Size = new Size(150, 46);
            removeInfoBtn.TabIndex = 17;
            removeInfoBtn.Text = "Remove";
            removeInfoBtn.UseVisualStyleBackColor = false;
            removeInfoBtn.Click += removeInfoBtn_Click;
            // 
            // uploadButton
            // 
            uploadButton.BackColor = SystemColors.ControlDark;
            uploadButton.Location = new Point(916, 545);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(389, 46);
            uploadButton.TabIndex = 16;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = false;
            uploadButton.Click += uploadButton_Click;
            // 
            // pictureBoxEmp
            // 
            pictureBoxEmp.BackColor = SystemColors.ActiveCaption;
            pictureBoxEmp.Location = new Point(916, 186);
            pictureBoxEmp.Name = "pictureBoxEmp";
            pictureBoxEmp.Size = new Size(389, 336);
            pictureBoxEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEmp.TabIndex = 15;
            pictureBoxEmp.TabStop = false;
            // 
            // textBoxDate
            // 
            textBoxDate.CustomFormat = "dd/mm/yyyy";
            textBoxDate.Format = DateTimePickerFormat.Custom;
            textBoxDate.Location = new Point(473, 326);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(306, 39);
            textBoxDate.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(473, 483);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(306, 39);
            textBoxPhone.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(473, 559);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(306, 101);
            textBoxAddress.TabIndex = 9;
            // 
            // textBoxLname
            // 
            textBoxLname.Location = new Point(473, 255);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(306, 39);
            textBoxLname.TabIndex = 8;
            // 
            // textBoxFname
            // 
            textBoxFname.Location = new Point(473, 186);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(306, 39);
            textBoxFname.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(118, 559);
            label7.Name = "label7";
            label7.Size = new Size(136, 32);
            label7.TabIndex = 5;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(118, 483);
            label6.Name = "label6";
            label6.Size = new Size(109, 32);
            label6.TabIndex = 4;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(118, 401);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(118, 326);
            label4.Name = "label4";
            label4.Size = new Size(158, 32);
            label4.TabIndex = 2;
            label4.Text = "BirthDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(118, 255);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 1;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 186);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 0;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(321, 37);
            label1.Name = "label1";
            label1.Size = new Size(749, 59);
            label1.TabIndex = 1;
            label1.Text = "Add Employee Information";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 134);
            panel1.TabIndex = 2;
            // 
            // EmployeeGroupBox
            // 
            EmployeeGroupBox.BackColor = SystemColors.ButtonFace;
            EmployeeGroupBox.Controls.Add(findBtn);
            EmployeeGroupBox.Controls.Add(textBoxID);
            EmployeeGroupBox.Controls.Add(label8);
            EmployeeGroupBox.Controls.Add(textBoxGender);
            EmployeeGroupBox.Controls.Add(editInfoBtn);
            EmployeeGroupBox.Controls.Add(removeInfoBtn);
            EmployeeGroupBox.Controls.Add(uploadButton);
            EmployeeGroupBox.Controls.Add(pictureBoxEmp);
            EmployeeGroupBox.Controls.Add(textBoxDate);
            EmployeeGroupBox.Controls.Add(textBoxPhone);
            EmployeeGroupBox.Controls.Add(textBoxAddress);
            EmployeeGroupBox.Controls.Add(textBoxLname);
            EmployeeGroupBox.Controls.Add(textBoxFname);
            EmployeeGroupBox.Controls.Add(label7);
            EmployeeGroupBox.Controls.Add(label6);
            EmployeeGroupBox.Controls.Add(label5);
            EmployeeGroupBox.Controls.Add(label4);
            EmployeeGroupBox.Controls.Add(label3);
            EmployeeGroupBox.Controls.Add(label2);
            EmployeeGroupBox.Location = new Point(12, 161);
            EmployeeGroupBox.Name = "EmployeeGroupBox";
            EmployeeGroupBox.Size = new Size(1377, 725);
            EmployeeGroupBox.TabIndex = 3;
            EmployeeGroupBox.TabStop = false;
            EmployeeGroupBox.Text = "Employee";
            // 
            // findBtn
            // 
            findBtn.BackColor = SystemColors.Highlight;
            findBtn.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            findBtn.Location = new Point(678, 51);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(150, 46);
            findBtn.TabIndex = 22;
            findBtn.Text = "Find";
            findBtn.UseVisualStyleBackColor = false;
            findBtn.Click += findBtn_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(321, 51);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(306, 39);
            textBoxID.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(118, 109);
            label8.Name = "label8";
            label8.Size = new Size(0, 32);
            label8.TabIndex = 20;
            // 
            // UpdateDeleteEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 938);
            Controls.Add(panel1);
            Controls.Add(EmployeeGroupBox);
            Name = "UpdateDeleteEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDeleteEmployeeForm";
            textBoxGender.ResumeLayout(false);
            textBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmp).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            EmployeeGroupBox.ResumeLayout(false);
            EmployeeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button editInfoBtn;
        private Button removeInfoBtn;
        private Button uploadButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private GroupBox EmployeeGroupBox;
        private Button findBtn;
        private Label label8;
        internal TextBox textBoxFname;
        internal TextBox textBoxID;
        internal GroupBox textBoxGender;
        internal PictureBox pictureBoxEmp;
        internal DateTimePicker textBoxDate;
        internal TextBox textBoxPhone;
        internal TextBox textBoxAddress;
        internal TextBox textBoxLname;
        internal RadioButton radioButtonFemale;
        internal RadioButton radioButtonMale;
    }
}