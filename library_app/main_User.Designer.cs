namespace library_app
{
    partial class main_User
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // Label0
            //
            this.Label0.AutoSize =  true;
            this.Label0.Text =  "Welcome USER..";
            this.Label0.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label0.Location = new System.Drawing.Point(228,24);
            this.Label0.Size = new System.Drawing.Size(317,50);
            //
            // Button1
            //
            this.Button1.BackColor = System.Drawing.Color.PowderBlue;
            this.Button1.Text =  "Update Your Details";
            this.Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(178,264);
            this.Button1.Size = new System.Drawing.Size(144,76);
            this.Button1.TabIndex = 1;
            //
            // Button4
            //
            this.Button4.BackColor = System.Drawing.Color.PowderBlue;
            this.Button4.Text =  "Browse";
            this.Button4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button4.Location = new System.Drawing.Point(458,264);
            this.Button4.Size = new System.Drawing.Size(128,80);
            this.Button4.TabIndex = 4;
            //
            // Label5
            //
            this.Label5.AutoSize =  true;
            this.Label5.Text =  "Choose Option..";
            this.Label5.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(280,156);
            this.Label5.Size = new System.Drawing.Size(230,37);
            this.Label5.TabIndex = 5;
         //
         // form
         //
            this.Size = new System.Drawing.Size(824,584);
            this.Text =  "Form1";
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Label5);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Label Label5;
    }
}

