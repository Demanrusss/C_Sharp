namespace MusDecoder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAfterDecodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beforeDecodingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.afterDecodingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.afterDecodingLabel = new System.Windows.Forms.Label();
            this.beforeDecodingLabel = new System.Windows.Forms.Label();
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
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.decodeToolStripMenuItem,
            this.openAfterDecodingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // decodeToolStripMenuItem
            // 
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            this.decodeToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.decodeToolStripMenuItem.Text = "Decode";
            this.decodeToolStripMenuItem.Click += new System.EventHandler(this.decodeToolStripMenuItem_Click);
            // 
            // openAfterDecodingToolStripMenuItem
            // 
            this.openAfterDecodingToolStripMenuItem.Name = "openAfterDecodingToolStripMenuItem";
            this.openAfterDecodingToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.openAfterDecodingToolStripMenuItem.Text = "Open after Decoding";
            this.openAfterDecodingToolStripMenuItem.Click += new System.EventHandler(this.openAfterDecodingToolStripMenuItem_Click);
            // 
            // beforeDecodingRichTextBox
            // 
            this.beforeDecodingRichTextBox.Location = new System.Drawing.Point(12, 57);
            this.beforeDecodingRichTextBox.Name = "beforeDecodingRichTextBox";
            this.beforeDecodingRichTextBox.Size = new System.Drawing.Size(373, 381);
            this.beforeDecodingRichTextBox.TabIndex = 1;
            this.beforeDecodingRichTextBox.Text = "";
            // 
            // afterDecodingRichTextBox
            // 
            this.afterDecodingRichTextBox.Location = new System.Drawing.Point(391, 57);
            this.afterDecodingRichTextBox.Name = "afterDecodingRichTextBox";
            this.afterDecodingRichTextBox.Size = new System.Drawing.Size(397, 381);
            this.afterDecodingRichTextBox.TabIndex = 2;
            this.afterDecodingRichTextBox.Text = "";
            // 
            // afterDecodingLabel
            // 
            this.afterDecodingLabel.AutoSize = true;
            this.afterDecodingLabel.Location = new System.Drawing.Point(680, 34);
            this.afterDecodingLabel.Name = "afterDecodingLabel";
            this.afterDecodingLabel.Size = new System.Drawing.Size(111, 20);
            this.afterDecodingLabel.TabIndex = 3;
            this.afterDecodingLabel.Text = "After Decoding";
            // 
            // beforeDecodingLabel
            // 
            this.beforeDecodingLabel.AutoSize = true;
            this.beforeDecodingLabel.Location = new System.Drawing.Point(266, 34);
            this.beforeDecodingLabel.Name = "beforeDecodingLabel";
            this.beforeDecodingLabel.Size = new System.Drawing.Size(122, 20);
            this.beforeDecodingLabel.TabIndex = 4;
            this.beforeDecodingLabel.Text = "Before Decoding";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beforeDecodingLabel);
            this.Controls.Add(this.afterDecodingLabel);
            this.Controls.Add(this.afterDecodingRichTextBox);
            this.Controls.Add(this.beforeDecodingRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mus&Ogg Decoder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openAfterDecodingToolStripMenuItem;
        private RichTextBox beforeDecodingRichTextBox;
        private ToolStripMenuItem decodeToolStripMenuItem;
        private RichTextBox afterDecodingRichTextBox;
        private Label afterDecodingLabel;
        private Label beforeDecodingLabel;
    }
}