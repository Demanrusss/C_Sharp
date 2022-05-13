namespace InterfaceProject2
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
            this.PersonLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.DecButton = new System.Windows.Forms.Button();
            this.AddButtonX2 = new System.Windows.Forms.Button();
            this.DecButtonX2 = new System.Windows.Forms.Button();
            this.AddButtonX3 = new System.Windows.Forms.Button();
            this.DecButtonX3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonLabel
            // 
            this.PersonLabel.AutoSize = true;
            this.PersonLabel.Location = new System.Drawing.Point(12, 10);
            this.PersonLabel.Name = "PersonLabel";
            this.PersonLabel.Size = new System.Drawing.Size(35, 13);
            this.PersonLabel.TabIndex = 0;
            this.PersonLabel.Text = "label1";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(12, 35);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(35, 13);
            this.sumLabel.TabIndex = 1;
            this.sumLabel.Text = "label1";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(150, 10);
            this.numericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(150, 35);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 20);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DecButton
            // 
            this.DecButton.Location = new System.Drawing.Point(220, 35);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(50, 20);
            this.DecButton.TabIndex = 4;
            this.DecButton.Text = "Dec";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // AddButtonX2
            // 
            this.AddButtonX2.Location = new System.Drawing.Point(150, 60);
            this.AddButtonX2.Name = "AddButtonX2";
            this.AddButtonX2.Size = new System.Drawing.Size(50, 20);
            this.AddButtonX2.TabIndex = 5;
            this.AddButtonX2.Text = "AddX2";
            this.AddButtonX2.UseVisualStyleBackColor = true;
            this.AddButtonX2.Click += new System.EventHandler(this.AddButtonX2_Click);
            // 
            // DecButtonX2
            // 
            this.DecButtonX2.Location = new System.Drawing.Point(220, 60);
            this.DecButtonX2.Name = "DecButtonX2";
            this.DecButtonX2.Size = new System.Drawing.Size(50, 20);
            this.DecButtonX2.TabIndex = 6;
            this.DecButtonX2.Text = "DecX2";
            this.DecButtonX2.UseVisualStyleBackColor = true;
            this.DecButtonX2.Click += new System.EventHandler(this.DecButtonX2_Click);
            // 
            // AddButtonX3
            // 
            this.AddButtonX3.Location = new System.Drawing.Point(150, 85);
            this.AddButtonX3.Name = "AddButtonX3";
            this.AddButtonX3.Size = new System.Drawing.Size(50, 20);
            this.AddButtonX3.TabIndex = 7;
            this.AddButtonX3.Text = "AddX3";
            this.AddButtonX3.UseVisualStyleBackColor = true;
            this.AddButtonX3.Click += new System.EventHandler(this.AddButtonX3_Click);
            // 
            // DecButtonX3
            // 
            this.DecButtonX3.Location = new System.Drawing.Point(220, 85);
            this.DecButtonX3.Name = "DecButtonX3";
            this.DecButtonX3.Size = new System.Drawing.Size(50, 20);
            this.DecButtonX3.TabIndex = 8;
            this.DecButtonX3.Text = "DecX3";
            this.DecButtonX3.UseVisualStyleBackColor = true;
            this.DecButtonX3.Click += new System.EventHandler(this.DecButtonX3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DecButtonX3);
            this.Controls.Add(this.AddButtonX3);
            this.Controls.Add(this.DecButtonX2);
            this.Controls.Add(this.AddButtonX2);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.PersonLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DecButton;
        private System.Windows.Forms.Button AddButtonX2;
        private System.Windows.Forms.Button DecButtonX2;
        private System.Windows.Forms.Button AddButtonX3;
        private System.Windows.Forms.Button DecButtonX3;
    }
}

