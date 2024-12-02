using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace PixisAirGroupProject
{
    public partial class AddCustomersForm : Form
    {
        public AddCustomersForm()
        {
            InitializeComponent();
        }

        private void AddCustomersForm_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            string connectionString = "DataSource=10.250.0.30";
            string query = "INSERT INTO Customer (CustomerID, Name, Address, PhoneNumber, Email) VALUES (@CustomerID, @Name, @Address, @PhoneNumber, @Email)";

            using (iDB2Connection connection = new iDB2Connection(connectionString))
            {
                using (iDB2Command command = new iDB2Command(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding customer: " + ex.Message);
                    }
                }
            }
        }
        
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)// Add Customer Menu Item Click Event
        {
            // Call the same method as the Add Customer button click event
            AddCustomerButton_Click(sender, e);
        }

        // Exit Menu Item Click Event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                
            
        
    
