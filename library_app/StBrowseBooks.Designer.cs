namespace library_app
{
    partial class StBrowseBooks
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxAuthor;
        private System.Windows.Forms.CheckBox checkBoxPublisher;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox criteriaGroupBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxAuthor = new System.Windows.Forms.CheckBox();
            this.checkBoxPublisher = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.criteriaGroupBox = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.criteriaGroupBox.SuspendLayout();
            this.SuspendLayout();

            // checkBoxName
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxName.Location = new System.Drawing.Point(20, 30);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(110, 27);
            this.checkBoxName.Text = "Book Name";
            this.checkBoxName.UseVisualStyleBackColor = true;

            // checkBoxAuthor
            this.checkBoxAuthor.AutoSize = true;
            this.checkBoxAuthor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxAuthor.Location = new System.Drawing.Point(20, 70);
            this.checkBoxAuthor.Name = "checkBoxAuthor";
            this.checkBoxAuthor.Size = new System.Drawing.Size(85, 27);
            this.checkBoxAuthor.Text = "Author";
            this.checkBoxAuthor.UseVisualStyleBackColor = true;

            // checkBoxPublisher
            this.checkBoxPublisher.AutoSize = true;
            this.checkBoxPublisher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxPublisher.Location = new System.Drawing.Point(20, 110);
            this.checkBoxPublisher.Name = "checkBoxPublisher";
            this.checkBoxPublisher.Size = new System.Drawing.Size(95, 27);
            this.checkBoxPublisher.Text = "Publisher";
            this.checkBoxPublisher.UseVisualStyleBackColor = true;

            // checkBoxYear
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxYear.Location = new System.Drawing.Point(20, 150);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(61, 27);
            this.checkBoxYear.Text = "Year";
            this.checkBoxYear.UseVisualStyleBackColor = true;

            // filterButton
            this.filterButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.filterButton.Location = new System.Drawing.Point(20, 190);
            this.filterButton.Size = new System.Drawing.Size(150, 40);
            this.filterButton.Text = "Apply Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);

            // borrowButton
            this.borrowButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.borrowButton.Location = new System.Drawing.Point(20, 240);
            this.borrowButton.Size = new System.Drawing.Size(150, 40);
            this.borrowButton.Text = "Borrow Book";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);

            // dataGridView1
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.Location = new System.Drawing.Point(250, 20);
            this.dataGridView1.Size = new System.Drawing.Size(800, 600);
            this.dataGridView1.ReadOnly = true;

            // criteriaGroupBox
            this.criteriaGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.criteriaGroupBox.Location = new System.Drawing.Point(20, 20);
            this.criteriaGroupBox.Name = "criteriaGroupBox";
            this.criteriaGroupBox.Size = new System.Drawing.Size(200, 350);
            this.criteriaGroupBox.Text = "Select Criteria";
            this.criteriaGroupBox.Controls.Add(this.checkBoxName);
            this.criteriaGroupBox.Controls.Add(this.checkBoxAuthor);
            this.criteriaGroupBox.Controls.Add(this.checkBoxPublisher);
            this.criteriaGroupBox.Controls.Add(this.checkBoxYear);
            this.criteriaGroupBox.Controls.Add(this.filterButton);
            this.criteriaGroupBox.Controls.Add(this.borrowButton);

            // StBrowseBooks
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.criteriaGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StBrowseBooks";
            this.Text = "Browse Books";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.criteriaGroupBox.ResumeLayout(false);
            this.criteriaGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
