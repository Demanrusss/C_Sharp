namespace InterfaceProject
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
            this.addButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.sumLabel = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(235, 293);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Put in";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // decButton
            // 
            this.decButton.Location = new System.Drawing.Point(548, 293);
            this.decButton.Margin = new System.Windows.Forms.Padding(4);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(100, 28);
            this.decButton.TabIndex = 1;
            this.decButton.Text = "Take out";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(753, 262);
            this.sumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(57, 16);
            this.sumLabel.TabIndex = 2;
            this.sumLabel.Text = "Balance";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(235, 218);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown.TabIndex = 3;
            this.numericUpDown.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(25, 25);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(63, 16);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Check up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label outputLabel;
    }
}

