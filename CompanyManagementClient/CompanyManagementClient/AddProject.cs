using CompanyManagementClient.CompanyManagementServiceReference;
using System;
using System.Windows.Forms;

namespace CompanyManagementClient
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CompanyMangementServiceClient serviceReference = new CompanyMangementServiceClient();
            BOProject project = new BOProject();

            project.Name = textBox1.Text;
            project.DepartmentMasterId = Convert.ToInt32(textBox2.Text);
            project.ProjectManagerId = Convert.ToInt32(textBox3.Text);
            project.ClientId = Convert.ToInt32(textBox4.Text);
            project.StatusMasterId = Convert.ToInt32(textBox5.Text);

            popup pop = new popup(serviceReference.AddProject(project));
            pop.ShowDialog();
            this.Close();
        }
    }
}
