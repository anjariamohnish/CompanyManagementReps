using CompanyManagementClient.CompanyManagementServiceReference;
using System;
using System.Windows.Forms;
namespace CompanyManagementClient
{
    public partial class DeleteTechnology : Form
    {
        public DeleteTechnology()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CompanyMangementServiceClient serviceReference = new CompanyMangementServiceClient();

            popup pop = new popup(serviceReference.DeleteTechnology(Convert.ToInt32(textBox1.Text)));
            pop.ShowDialog();

            this.Close();
        }
    }
}
