namespace TaskThree
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            existEmployee = new Button();
            viewEmployee = new Button();
            addEmployee = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 111);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(176, 25);
            label1.Name = "label1";
            label1.Size = new Size(878, 59);
            label1.TabIndex = 0;
            label1.Text = "Employee Personal Information";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(existEmployee);
            panel2.Controls.Add(viewEmployee);
            panel2.Controls.Add(addEmployee);
            panel2.Location = new Point(14, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 560);
            panel2.TabIndex = 1;
            // 
            // existEmployee
            // 
            existEmployee.BackColor = SystemColors.Highlight;
            existEmployee.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            existEmployee.ForeColor = Color.White;
            existEmployee.Location = new Point(45, 394);
            existEmployee.Name = "existEmployee";
            existEmployee.Size = new Size(429, 88);
            existEmployee.TabIndex = 2;
            existEmployee.Text = "Exist";
            existEmployee.UseVisualStyleBackColor = false;
            existEmployee.Click += existEmployee_Click;
            // 
            // viewEmployee
            // 
            viewEmployee.BackColor = SystemColors.Highlight;
            viewEmployee.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            viewEmployee.ForeColor = Color.White;
            viewEmployee.Location = new Point(45, 232);
            viewEmployee.Name = "viewEmployee";
            viewEmployee.Size = new Size(429, 88);
            viewEmployee.TabIndex = 1;
            viewEmployee.Text = "View Employee";
            viewEmployee.UseVisualStyleBackColor = false;
            viewEmployee.Click += viewEmployee_Click;
            // 
            // addEmployee
            // 
            addEmployee.BackColor = SystemColors.Highlight;
            addEmployee.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addEmployee.ForeColor = Color.White;
            addEmployee.Location = new Point(45, 76);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(429, 88);
            addEmployee.TabIndex = 0;
            addEmployee.Text = "Add Employee";
            addEmployee.UseVisualStyleBackColor = false;
            addEmployee.Click += addEmployee_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(541, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(737, 558);
            panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 707);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button addEmployee;
        private Button existEmployee;
        private Button viewEmployee;
        private Panel panel3;
    }
}