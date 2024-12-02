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
    public partial class ListJobsForm : Form
    {
        public ListJobsForm()
        {
            InitializeComponent();

            // Ensure AutoGenerateColumns is set to true
            dataGridView1.AutoGenerateColumns = true;
        }

        private void ListJobsForm_Load(object sender, EventArgs e)
        {
             DataTable jobData = GetJobData();
            dataGridView1.DataSource = jobData;
        }
       
        
        private DataTable GetJobData()
        {
            string connectionString = "DataSource=10.250.0.30";
            string query = "SELECT * FROM FLIGHT2024.CUSTOMER";

            DataTable dt = new DataTable();

            using (iDB2Connection connection = new iDB2Connection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (iDB2Command command = new iDB2Command(query, connection))
                    {
                        using (iDB2DataAdapter adapter = new iDB2DataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving job data: " + ex.Message);
                }
            }
            return dt;
        }
    }
}
