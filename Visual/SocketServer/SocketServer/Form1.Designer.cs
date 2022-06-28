namespace SocketServer
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
            this.launchServerButton = new System.Windows.Forms.Button();
            this.serverAddressLabel = new System.Windows.Forms.Label();
            this.serverAddressTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.connectToServerButton = new System.Windows.Forms.Button();
            this.commandSendButton = new System.Windows.Forms.Button();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.commandLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // launchServerButton
            // 
            this.launchServerButton.Location = new System.Drawing.Point(656, 12);
            this.launchServerButton.Name = "launchServerButton";
            this.launchServerButton.Size = new System.Drawing.Size(132, 23);
            this.launchServerButton.TabIndex = 0;
            this.launchServerButton.Text = "Launch server";
            this.launchServerButton.UseVisualStyleBackColor = true;
            this.launchServerButton.Click += new System.EventHandler(this.launchServerButton_Click);
            // 
            // serverAddressLabel
            // 
            this.serverAddressLabel.AutoSize = true;
            this.serverAddressLabel.Location = new System.Drawing.Point(12, 44);
            this.serverAddressLabel.Name = "serverAddressLabel";
            this.serverAddressLabel.Size = new System.Drawing.Size(100, 16);
            this.serverAddressLabel.TabIndex = 1;
            this.serverAddressLabel.Text = "Server address";
            // 
            // serverAddressTextBox
            // 
            this.serverAddressTextBox.Location = new System.Drawing.Point(118, 41);
            this.serverAddressTextBox.Name = "serverAddressTextBox";
            this.serverAddressTextBox.Size = new System.Drawing.Size(532, 22);
            this.serverAddressTextBox.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 341);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // connectToServerButton
            // 
            this.connectToServerButton.Location = new System.Drawing.Point(656, 41);
            this.connectToServerButton.Name = "connectToServerButton";
            this.connectToServerButton.Size = new System.Drawing.Size(132, 23);
            this.connectToServerButton.TabIndex = 4;
            this.connectToServerButton.Text = "Connect to server";
            this.connectToServerButton.UseVisualStyleBackColor = true;
            this.connectToServerButton.Click += new System.EventHandler(this.connectToServerButton_Click);
            // 
            // commandSendButton
            // 
            this.commandSendButton.Location = new System.Drawing.Point(720, 69);
            this.commandSendButton.Name = "commandSendButton";
            this.commandSendButton.Size = new System.Drawing.Size(68, 23);
            this.commandSendButton.TabIndex = 7;
            this.commandSendButton.Text = "Send";
            this.commandSendButton.UseVisualStyleBackColor = true;
            this.commandSendButton.Click += new System.EventHandler(this.commandSendButton_Click);
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(87, 69);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(627, 22);
            this.commandTextBox.TabIndex = 6;
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(12, 72);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(69, 16);
            this.commandLabel.TabIndex = 5;
            this.commandLabel.Text = "Command";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.commandSendButton);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.connectToServerButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.serverAddressTextBox);
            this.Controls.Add(this.serverAddressLabel);
            this.Controls.Add(this.launchServerButton);
            this.Name = "Form1";
            this.Text = "Client - Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchServerButton;
        private System.Windows.Forms.Label serverAddressLabel;
        private System.Windows.Forms.TextBox serverAddressTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button connectToServerButton;
        private System.Windows.Forms.Button commandSendButton;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Label commandLabel;
    }
}

