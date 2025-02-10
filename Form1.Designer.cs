namespace CsharpRentalApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDepartmentID;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            listBoxEmployees = new ListBox();
            btnGet = new Button();
            btnPost = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtDepartmentID = new TextBox();
            lblName = new Label();
            lblEmail = new Label();
            lblDepartmentID = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(120, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(297, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Rental System";
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.Font = new Font("Arial", 10F);
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 19;
            listBoxEmployees.Location = new Point(20, 60);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(450, 118);
            listBoxEmployees.TabIndex = 1;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // btnGet
            // 
            btnGet.BackColor = Color.LightSkyBlue;
            btnGet.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnGet.Location = new Point(20, 200);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(220, 40);
            btnGet.TabIndex = 2;
            btnGet.Text = "Load Employees";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.LightGreen;
            btnPost.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnPost.Location = new Point(250, 200);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(220, 40);
            btnPost.TabIndex = 3;
            btnPost.Text = "Add Employee";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += btnPost_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 10F);
            txtName.Location = new Point(150, 260);
            txtName.Name = "txtName";
            txtName.Size = new Size(320, 27);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 10F);
            txtEmail.Location = new Point(150, 300);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Font = new Font("Arial", 10F);
            txtDepartmentID.Location = new Point(150, 340);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Size = new Size(320, 27);
            txtDepartmentID.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblName.Location = new Point(20, 263);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 19);
            lblName.TabIndex = 7;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(20, 303);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 19);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // lblDepartmentID
            // 
            lblDepartmentID.AutoSize = true;
            lblDepartmentID.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDepartmentID.Location = new Point(20, 343);
            lblDepartmentID.Name = "lblDepartmentID";
            lblDepartmentID.Size = new Size(128, 19);
            lblDepartmentID.TabIndex = 9;
            lblDepartmentID.Text = "Department ID:";
            // 
            // Form1
            // 
            ClientSize = new Size(500, 400);
            Controls.Add(lblTitle);
            Controls.Add(listBoxEmployees);
            Controls.Add(btnGet);
            Controls.Add(btnPost);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtDepartmentID);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(lblDepartmentID);
            Name = "Form1";
            Text = "Rental Employee System";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
