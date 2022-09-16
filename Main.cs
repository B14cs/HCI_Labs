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
    public partial class Main : Form
    {
        int modeFlag;

        public Main(int modeFlag)
        {
            this.modeFlag = modeFlag;
            InitializeComponent();
            if (modeFlag == 1)
            {
                this.BackColor = Color.FromArgb(60, 63, 65);
                quiz.BackColor = Color.FromArgb(70, 73, 75);
                quiz.ForeColor = Color.FromArgb(187, 187, 187);
                message.BackColor = Color.FromArgb(70, 73, 75);
                message.ForeColor = Color.FromArgb(187, 187, 187);
                wordpad.BackColor = Color.FromArgb(70, 73, 75);
                wordpad.ForeColor = Color.FromArgb(187, 187, 187);
                darkMode.BackColor = Color.FromArgb(70, 73, 75);
                darkMode.ForeColor = Color.FromArgb(187, 187, 187);
                button1.BackColor = Color.FromArgb(70, 73, 75);
                button1.ForeColor = Color.FromArgb(187, 187, 187);
            }
        }

        private void quiz_Click(object sender, EventArgs e)
        {
            var quiz = new Quiz(modeFlag);
            Console.Beep();
            this.Hide();
            quiz.Show();
        }

        private void message_Click(object sender, EventArgs e)
        {
            var messages = new Messages(modeFlag);
            Console.Beep();
            this.Hide();
            messages.Show();
        }

        private void wordpad_Click(object sender, EventArgs e)
        {
            var wordPad = new WordPad(modeFlag);
            Console.Beep();
            this.Hide();
            wordPad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void darkMode_Click(object sender, EventArgs e)
        {
            if (modeFlag == 0)
            {
                this.modeFlag = 1;
                this.BackColor = Color.FromArgb(60, 63, 65);
                quiz.BackColor = Color.FromArgb(70, 73, 75);
                quiz.ForeColor = Color.FromArgb(187, 187, 187);
                message.BackColor = Color.FromArgb(70, 73, 75);
                message.ForeColor = Color.FromArgb(187, 187, 187);
                wordpad.BackColor = Color.FromArgb(70, 73, 75);
                wordpad.ForeColor = Color.FromArgb(187, 187, 187);
                darkMode.BackColor = Color.FromArgb(70, 73, 75);
                darkMode.ForeColor = Color.FromArgb(187, 187, 187);
                button1.BackColor = Color.FromArgb(70, 73, 75);
                button1.ForeColor = Color.FromArgb(187, 187, 187);
            }
            else
            {
                this.modeFlag = 0;
                this.BackColor = Control.DefaultBackColor;
                quiz.BackColor = Control.DefaultBackColor;
                quiz.ForeColor = Control.DefaultForeColor;
                message.BackColor = Control.DefaultBackColor;
                message.ForeColor = Control.DefaultForeColor;
                wordpad.BackColor = Control.DefaultBackColor;
                wordpad.ForeColor = Control.DefaultForeColor;
                darkMode.BackColor = Control.DefaultBackColor;
                darkMode.ForeColor = Control.DefaultForeColor;
                button1.BackColor = Control.DefaultBackColor;
                button1.ForeColor = Control.DefaultForeColor;
            }
        }
    }
}
