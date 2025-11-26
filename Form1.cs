// Smiths Auto Repair Price Quote Calculator
// Name: Jawharah Mused
// Date: 9/26/2024
// Course: CIS 199

using System;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        // Constants for fixed values
        const double CONSULTATION_FEE = 100.0; // Fixed consultation fee for all jobs
        const double LABOR_CHARGE = 75.0;      // Charge per hour per staff member assigned
        const double SENIOR_DISCOUNT = 0.1;    // Discount rate for senior citizens (10%)

        public Form1()
        {
            InitializeComponent(); // Initializes the components of the form
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            // Variables to hold user input values, with default initialization
            string clientName = txtClientName.Text;               // Reading client's name from TextBox
            string carType = txtCarType.Text;                     // Reading car type from TextBox
            int workHours = 0;                                    // Variable to store work hours, initialized to 0
            double partsCost = 0.0;                               // Variable to store parts cost, initialized to 0.0
            int staffAssigned = 0;                                // Variable to store number of staff, initialized to 0
            int isSeniorCitizen = 0;                              // Variable to store senior citizen status (0 or 1), initialized to 0

            // Validating and converting input values from TextBoxes
            bool workHoursValid = int.TryParse(txtWorkHours.Text, out workHours);
            bool partsCostValid = double.TryParse(txtPartsCost.Text, out partsCost);
            bool staffAssignedValid = int.TryParse(txtStaffAssigned.Text, out staffAssigned);
            bool isSeniorCitizenValid = int.TryParse(txtSeniorCitizen.Text, out isSeniorCitizen);

            // Check if all inputs are valid
            if (!workHoursValid || !partsCostValid || !staffAssignedValid || !isSeniorCitizenValid)
            {
                // Display an error message if any input is invalid
                MessageBox.Show("Please enter valid numbers for Work Hours, Parts Cost, Staff Assigned, and Senior Citizen status.", "Input Error");
                return; // Exit the method if input is invalid
            }

            // Ensure isSeniorCitizen is either 0 or 1 to avoid invalid discount application
            if (isSeniorCitizen != 0 && isSeniorCitizen != 1)
            {
                MessageBox.Show("Senior Citizen status must be 0 (No) or 1 (Yes).", "Input Error");
                return;
            }

            // Calculating the total cost before applying any discount
            double totalCost = CONSULTATION_FEE + (LABOR_CHARGE * workHours * staffAssigned) + partsCost;

            // Applying the senior discount if applicable
            double finalCost = totalCost - (totalCost * SENIOR_DISCOUNT * isSeniorCitizen);

            // Displaying the final cost in the Total Cost TextBox, formatted as currency
            txtTotalCost.Text = finalCost.ToString("C"); // Formats the output as currency
        }

         private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtStaffAssigned4_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSeniorCitizen_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
        }
    }
}
