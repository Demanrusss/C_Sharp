namespace MouseJiggler
{
    partial class MainForm
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
            this.runJigglingCheckBox = new System.Windows.Forms.CheckBox();
            this.minJigPeriodLabel = new System.Windows.Forms.Label();
            this.maxJigPeriodLabel = new System.Windows.Forms.Label();
            this.jigPeriodTrackBar = new System.Windows.Forms.TrackBar();
            this.chosenJigPeriodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jigPeriodTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // runJigglingCheckBox
            // 
            this.runJigglingCheckBox.AutoSize = true;
            this.runJigglingCheckBox.Location = new System.Drawing.Point(13, 13);
            this.runJigglingCheckBox.Name = "runJigglingCheckBox";
            this.runJigglingCheckBox.Size = new System.Drawing.Size(106, 20);
            this.runJigglingCheckBox.TabIndex = 0;
            this.runJigglingCheckBox.Text = "Start Jiggling";
            this.runJigglingCheckBox.UseVisualStyleBackColor = true;
            this.runJigglingCheckBox.CheckedChanged += new System.EventHandler(this.runJigglingCheckBox_CheckedChanged);
            // 
            // minJigPeriodLabel
            // 
            this.minJigPeriodLabel.AutoSize = true;
            this.minJigPeriodLabel.Location = new System.Drawing.Point(13, 40);
            this.minJigPeriodLabel.Name = "minJigPeriodLabel";
            this.minJigPeriodLabel.Size = new System.Drawing.Size(14, 16);
            this.minJigPeriodLabel.TabIndex = 1;
            this.minJigPeriodLabel.Text = "1";
            // 
            // maxJigPeriodLabel
            // 
            this.maxJigPeriodLabel.AutoSize = true;
            this.maxJigPeriodLabel.Location = new System.Drawing.Point(349, 41);
            this.maxJigPeriodLabel.Name = "maxJigPeriodLabel";
            this.maxJigPeriodLabel.Size = new System.Drawing.Size(21, 16);
            this.maxJigPeriodLabel.TabIndex = 2;
            this.maxJigPeriodLabel.Text = "60";
            // 
            // jigPeriodTrackBar
            // 
            this.jigPeriodTrackBar.Location = new System.Drawing.Point(13, 60);
            this.jigPeriodTrackBar.Maximum = 60;
            this.jigPeriodTrackBar.Minimum = 1;
            this.jigPeriodTrackBar.Name = "jigPeriodTrackBar";
            this.jigPeriodTrackBar.Size = new System.Drawing.Size(360, 56);
            this.jigPeriodTrackBar.TabIndex = 3;
            this.jigPeriodTrackBar.Value = 1;
            this.jigPeriodTrackBar.Scroll += new System.EventHandler(this.jigPeriodTrackBar_Scroll);
            // 
            // chosenJigPeriodLabel
            // 
            this.chosenJigPeriodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chosenJigPeriodLabel.AutoSize = true;
            this.chosenJigPeriodLabel.Location = new System.Drawing.Point(356, 13);
            this.chosenJigPeriodLabel.Name = "chosenJigPeriodLabel";
            this.chosenJigPeriodLabel.Size = new System.Drawing.Size(14, 16);
            this.chosenJigPeriodLabel.TabIndex = 4;
            this.chosenJigPeriodLabel.Text = "1";
            this.chosenJigPeriodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 123);
            this.Controls.Add(this.chosenJigPeriodLabel);
            this.Controls.Add(this.jigPeriodTrackBar);
            this.Controls.Add(this.maxJigPeriodLabel);
            this.Controls.Add(this.minJigPeriodLabel);
            this.Controls.Add(this.runJigglingCheckBox);
            this.Name = "MainForm";
            this.Text = "Mouse Jiggler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jigPeriodTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox runJigglingCheckBox;
        private System.Windows.Forms.Label minJigPeriodLabel;
        private System.Windows.Forms.Label maxJigPeriodLabel;
        private System.Windows.Forms.TrackBar jigPeriodTrackBar;
        private System.Windows.Forms.Label chosenJigPeriodLabel;
    }
}

