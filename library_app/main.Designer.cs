namespace library_app
{
    partial class main
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
            this.Label0 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
         this.RetrieveBooksButton = new System.Windows.Forms.Button();

            this.SuspendLayout();
            //
            // Label0
            //
            this.Label0.AutoSize =  true;
            this.Label0.Text = "Welcome to Library App";
            this.Label0.BackColor = System.Drawing.Color.LightBlue;
            this.Label0.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.Label0.Location = new System.Drawing.Point(197, 50);
            this.Label0.Size = new System.Drawing.Size(452, 74);

            //
            // Label1
            //
            this.Label1.AutoSize =  true;
            this.Label1.Text =  "Choose an option:";
            this.Label1.BackColor = System.Drawing.Color.LightBlue;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(340,188);
            this.Label1.Size = new System.Drawing.Size(262,41);
            this.Label1.TabIndex = 1;
            //
            // Button2
            //
            this.Button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button2.Text =  "SignUp As User";
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(232,268);
            this.Button2.Size = new System.Drawing.Size(156,80);
            this.Button2.TabIndex = 2;
            //
            // Button3
            //
            this.Button3.BackColor =System.Drawing.Color.DeepSkyBlue;
            this.Button3.Text =  "SignUp As Admin";
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button3.ForeColor = System.Drawing.Color.Black;
            this.Button3.Location = new System.Drawing.Point(564,268);
            this.Button3.Size = new System.Drawing.Size(152,76);
            this.Button3.TabIndex = 3;
            //
            // Button4
            //
            this.Button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button4.Text =  "Login As Admin";
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button4.Location = new System.Drawing.Point(568,404);
            this.Button4.Size = new System.Drawing.Size(148,76);
            this.Button4.TabIndex = 4;
            //
            // Button6
            //
            this.Button6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button6.Text =  "Login As User";
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button6.Location = new System.Drawing.Point(236,404);
            this.Button6.Size = new System.Drawing.Size(152,76);
            this.Button6.TabIndex = 6;


            this.RetrieveBooksButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RetrieveBooksButton.Text = "Retrieve Most Borrowed Books";
            this.RetrieveBooksButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RetrieveBooksButton.ForeColor = System.Drawing.Color.Black;
            this.RetrieveBooksButton.Location = new System.Drawing.Point(295, 550);
            this.RetrieveBooksButton.Size = new System.Drawing.Size(350, 60);
         //
         // form
         //
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Size = new System.Drawing.Size(952,696);
            this.Text =  "main";
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.RetrieveBooksButton);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button6;
         private System.Windows.Forms.Button RetrieveBooksButton;

    }
}
