using System.Windows.Forms;
//.
namespace library_app
{
    partial class BrowseBooks : Form
    {
        private DataGridView dataGridView1;
        private Button deleteButton;

        private void InitializeComponent()
        {
            this.dataGridView1 = new DataGridView();
            this.deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 368);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 40);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Book";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new EventHandler(this.deleteButton_Click);
            // 
            // BrowseBooks
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BrowseBooks";
            this.Text = "Browse Books";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
