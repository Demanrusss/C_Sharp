namespace DataTableProject
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addRowButton = new System.Windows.Forms.Button();
            this.loadDataRowButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.editTransactionButton = new System.Windows.Forms.Button();
            this.findAndEditButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(13, 12);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(81, 23);
            this.addRowButton.TabIndex = 1;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // loadDataRowButton
            // 
            this.loadDataRowButton.Location = new System.Drawing.Point(100, 12);
            this.loadDataRowButton.Name = "loadDataRowButton";
            this.loadDataRowButton.Size = new System.Drawing.Size(205, 23);
            this.loadDataRowButton.TabIndex = 2;
            this.loadDataRowButton.Text = "Add Row using LoadDataRow";
            this.loadDataRowButton.UseVisualStyleBackColor = true;
            this.loadDataRowButton.Click += new System.EventHandler(this.loadDataRowButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(311, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(81, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit Row";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editTransactionButton
            // 
            this.editTransactionButton.Location = new System.Drawing.Point(398, 12);
            this.editTransactionButton.Name = "editTransactionButton";
            this.editTransactionButton.Size = new System.Drawing.Size(114, 23);
            this.editTransactionButton.TabIndex = 4;
            this.editTransactionButton.Text = "Edit transaction";
            this.editTransactionButton.UseVisualStyleBackColor = true;
            this.editTransactionButton.Click += new System.EventHandler(this.editTransactionButton_Click);
            // 
            // findAndEditButton
            // 
            this.findAndEditButton.Location = new System.Drawing.Point(518, 12);
            this.findAndEditButton.Name = "findAndEditButton";
            this.findAndEditButton.Size = new System.Drawing.Size(114, 23);
            this.findAndEditButton.TabIndex = 5;
            this.findAndEditButton.Text = "Find 20 and Edit";
            this.findAndEditButton.UseVisualStyleBackColor = true;
            this.findAndEditButton.Click += new System.EventHandler(this.findAndEditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(638, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete row #1";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.findAndEditButton);
            this.Controls.Add(this.editTransactionButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.loadDataRowButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button loadDataRowButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button editTransactionButton;
        private System.Windows.Forms.Button findAndEditButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

