using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirGroupProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListJobsButton_Click(object sender, EventArgs e)
        {
            ListJobsForm listJobsForm = new ListJobsForm();
           listJobsForm.Show();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
           AddCustomersForm addCustomersForm = new AddCustomersForm(); 
            addCustomersForm.Show();
        }

        private void listJobsFormToolStripMenuItem_Click(object sender, EventArgs e)// Open List Jobs Form Menu Item Click Event
        {
            ListJobsForm listJobsForm = new ListJobsForm();
            listJobsForm.Show();
        }

        private void addCustomersFormToolStripMenuItem_Click(object sender, EventArgs e)// Open Add Customer Form Menu Item Click Event
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm();
            addCustomersForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)// Exit Menu Item Click Event
        {
            this.Close();
        }
    }
}
