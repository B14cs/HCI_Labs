using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI
{
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void alert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error Message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Message", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void warning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning Message", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void question_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to exit ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Main main = new Main();
                main.Show();
            }
        }
    }
}
