namespace Transaction
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.workingWithDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantityOfRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertRollbackTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workingWithDBToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // workingWithDBToolStripMenuItem
            // 
            this.workingWithDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quantityOfRecordsToolStripMenuItem,
            this.insertRollbackTransactionToolStripMenuItem});
            this.workingWithDBToolStripMenuItem.Name = "workingWithDBToolStripMenuItem";
            this.workingWithDBToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.workingWithDBToolStripMenuItem.Text = "Working with DB";
            // 
            // quantityOfRecordsToolStripMenuItem
            // 
            this.quantityOfRecordsToolStripMenuItem.Name = "quantityOfRecordsToolStripMenuItem";
            this.quantityOfRecordsToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.quantityOfRecordsToolStripMenuItem.Text = "Quantity of records";
            this.quantityOfRecordsToolStripMenuItem.Click += new System.EventHandler(this.quantityOfRecordsToolStripMenuItem_Click);
            // 
            // insertRollbackTransactionToolStripMenuItem
            // 
            this.insertRollbackTransactionToolStripMenuItem.Name = "insertRollbackTransactionToolStripMenuItem";
            this.insertRollbackTransactionToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.insertRollbackTransactionToolStripMenuItem.Text = "Insert&Rollback transaction";
            this.insertRollbackTransactionToolStripMenuItem.Click += new System.EventHandler(this.insertRollbackTransactionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem workingWithDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantityOfRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertRollbackTransactionToolStripMenuItem;
    }
}

