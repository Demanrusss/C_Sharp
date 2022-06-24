namespace DataRelationProject
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
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.addressDataGridView = new System.Windows.Forms.DataGridView();
            this.findAddressButton = new System.Windows.Forms.Button();
            this.findPersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Location = new System.Drawing.Point(13, 13);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.RowHeadersWidth = 51;
            this.peopleDataGridView.RowTemplate.Height = 24;
            this.peopleDataGridView.Size = new System.Drawing.Size(365, 272);
            this.peopleDataGridView.TabIndex = 0;
            // 
            // addressDataGridView
            // 
            this.addressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressDataGridView.Location = new System.Drawing.Point(384, 12);
            this.addressDataGridView.Name = "addressDataGridView";
            this.addressDataGridView.RowHeadersWidth = 51;
            this.addressDataGridView.RowTemplate.Height = 24;
            this.addressDataGridView.Size = new System.Drawing.Size(404, 273);
            this.addressDataGridView.TabIndex = 1;
            // 
            // findAddressButton
            // 
            this.findAddressButton.Location = new System.Drawing.Point(13, 415);
            this.findAddressButton.Name = "findAddressButton";
            this.findAddressButton.Size = new System.Drawing.Size(121, 23);
            this.findAddressButton.TabIndex = 2;
            this.findAddressButton.Text = "Find an address";
            this.findAddressButton.UseVisualStyleBackColor = true;
            this.findAddressButton.Click += new System.EventHandler(this.findAddressButton_Click);
            // 
            // findPersonButton
            // 
            this.findPersonButton.Location = new System.Drawing.Point(140, 415);
            this.findPersonButton.Name = "findPersonButton";
            this.findPersonButton.Size = new System.Drawing.Size(121, 23);
            this.findPersonButton.TabIndex = 3;
            this.findPersonButton.Text = "Find a person";
            this.findPersonButton.UseVisualStyleBackColor = true;
            this.findPersonButton.Click += new System.EventHandler(this.findPersonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findPersonButton);
            this.Controls.Add(this.findAddressButton);
            this.Controls.Add(this.addressDataGridView);
            this.Controls.Add(this.peopleDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.DataGridView addressDataGridView;
        private System.Windows.Forms.Button findAddressButton;
        private System.Windows.Forms.Button findPersonButton;
    }
}

