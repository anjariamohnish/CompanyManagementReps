using System.Windows.Forms;

namespace CompanyManagementClient
{
    public partial class popup : Form
    {
        public popup(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
