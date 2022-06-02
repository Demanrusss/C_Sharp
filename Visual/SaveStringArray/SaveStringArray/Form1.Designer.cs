namespace SaveStringArray
{
    partial class Form1
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
            this.userListBox = new System.Windows.Forms.ListBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.addUserTextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(12, 38);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(520, 394);
            this.userListBox.TabIndex = 0;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(12, 12);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(439, 20);
            this.userTextBox.TabIndex = 1;
            // 
            // addUserTextButton
            // 
            this.addUserTextButton.Location = new System.Drawing.Point(457, 12);
            this.addUserTextButton.Name = "addUserTextButton";
            this.addUserTextButton.Size = new System.Drawing.Size(75, 23);
            this.addUserTextButton.TabIndex = 2;
            this.addUserTextButton.Text = "Add";
            this.addUserTextButton.UseVisualStyleBackColor = true;
            this.addUserTextButton.Click += new System.EventHandler(this.addUserTextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 449);
            this.Controls.Add(this.addUserTextButton);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userListBox);
            this.Name = "Form1";
            this.Text = "Load and Save a list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button addUserTextButton;
    }
}

