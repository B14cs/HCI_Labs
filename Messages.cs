using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI
{
    public partial class Messages : Form
    {
        int modeFlag;
        public Messages(int modeFlag)
        {
            this.modeFlag = modeFlag;
            InitializeComponent();
            if (modeFlag == 1)
            {
                this.BackColor = Color.FromArgb(60, 63, 65);
                alert.BackColor = Color.FromArgb(60, 63, 65);
                alert.ForeColor = Color.FromArgb(187, 187, 187);
                information.BackColor = Color.FromArgb(60, 63, 65);
                information.ForeColor = Color.FromArgb(187, 187, 187);
                warning.BackColor = Color.FromArgb(60, 63, 65);
                warning.ForeColor = Color.FromArgb(187, 187, 187);
                question.BackColor = Color.FromArgb(60, 63, 65);
                question.ForeColor = Color.FromArgb(187, 187, 187);
            }
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
                Main main = new Main(modeFlag);
                main.Show();
            }
        }
    }
}
