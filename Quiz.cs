using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI
{
    public partial class Quiz : Form
    {
        int modeFlag;
        public Quiz(int modeFlag)
        {
            this.modeFlag = modeFlag;
            InitializeComponent();
            if (modeFlag == 1)
            {
                this.BackColor = Color.FromArgb(60, 63, 65);
                label1.ForeColor = Color.FromArgb(187, 187, 187);
                boyLable.ForeColor = Color.FromArgb(187, 187, 187);
                girlLable.ForeColor = Color.FromArgb(187, 187, 187);
            }
        }

        private void girl_DragEnter(object sender, DragEventArgs e)
        {
            girlLable.Visible = false;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void boy_DragEnter(object sender, DragEventArgs e)
        {
            boyLable.Visible = false;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            boy.AllowDrop = true;
            boyLable.Visible = true;

            girl.AllowDrop = true;
            girlLable.Visible = true;
        }

        private void boy_DragLeave(object sender, EventArgs e)
        {
            boyLable.Visible = true;
        }

        private void girl_DragLeave(object sender, EventArgs e)
        {
            girlLable.Visible = true;
        }

        private void boy_DragDrop(object sender, DragEventArgs e)
        {
            boy.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (boy.Image != boyPic.Image)
            {
                MessageBox.Show("WTF!!");
                boy.Image = null;
                boyLable.Visible = true;
            }
            else
            { 
                next(); 
            }
        }

        private void girl_DragDrop(object sender, DragEventArgs e)
        {
            girl.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (girl.Image != girlPic.Image)
            {
                MessageBox.Show("WTF!!");
                girl.Image = null;
                girlLable.Visible = true;
            }
            else 
            {
                next(); 
            }
        }

        private void next()
        {
            if(boy.Image == boyPic.Image && girl.Image == girlPic.Image)
            {
                this.Close();
                var quiz2 = new Quiz2(modeFlag);
                quiz2.Show();
            }
        }
    }
}
