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
            this.lblTitle = new System.Windows.Forms.Label();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 🔹 Title Label
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee Rental System";

            // 🔹 Employee ListBox
            this.listBoxEmployees.Font = new System.Drawing.Font("Arial", 10F);
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 16;
            this.listBoxEmployees.Location = new System.Drawing.Point(20, 60);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(450, 120);
            this.listBoxEmployees.TabIndex = 1;

            // 🔹 GET Button
            this.btnGet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnGet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGet.Location = new System.Drawing.Point(20, 200);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(220, 40);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Load Employees";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);

            // 🔹 POST Button
            this.btnPost.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPost.BackColor = System.Drawing.Color.LightGreen;
            this.btnPost.Location = new System.Drawing.Point(250, 200);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(220, 40);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Add Employee";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);

            // 🔹 Text Fields
            this.txtName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtName.Location = new System.Drawing.Point(150, 260);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 23);
            this.txtName.TabIndex = 4;

            this.txtEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEmail.Location = new System.Drawing.Point(150, 300);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 23);
            this.txtEmail.TabIndex = 5;

            this.txtDepartmentID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDepartmentID.Location = new System.Drawing.Point(150, 340);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(320, 23);
            this.txtDepartmentID.TabIndex = 6;

            // 🔹 Labels
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(20, 263);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(20, 303);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";

            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentID.Location = new System.Drawing.Point(20, 343);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(116, 16);
            this.lblDepartmentID.TabIndex = 9;
            this.lblDepartmentID.Text = "Department ID:";

            // 🔹 Form1
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDepartmentID);
            this.Name = "Form1";
            this.Text = "Rental Employee System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
