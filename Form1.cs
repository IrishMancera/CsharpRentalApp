using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace CsharpRentalApp
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client = new HttpClient();
        private const string ApiUrl = "http://localhost/rental-api/api.php"; // Ensure this URL is correct

        public Form1()
        {
            InitializeComponent();
        }

        // ✅ Fetch Employees from API (GET Request)
        private async void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(ApiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize JSON response
                List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(responseBody);

                // Clear and update ListBox
                listBoxEmployees.Items.Clear();
                foreach (var emp in employees)
                {
                    listBoxEmployees.Items.Add($"{emp.EmployeeID}: {emp.Name} - {emp.Email} ({emp.Department})");
                }

                MessageBox.Show("Data Loaded Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Add Employee to API (POST Request)
        private async void btnPost_Click(object sender, EventArgs e)
        {
            // Validate Inputs
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentID.Text))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Department ID
            if (!int.TryParse(txtDepartmentID.Text, out int departmentID))
            {
                MessageBox.Show("Invalid Department ID. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newEmployee = new
            {
                name = txtName.Text.Trim(),
                email = txtEmail.Text.Trim(),
                department_id = departmentID
            };

            string jsonData = JsonConvert.SerializeObject(newEmployee);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync(ApiUrl, content);
                string responseMessage = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh Data
                    btnGet_Click(sender, e);

                    // Clear form fields
                    txtName.Clear();
                    txtEmail.Clear();
                    txtDepartmentID.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add employee: " + responseMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // ✅ Employee Model
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int DepartmentID { get; set; }
    }
}
