namespace SumOfTwoBigNumber
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
            this.textBoxFirstInteger = new System.Windows.Forms.TextBox();
            this.labelFirstInteger = new System.Windows.Forms.Label();
            this.labelSecondInteger = new System.Windows.Forms.Label();
            this.textBoxSecondInteger = new System.Windows.Forms.TextBox();
            this.buttonSumUp = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFirstInteger
            // 
            this.textBoxFirstInteger.Location = new System.Drawing.Point(130, 37);
            this.textBoxFirstInteger.Name = "textBoxFirstInteger";
            this.textBoxFirstInteger.Size = new System.Drawing.Size(600, 22);
            this.textBoxFirstInteger.TabIndex = 0;
            // 
            // labelFirstInteger
            // 
            this.labelFirstInteger.AutoSize = true;
            this.labelFirstInteger.Location = new System.Drawing.Point(15, 40);
            this.labelFirstInteger.Margin = new System.Windows.Forms.Padding(3);
            this.labelFirstInteger.MinimumSize = new System.Drawing.Size(0, 20);
            this.labelFirstInteger.Name = "labelFirstInteger";
            this.labelFirstInteger.Size = new System.Drawing.Size(76, 20);
            this.labelFirstInteger.TabIndex = 1;
            this.labelFirstInteger.Text = "First Integer";
            // 
            // labelSecondInteger
            // 
            this.labelSecondInteger.AutoSize = true;
            this.labelSecondInteger.Location = new System.Drawing.Point(15, 80);
            this.labelSecondInteger.Margin = new System.Windows.Forms.Padding(3);
            this.labelSecondInteger.MinimumSize = new System.Drawing.Size(0, 20);
            this.labelSecondInteger.Name = "labelSecondInteger";
            this.labelSecondInteger.Size = new System.Drawing.Size(98, 20);
            this.labelSecondInteger.TabIndex = 3;
            this.labelSecondInteger.Text = "Second Integer";
            // 
            // textBoxSecondInteger
            // 
            this.textBoxSecondInteger.Location = new System.Drawing.Point(130, 77);
            this.textBoxSecondInteger.Name = "textBoxSecondInteger";
            this.textBoxSecondInteger.Size = new System.Drawing.Size(600, 22);
            this.textBoxSecondInteger.TabIndex = 2;
            // 
            // buttonSumUp
            // 
            this.buttonSumUp.Location = new System.Drawing.Point(657, 106);
            this.buttonSumUp.MinimumSize = new System.Drawing.Size(0, 30);
            this.buttonSumUp.Name = "buttonSumUp";
            this.buttonSumUp.Size = new System.Drawing.Size(75, 30);
            this.buttonSumUp.TabIndex = 4;
            this.buttonSumUp.Text = "Sum up";
            this.buttonSumUp.UseVisualStyleBackColor = true;
            this.buttonSumUp.Click += new System.EventHandler(this.buttonSumUp_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(18, 142);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(712, 22);
            this.textBoxResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonSumUp);
            this.Controls.Add(this.labelSecondInteger);
            this.Controls.Add(this.textBoxSecondInteger);
            this.Controls.Add(this.labelFirstInteger);
            this.Controls.Add(this.textBoxFirstInteger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstInteger;
        private System.Windows.Forms.Label labelFirstInteger;
        private System.Windows.Forms.Label labelSecondInteger;
        private System.Windows.Forms.TextBox textBoxSecondInteger;
        private System.Windows.Forms.Button buttonSumUp;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

