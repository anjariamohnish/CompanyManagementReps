using CompanyManagementClient.CompanyManagementServiceReference;
using System;
using System.Windows.Forms;

namespace CompanyManagementClient
{
    public partial class DeleteProject : Form
    {
        public DeleteProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyMangementServiceClient serviceReference = new CompanyMangementServiceClient();

            popup pop = new popup(serviceReference.DeleteProject(Convert.ToInt32(textBox1.Text)));
            pop.ShowDialog();
            this.Close();
        }
    }
}
