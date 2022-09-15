using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HCI
{
    public partial class WordPad : Form
    {
        public WordPad()
        {
            InitializeComponent();
        }

        private void WordPad_Load(object sender, EventArgs e)
        {
            Graphics g = richTextBox1.CreateGraphics();
            foreach(FontFamily fontFamily in FontFamily.GetFamilies(g))
            {
                toolStripComboBox1.Items.Add(fontFamily.Name);
            }
            for(int i=7; i<=70 ; i += 7)
            {
                toolStripComboBox2.Items.Add(i.ToString());
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open";
            open.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if(open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save";
            save.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                this.Text = save.FileName;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if(font != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, font.Style ^ FontStyle.Bold);
            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, font.Style ^ FontStyle.Italic);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, font.Style ^ FontStyle.Underline);
        }

        private void SetNewFont()
        {
            Font oldFont, newFont;
            String fontName;
            float fontSize = 8;
            FontStyle fontStyle;
            byte charset = 0;

            fontName = toolStripComboBox1.Text;
            if (string.IsNullOrEmpty(toolStripComboBox2.Text))
                fontSize = 8;
            else
                fontSize = float.Parse(toolStripComboBox2.Text);
            
            oldFont = richTextBox1.SelectionFont;

            if(oldFont == null)
                fontStyle = FontStyle.Regular;
            else
            {
                fontStyle = oldFont.Style;
                charset = oldFont.GdiCharSet;
            }

            newFont = new Font(fontName, fontSize, fontStyle, GraphicsUnit.Point, charset);
            richTextBox1.SelectionFont = newFont;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }
    }
}
