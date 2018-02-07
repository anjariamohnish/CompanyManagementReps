using CompanyManagementClient.CompanyManagementServiceReference;
using System;
using System.Windows.Forms;

namespace CompanyManagementClient
{
    public partial class AssignEmployeeToProject : Form
    {
        public AssignEmployeeToProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyMangementServiceClient serviceReference = new CompanyMangementServiceClient();

            popup pop = new popup(serviceReference.AssignEmployeeToProject(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            pop.ShowDialog();
            this.Close();
        }
    }
}
