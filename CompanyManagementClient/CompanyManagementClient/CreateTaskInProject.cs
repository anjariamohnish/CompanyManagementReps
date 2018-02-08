using CompanyManagementClient.CompanyManagementServiceReference;
using System;
using System.Windows.Forms;

namespace CompanyManagementClient
{
    public partial class CreateTaskInProject : Form
    {
        public CreateTaskInProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CompanyMangementServiceClient serviceReference = new CompanyMangementServiceClient();
            BOTask task = new BOTask();
            task.Name = textBox2.Text;
            task.TechnologyMasterId = Convert.ToInt32(textBox1.Text);
            task.StatusId = Convert.ToInt32(textBox3.Text);

            popup pop = new popup(serviceReference.CreateTaskInProject(task, Convert.ToInt32(textBox5.Text)));
            pop.ShowDialog();
            this.Close();
        }
    }
}
