namespace MyComponentClassLibraryTest
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
            this.bevel1 = new MyComponentClassLibrary.Bevel();
            this.createNewFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // bevel1
            // 
            this.bevel1.Location = new System.Drawing.Point(12, 12);
            this.bevel1.Name = "bevel1";
            this.bevel1.Size = new System.Drawing.Size(90, 69);
            this.bevel1.TabIndex = 0;
            this.bevel1.Load += new System.EventHandler(this.bevel1_Load);
            // 
            // createNewFormButton
            // 
            this.createNewFormButton.Location = new System.Drawing.Point(13, 13);
            this.createNewFormButton.Name = "createNewFormButton";
            this.createNewFormButton.Size = new System.Drawing.Size(224, 23);
            this.createNewFormButton.TabIndex = 0;
            this.createNewFormButton.Text = "Create new form from my library";
            this.createNewFormButton.UseVisualStyleBackColor = true;
            this.createNewFormButton.Click += new System.EventHandler(this.createNewFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createNewFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyComponentClassLibrary.Bevel bevel1;
        private System.Windows.Forms.Button createNewFormButton;
    }
}

