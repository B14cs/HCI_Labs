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
        public Main()
        {
            InitializeComponent();
        }

        private void quiz_Click(object sender, EventArgs e)
        {
            var quiz = new Quiz();
            Console.Beep();
            this.Hide();
            quiz.Show();
        }

        private void message_Click(object sender, EventArgs e)
        {
            var messages = new Messages();
            Console.Beep();
            this.Hide();
            messages.Show();
        }

        private void wordpad_Click(object sender, EventArgs e)
        {
            var wordPad = new WordPad();
            Console.Beep();
            this.Hide();
            wordPad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
