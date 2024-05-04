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
            this.SuspendLayout();
            //
            // Label0
            //
            this.Label0.AutoSize =  true;
            this.Label0.Text =  "Welcome...";
            this.Label0.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label0.Location = new System.Drawing.Point(364,48);
            this.Label0.Size = new System.Drawing.Size(189,37);
            //
            // Label1
            //
            this.Label1.AutoSize =  true;
            this.Label1.Text =  "Choose an option:";
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label1.Location = new System.Drawing.Point(340,188);
            this.Label1.Size = new System.Drawing.Size(217,35);
            this.Label1.TabIndex = 1;
            //
            // Button2
            //
            this.Button2.Text =  "SignUp As User";
            this.Button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Button2.Location = new System.Drawing.Point(256,300);
            this.Button2.Size = new System.Drawing.Size(156,80);
            this.Button2.TabIndex = 2;
            //
            // Button3
            //
            this.Button3.Text =  "SignUp As Admin";
            this.Button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Button3.Location = new System.Drawing.Point(488,304);
            this.Button3.Size = new System.Drawing.Size(152,76);
            this.Button3.TabIndex = 3;
         //
         // form
         //
            this.Size = new System.Drawing.Size(952,696);
            this.Text =  "main";
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
    }
}

