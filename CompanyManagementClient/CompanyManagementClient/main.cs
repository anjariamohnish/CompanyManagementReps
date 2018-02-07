using System;
using System.Windows.Forms;

namespace CompanyManagementClient
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteTechnology delForm = new DeleteTechnology();
            delForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AssignTechnologyToTask assignForm = new AssignTechnologyToTask();
            assignForm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProject addProjectForm = new AddProject();
            addProjectForm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignEmployeeToProject assignEmployeeForm = new AssignEmployeeToProject();
            assignEmployeeForm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteTask delTaskForm = new DeleteTask();
            delTaskForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteProject delProjectForm = new DeleteProject();
            delProjectForm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CreateTaskInProject createTaskForm = new CreateTaskInProject();
            createTaskForm.ShowDialog();

        }
    }
}
