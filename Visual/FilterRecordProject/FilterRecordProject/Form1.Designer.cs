namespace FilterRecordProject
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
            this.findPersonTextBox = new System.Windows.Forms.TextBox();
            this.findPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findPersonTextBox
            // 
            this.findPersonTextBox.Location = new System.Drawing.Point(13, 13);
            this.findPersonTextBox.Name = "findPersonTextBox";
            this.findPersonTextBox.Size = new System.Drawing.Size(100, 22);
            this.findPersonTextBox.TabIndex = 0;
            // 
            // findPersonButton
            // 
            this.findPersonButton.Location = new System.Drawing.Point(119, 13);
            this.findPersonButton.Name = "findPersonButton";
            this.findPersonButton.Size = new System.Drawing.Size(110, 23);
            this.findPersonButton.TabIndex = 1;
            this.findPersonButton.Text = "Find a person";
            this.findPersonButton.UseVisualStyleBackColor = true;
            this.findPersonButton.Click += new System.EventHandler(this.findPersonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findPersonButton);
            this.Controls.Add(this.findPersonTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findPersonTextBox;
        private System.Windows.Forms.Button findPersonButton;
    }
}

