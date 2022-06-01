namespace AnimationWindow
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
            this.changePositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changePositionButton
            // 
            this.changePositionButton.Location = new System.Drawing.Point(62, 57);
            this.changePositionButton.Name = "changePositionButton";
            this.changePositionButton.Size = new System.Drawing.Size(95, 23);
            this.changePositionButton.TabIndex = 0;
            this.changePositionButton.Text = "Change it";
            this.changePositionButton.UseVisualStyleBackColor = true;
            this.changePositionButton.Click += new System.EventHandler(this.changePositionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changePositionButton);
            this.Name = "Form1";
            this.Text = "Click to change it";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePositionButton;
    }
}

