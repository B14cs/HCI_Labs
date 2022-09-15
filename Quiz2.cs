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
    public partial class Quiz2 : Form
    {
        public Quiz2()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            catLable.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            catLable.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            dogLabel.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            dogLabel.Visible = false;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            lionLabel.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            lionLabel.Visible = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            monkeyLabel.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            monkeyLabel.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Congratulations, You've won!", "Won");
            if (dialogResult == DialogResult.OK)
            {
                var main = new Main();
                this.Close();
                main.Show();
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try again..", "Seriously!!");
        }
    }
}
