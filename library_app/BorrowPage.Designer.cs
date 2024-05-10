namespace library_app
{
    partial class BorrowPage
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
            this.Button0 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.RichTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.RichTextBox5 = new System.Windows.Forms.RichTextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // Button0
            //
            this.Button0.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button0.Text =  "Confirm Borrowing";
            this.Button0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button0.Location = new System.Drawing.Point(236,280);
            this.Button0.Size = new System.Drawing.Size(188,76);
            //
            // Label2
            //
            this.Label2.AutoSize =  true;
            this.Label2.Text =  "Return Date";
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(72,128);
            this.Label2.Size = new System.Drawing.Size(115,25);
            this.Label2.TabIndex = 2;
            //
            // RichTextBox3
            //
            this.RichTextBox3.SelectionBackColor = System.Drawing.SystemColors.Window;
            // this.RichTextBox3.UndoActionName =  "Typing";
            // this.RichTextBox3.CanUndo =  true;
            this.RichTextBox3.Modified =  true;
            this.RichTextBox3.Location = new System.Drawing.Point(20,160);
            this.RichTextBox3.Size = new System.Drawing.Size(208,32);
            this.RichTextBox3.TabIndex = 3;
            //
            // Label4
            //
            this.Label4.AutoSize =  true;
            this.Label4.Text =  "Issue Date";
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(460,124);
            this.Label4.Size = new System.Drawing.Size(110,28);
            this.Label4.TabIndex = 4;
            //
            // RichTextBox5
            //
            this.RichTextBox5.SelectionBackColor = System.Drawing.SystemColors.Window;
            // this.RichTextBox5.UndoActionName =  "Typing";
            // this.RichTextBox5.CanUndo =  true;
            this.RichTextBox5.Modified =  true;
            this.RichTextBox5.Location = new System.Drawing.Point(416,160);
            this.RichTextBox5.Size = new System.Drawing.Size(212,32);
            this.RichTextBox5.TabIndex = 5;
            //
            // Label6
            //
            this.Label6.AutoSize =  true;
            this.Label6.Text =  "-----------";
            this.Label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label6.Location = new System.Drawing.Point(264,44);
            this.Label6.Size = new System.Drawing.Size(113,32);
            this.Label6.TabIndex = 6;
         //
         // form
         //
            this.Size = new System.Drawing.Size(716,456);
            this.Text =  "Form1";
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.RichTextBox3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.RichTextBox5);
            this.Controls.Add(this.Label6);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.RichTextBox RichTextBox3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.RichTextBox RichTextBox5;
        private System.Windows.Forms.Label Label6;
    }
}