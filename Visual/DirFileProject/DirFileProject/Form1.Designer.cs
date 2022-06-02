namespace DirFileProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fmListView = new System.Windows.Forms.ListView();
            this.iconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.hideFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.parentDirectoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fmListView
            // 
            this.fmListView.HideSelection = false;
            this.fmListView.LargeImageList = this.iconsImageList;
            this.fmListView.Location = new System.Drawing.Point(12, 64);
            this.fmListView.Name = "fmListView";
            this.fmListView.Size = new System.Drawing.Size(657, 260);
            this.fmListView.SmallImageList = this.iconsImageList;
            this.fmListView.TabIndex = 0;
            this.fmListView.UseCompatibleStateImageBehavior = false;
            this.fmListView.View = System.Windows.Forms.View.List;
            this.fmListView.ItemActivate += new System.EventHandler(this.fmListView_ItemActivate);
            // 
            // iconsImageList
            // 
            this.iconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsImageList.ImageStream")));
            this.iconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsImageList.Images.SetKeyName(0, "yast-file.ico");
            this.iconsImageList.Images.SetKeyName(1, "folder-yellow.ico");
            // 
            // hideFilesCheckBox
            // 
            this.hideFilesCheckBox.AutoSize = true;
            this.hideFilesCheckBox.Location = new System.Drawing.Point(565, 41);
            this.hideFilesCheckBox.Name = "hideFilesCheckBox";
            this.hideFilesCheckBox.Size = new System.Drawing.Size(104, 17);
            this.hideFilesCheckBox.TabIndex = 1;
            this.hideFilesCheckBox.Text = "Hide system files";
            this.hideFilesCheckBox.UseVisualStyleBackColor = true;
            this.hideFilesCheckBox.CheckedChanged += new System.EventHandler(this.hideFilesCheckBox_CheckedChanged);
            // 
            // parentDirectoryButton
            // 
            this.parentDirectoryButton.Location = new System.Drawing.Point(12, 37);
            this.parentDirectoryButton.Name = "parentDirectoryButton";
            this.parentDirectoryButton.Size = new System.Drawing.Size(23, 23);
            this.parentDirectoryButton.TabIndex = 2;
            this.parentDirectoryButton.Text = "..";
            this.parentDirectoryButton.UseVisualStyleBackColor = true;
            this.parentDirectoryButton.Click += new System.EventHandler(this.parentDirectoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 336);
            this.Controls.Add(this.parentDirectoryButton);
            this.Controls.Add(this.hideFilesCheckBox);
            this.Controls.Add(this.fmListView);
            this.Name = "Form1";
            this.Text = "Directories/Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView fmListView;
        private System.Windows.Forms.ImageList iconsImageList;
        private System.Windows.Forms.CheckBox hideFilesCheckBox;
        private System.Windows.Forms.Button parentDirectoryButton;
    }
}

