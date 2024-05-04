namespace library_app
{
    partial class main_admin
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
            this.Button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // Label0
            //
            this.Label0.AutoSize =  true;
            this.Label0.Text =  "Welcome Admin..";
            this.Label0.Font = new System.Drawing.Font("Showcard Gothic", 19.800001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label0.Location = new System.Drawing.Point(268,24);
            this.Label0.Size = new System.Drawing.Size(320,43);
            //
            // Label1
            //
            this.Label1.AutoSize =  true;
            this.Label1.Text =  "Choose an option:";
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(288,220);
            this.Label1.Size = new System.Drawing.Size(262,41);
            this.Label1.TabIndex = 1;
            //
            // Button2
            //
            this.Button2.Text =  "Update My Details ";
            this.Button2.Location = new System.Drawing.Point(48,360);
            this.Button2.Size = new System.Drawing.Size(148,64);
            this.Button2.TabIndex = 2;
            //
            // Button3
            //
            this.Button3.Text =  "Add Book";
            this.Button3.Location = new System.Drawing.Point(244,360);
            this.Button3.Size = new System.Drawing.Size(144,64);
            this.Button3.TabIndex = 3;
            //
            // Button4
            //
            this.Button4.Text =  "Update book details";
            this.Button4.Location = new System.Drawing.Point(448,360);
            this.Button4.Size = new System.Drawing.Size(136,68);
            this.Button4.TabIndex = 4;
            //
            // Button5
            //
            this.Button5.Text =  "Browse books";
            this.Button5.Location = new System.Drawing.Point(656,360);
            this.Button5.Size = new System.Drawing.Size(116,64);
            this.Button5.TabIndex = 5;
         //
         // form
         //
            this.Size = new System.Drawing.Size(888,680);
            this.Text =  "Form1";
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
    }
}

