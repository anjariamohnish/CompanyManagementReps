using CompanyManagementClient.CompanyManagementServiceReference;
using System;
using System.Windows.Forms;

namespace CompanyManagementClient
{
    public partial class AssignTechnologyToTask : Form
    {
        public AssignTechnologyToTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CompanyMangementServiceClient serviceReference = new CompanyMangementServiceClient();

            popup pop = new popup(serviceReference.AssignTechnologyToTask(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            pop.ShowDialog();
            this.Close();
        }
    }
}
