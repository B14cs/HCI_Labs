namespace HCI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.quiz = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Button();
            this.wordpad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.darkMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quiz
            // 
            this.quiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quiz.FlatAppearance.BorderSize = 0;
            this.quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.quiz.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quiz.Location = new System.Drawing.Point(75, 60);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(250, 40);
            this.quiz.TabIndex = 3;
            this.quiz.Text = "Quiz";
            this.toolTip1.SetToolTip(this.quiz, "MCQs");
            this.quiz.UseVisualStyleBackColor = true;
            this.quiz.Click += new System.EventHandler(this.quiz_Click);
            // 
            // message
            // 
            this.message.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.message.FlatAppearance.BorderSize = 0;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.message.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.message.Location = new System.Drawing.Point(75, 135);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(250, 40);
            this.message.TabIndex = 4;
            this.message.Text = "Messages";
            this.toolTip1.SetToolTip(this.message, "Types of Messages");
            this.message.UseVisualStyleBackColor = true;
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // wordpad
            // 
            this.wordpad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.wordpad.FlatAppearance.BorderSize = 0;
            this.wordpad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.wordpad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wordpad.Location = new System.Drawing.Point(75, 210);
            this.wordpad.Name = "wordpad";
            this.wordpad.Size = new System.Drawing.Size(250, 40);
            this.wordpad.TabIndex = 5;
            this.wordpad.Text = "WordPad";
            this.toolTip1.SetToolTip(this.wordpad, "Mini WordPad");
            this.wordpad.UseVisualStyleBackColor = true;
            this.wordpad.Click += new System.EventHandler(this.wordpad_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(75, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // darkMode
            // 
            this.darkMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.darkMode.FlatAppearance.BorderSize = 0;
            this.darkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.darkMode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.darkMode.Location = new System.Drawing.Point(75, 285);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(250, 40);
            this.darkMode.TabIndex = 7;
            this.darkMode.Text = "Dark mode";
            this.darkMode.UseVisualStyleBackColor = true;
            this.darkMode.Click += new System.EventHandler(this.darkMode_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wordpad);
            this.Controls.Add(this.message);
            this.Controls.Add(this.quiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HCI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quiz;
        private System.Windows.Forms.Button message;
        private System.Windows.Forms.Button wordpad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button darkMode;
    }
}