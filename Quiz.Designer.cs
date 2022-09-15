namespace HCI
{
    partial class Quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.boyPic = new System.Windows.Forms.PictureBox();
            this.girlPic = new System.Windows.Forms.PictureBox();
            this.girl = new System.Windows.Forms.PictureBox();
            this.boy = new System.Windows.Forms.PictureBox();
            this.boyLable = new System.Windows.Forms.Label();
            this.girlLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boy)).BeginInit();
            this.SuspendLayout();
            // 
            // boyPic
            // 
            this.boyPic.Image = ((System.Drawing.Image)(resources.GetObject("boyPic.Image")));
            this.boyPic.Location = new System.Drawing.Point(26, 79);
            this.boyPic.Name = "boyPic";
            this.boyPic.Size = new System.Drawing.Size(125, 125);
            this.boyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boyPic.TabIndex = 0;
            this.boyPic.TabStop = false;
            this.boyPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            // 
            // girlPic
            // 
            this.girlPic.Image = ((System.Drawing.Image)(resources.GetObject("girlPic.Image")));
            this.girlPic.Location = new System.Drawing.Point(230, 79);
            this.girlPic.Name = "girlPic";
            this.girlPic.Size = new System.Drawing.Size(125, 125);
            this.girlPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girlPic.TabIndex = 1;
            this.girlPic.TabStop = false;
            this.girlPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            // 
            // girl
            // 
            this.girl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.girl.Location = new System.Drawing.Point(230, 250);
            this.girl.Name = "girl";
            this.girl.Size = new System.Drawing.Size(125, 125);
            this.girl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girl.TabIndex = 3;
            this.girl.TabStop = false;
            this.girl.DragDrop += new System.Windows.Forms.DragEventHandler(this.girl_DragDrop);
            this.girl.DragEnter += new System.Windows.Forms.DragEventHandler(this.girl_DragEnter);
            this.girl.DragLeave += new System.EventHandler(this.girl_DragLeave);
            // 
            // boy
            // 
            this.boy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boy.Location = new System.Drawing.Point(26, 250);
            this.boy.Name = "boy";
            this.boy.Size = new System.Drawing.Size(125, 125);
            this.boy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boy.TabIndex = 2;
            this.boy.TabStop = false;
            this.boy.DragDrop += new System.Windows.Forms.DragEventHandler(this.boy_DragDrop);
            this.boy.DragEnter += new System.Windows.Forms.DragEventHandler(this.boy_DragEnter);
            this.boy.DragLeave += new System.EventHandler(this.boy_DragLeave);
            // 
            // boyLable
            // 
            this.boyLable.AutoSize = true;
            this.boyLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boyLable.Location = new System.Drawing.Point(60, 297);
            this.boyLable.Name = "boyLable";
            this.boyLable.Size = new System.Drawing.Size(57, 29);
            this.boyLable.TabIndex = 4;
            this.boyLable.Text = "Boy";
            // 
            // girlLable
            // 
            this.girlLable.AutoSize = true;
            this.girlLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girlLable.Location = new System.Drawing.Point(268, 297);
            this.girlLable.Name = "girlLable";
            this.girlLable.Size = new System.Drawing.Size(55, 29);
            this.girlLable.TabIndex = 5;
            this.girlLable.Text = "Girl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Drag and Drop";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girlLable);
            this.Controls.Add(this.boyLable);
            this.Controls.Add(this.girl);
            this.Controls.Add(this.boy);
            this.Controls.Add(this.girlPic);
            this.Controls.Add(this.boyPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girlPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boyPic;
        private System.Windows.Forms.PictureBox girlPic;
        private System.Windows.Forms.PictureBox girl;
        private System.Windows.Forms.PictureBox boy;
        private System.Windows.Forms.Label boyLable;
        private System.Windows.Forms.Label girlLable;
        private System.Windows.Forms.Label label1;
    }
}