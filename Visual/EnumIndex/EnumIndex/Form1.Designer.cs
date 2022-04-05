namespace EnumIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedValueLabel = new System.Windows.Forms.Label();
            this.myColorComboBox = new System.Windows.Forms.ComboBox();
            this.IndexesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "My favourite colours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indexes of colours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chosen value";
            // 
            // selectedValueLabel
            // 
            this.selectedValueLabel.AutoSize = true;
            this.selectedValueLabel.Location = new System.Drawing.Point(184, 90);
            this.selectedValueLabel.Name = "selectedValueLabel";
            this.selectedValueLabel.Size = new System.Drawing.Size(75, 16);
            this.selectedValueLabel.TabIndex = 3;
            this.selectedValueLabel.Text = "Highlighted";
            // 
            // myColorComboBox
            // 
            this.myColorComboBox.FormattingEnabled = true;
            this.myColorComboBox.Location = new System.Drawing.Point(187, 9);
            this.myColorComboBox.Name = "myColorComboBox";
            this.myColorComboBox.Size = new System.Drawing.Size(121, 24);
            this.myColorComboBox.TabIndex = 4;
            this.myColorComboBox.SelectedIndexChanged += new System.EventHandler(this.myColorComboBox_SelectedIndexChanged);
            // 
            // IndexesComboBox
            // 
            this.IndexesComboBox.FormattingEnabled = true;
            this.IndexesComboBox.Location = new System.Drawing.Point(187, 53);
            this.IndexesComboBox.Name = "IndexesComboBox";
            this.IndexesComboBox.Size = new System.Drawing.Size(121, 24);
            this.IndexesComboBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IndexesComboBox);
            this.Controls.Add(this.myColorComboBox);
            this.Controls.Add(this.selectedValueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Working with Enum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedValueLabel;
        private System.Windows.Forms.ComboBox myColorComboBox;
        private System.Windows.Forms.ComboBox IndexesComboBox;
    }
}

