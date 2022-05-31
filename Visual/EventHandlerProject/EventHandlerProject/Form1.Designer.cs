namespace EventHandlerProject
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
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageChangedButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameChangedButton = new System.Windows.Forms.Button();
            this.lastNameChangedButton = new System.Windows.Forms.Button();
            this.ageLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(56, 77);
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ageNumericUpDown.TabIndex = 0;
            // 
            // ageChangedButton
            // 
            this.ageChangedButton.Location = new System.Drawing.Point(183, 73);
            this.ageChangedButton.Name = "ageChangedButton";
            this.ageChangedButton.Size = new System.Drawing.Size(100, 23);
            this.ageChangedButton.TabIndex = 1;
            this.ageChangedButton.Text = "Change Age";
            this.ageChangedButton.UseVisualStyleBackColor = true;
            this.ageChangedButton.Click += new System.EventHandler(this.ageChangedButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(56, 104);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(56, 130);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameChangedButton
            // 
            this.firstNameChangedButton.Location = new System.Drawing.Point(183, 102);
            this.firstNameChangedButton.Name = "firstNameChangedButton";
            this.firstNameChangedButton.Size = new System.Drawing.Size(100, 23);
            this.firstNameChangedButton.TabIndex = 4;
            this.firstNameChangedButton.Text = "Change Name";
            this.firstNameChangedButton.UseVisualStyleBackColor = true;
            this.firstNameChangedButton.Click += new System.EventHandler(this.firstNameChangedButton_Click);
            // 
            // lastNameChangedButton
            // 
            this.lastNameChangedButton.Location = new System.Drawing.Point(183, 128);
            this.lastNameChangedButton.Name = "lastNameChangedButton";
            this.lastNameChangedButton.Size = new System.Drawing.Size(100, 23);
            this.lastNameChangedButton.TabIndex = 5;
            this.lastNameChangedButton.Text = "Change Surname";
            this.lastNameChangedButton.UseVisualStyleBackColor = true;
            this.lastNameChangedButton.Click += new System.EventHandler(this.lastNameChangedButton_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(290, 79);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(53, 13);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Unknown";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(290, 107);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(35, 13);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "Alexei";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(290, 133);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(40, 13);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Ivanov";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lastNameChangedButton);
            this.Controls.Add(this.firstNameChangedButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.ageChangedButton);
            this.Controls.Add(this.ageNumericUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.Button ageChangedButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button firstNameChangedButton;
        private System.Windows.Forms.Button lastNameChangedButton;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
    }
}

