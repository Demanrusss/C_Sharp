namespace Procedure
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getFuncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getNameFuncByReqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 410);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readDataToolStripMenuItem,
            this.getFuncToolStripMenuItem,
            this.getNameFuncByReqToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readDataToolStripMenuItem
            // 
            this.readDataToolStripMenuItem.Name = "readDataToolStripMenuItem";
            this.readDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.readDataToolStripMenuItem.Text = "Read Data";
            this.readDataToolStripMenuItem.Click += new System.EventHandler(this.readDataToolStripMenuItem_Click);
            // 
            // getFuncToolStripMenuItem
            // 
            this.getFuncToolStripMenuItem.Name = "getFuncToolStripMenuItem";
            this.getFuncToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.getFuncToolStripMenuItem.Text = "GetNameFunc";
            this.getFuncToolStripMenuItem.Click += new System.EventHandler(this.getFuncToolStripMenuItem_Click);
            // 
            // getNameFuncByReqToolStripMenuItem
            // 
            this.getNameFuncByReqToolStripMenuItem.Name = "getNameFuncByReqToolStripMenuItem";
            this.getNameFuncByReqToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.getNameFuncByReqToolStripMenuItem.Text = "GetNameFunc by Req";
            this.getNameFuncByReqToolStripMenuItem.Click += new System.EventHandler(this.getNameFuncByReqToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getFuncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getNameFuncByReqToolStripMenuItem;
    }
}

