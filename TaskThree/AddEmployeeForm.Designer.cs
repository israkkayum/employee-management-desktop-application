namespace TaskThree
{
    partial class AddEmployeeForm
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
            panel1 = new Panel();
            label1 = new Label();
            EmployeeGroupBox = new GroupBox();
            textBoxGender = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            cancleInfoBtn = new Button();
            addInfoBtn = new Button();
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
            panel1.SuspendLayout();
            EmployeeGroupBox.SuspendLayout();
            textBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmp).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 134);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            label1.Click += label1_Click;
            // 
            // EmployeeGroupBox
            // 
            EmployeeGroupBox.BackColor = SystemColors.ButtonFace;
            EmployeeGroupBox.Controls.Add(textBoxGender);
            EmployeeGroupBox.Controls.Add(cancleInfoBtn);
            EmployeeGroupBox.Controls.Add(addInfoBtn);
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
            EmployeeGroupBox.Location = new Point(12, 162);
            EmployeeGroupBox.Name = "EmployeeGroupBox";
            EmployeeGroupBox.Size = new Size(1377, 663);
            EmployeeGroupBox.TabIndex = 1;
            EmployeeGroupBox.TabStop = false;
            EmployeeGroupBox.Text = "Employee";
            EmployeeGroupBox.Enter += EmployeeGroupBox_Enter;
            // 
            // textBoxGender
            // 
            textBoxGender.Controls.Add(radioButtonFemale);
            textBoxGender.Controls.Add(radioButtonMale);
            textBoxGender.Location = new Point(510, 318);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.Size = new Size(306, 58);
            textBoxGender.TabIndex = 19;
            textBoxGender.TabStop = false;
            textBoxGender.Enter += textBoxGender_Enter;
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
            radioButtonFemale.CheckedChanged += radioButtonFemale_CheckedChanged;
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
            radioButtonMale.CheckedChanged += radioButtonMale_CheckedChanged;
            // 
            // cancleInfoBtn
            // 
            cancleInfoBtn.BackColor = SystemColors.Highlight;
            cancleInfoBtn.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancleInfoBtn.Location = new Point(916, 541);
            cancleInfoBtn.Name = "cancleInfoBtn";
            cancleInfoBtn.Size = new Size(150, 46);
            cancleInfoBtn.TabIndex = 18;
            cancleInfoBtn.Text = "Cancel";
            cancleInfoBtn.UseVisualStyleBackColor = false;
            cancleInfoBtn.Click += cancleInfoBtn_Click;
            // 
            // addInfoBtn
            // 
            addInfoBtn.BackColor = SystemColors.Highlight;
            addInfoBtn.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addInfoBtn.Location = new Point(1155, 541);
            addInfoBtn.Name = "addInfoBtn";
            addInfoBtn.Size = new Size(150, 46);
            addInfoBtn.TabIndex = 17;
            addInfoBtn.Text = "Add";
            addInfoBtn.UseVisualStyleBackColor = false;
            addInfoBtn.Click += addInfoBtn_Click;
            // 
            // uploadButton
            // 
            uploadButton.BackColor = SystemColors.ControlDark;
            uploadButton.Location = new Point(916, 462);
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
            pictureBoxEmp.Location = new Point(916, 103);
            pictureBoxEmp.Name = "pictureBoxEmp";
            pictureBoxEmp.Size = new Size(389, 336);
            pictureBoxEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEmp.TabIndex = 15;
            pictureBoxEmp.TabStop = false;
            pictureBoxEmp.Click += pictureBoxEmp_Click;
            // 
            // textBoxDate
            // 
            textBoxDate.CustomFormat = "dd/mm/yyyy";
            textBoxDate.Format = DateTimePickerFormat.Custom;
            textBoxDate.Location = new Point(510, 243);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(306, 39);
            textBoxDate.TabIndex = 14;
            textBoxDate.ValueChanged += textBoxDate_ValueChanged;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(510, 400);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(306, 39);
            textBoxPhone.TabIndex = 11;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(510, 476);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(306, 101);
            textBoxAddress.TabIndex = 9;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // textBoxLname
            // 
            textBoxLname.Location = new Point(510, 172);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(306, 39);
            textBoxLname.TabIndex = 8;
            textBoxLname.TextChanged += textBoxLname_TextChanged;
            // 
            // textBoxFname
            // 
            textBoxFname.Location = new Point(510, 103);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(306, 39);
            textBoxFname.TabIndex = 7;
            textBoxFname.TextChanged += textBoxFname_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(118, 476);
            label7.Name = "label7";
            label7.Size = new Size(136, 32);
            label7.TabIndex = 5;
            label7.Text = "Address";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(118, 400);
            label6.Name = "label6";
            label6.Size = new Size(109, 32);
            label6.TabIndex = 4;
            label6.Text = "Phone";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(118, 318);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(118, 243);
            label4.Name = "label4";
            label4.Size = new Size(158, 32);
            label4.TabIndex = 2;
            label4.Text = "BirthDate";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(118, 172);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 1;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 103);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 0;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 848);
            Controls.Add(EmployeeGroupBox);
            Controls.Add(panel1);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            EmployeeGroupBox.ResumeLayout(false);
            EmployeeGroupBox.PerformLayout();
            textBoxGender.ResumeLayout(false);
            textBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox EmployeeGroupBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker textBoxDate;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxLname;
        private TextBox textBoxFname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button cancleInfoBtn;
        private Button addInfoBtn;
        private Button uploadButton;
        private PictureBox pictureBoxEmp;
        private GroupBox textBoxGender;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
    }
}