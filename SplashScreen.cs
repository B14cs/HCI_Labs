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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += new Random().Next(20);
            if(panel1.Width >= 300)
            {
                timer1.Stop();
                var f2 = new Login();
                Console.Beep();
                this.Hide();
                f2.Closed += (s, args) => this.Close();
                f2.Show();
            }
        }

    }
}
