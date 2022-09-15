namespace HCI
{
    partial class Messages
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
            this.warning = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Button();
            this.alert = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // warning
            // 
            this.warning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.warning.FlatAppearance.BorderSize = 0;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.warning.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.warning.Location = new System.Drawing.Point(75, 245);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(250, 40);
            this.warning.TabIndex = 8;
            this.warning.Text = "Warning";
            this.warning.UseVisualStyleBackColor = true;
            this.warning.Click += new System.EventHandler(this.warning_Click);
            // 
            // information
            // 
            this.information.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.information.FlatAppearance.BorderSize = 0;
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.information.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.information.Location = new System.Drawing.Point(75, 161);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(250, 40);
            this.information.TabIndex = 7;
            this.information.Text = "Information";
            this.information.UseVisualStyleBackColor = true;
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // alert
            // 
            this.alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alert.FlatAppearance.BorderSize = 0;
            this.alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.alert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.alert.Location = new System.Drawing.Point(75, 81);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(250, 40);
            this.alert.TabIndex = 6;
            this.alert.Text = "Alert";
            this.alert.UseVisualStyleBackColor = true;
            this.alert.Click += new System.EventHandler(this.alert_Click);
            // 
            // question
            // 
            this.question.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.question.FlatAppearance.BorderSize = 0;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.question.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.question.Location = new System.Drawing.Point(75, 327);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(250, 40);
            this.question.TabIndex = 9;
            this.question.Text = "Go back";
            this.question.UseVisualStyleBackColor = true;
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.question);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.information);
            this.Controls.Add(this.alert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Messages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button warning;
        private System.Windows.Forms.Button information;
        private System.Windows.Forms.Button alert;
        private System.Windows.Forms.Button question;
    }
}