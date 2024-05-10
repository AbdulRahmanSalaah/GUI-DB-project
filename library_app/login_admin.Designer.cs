namespace library_app
{
    partial class login_admin
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
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // Label0
            //
            this.Label0.AutoSize =  true;
            this.Label0.Text =  "Login..";
            this.Label0.BackColor = System.Drawing.Color.LightBlue;
            this.Label0.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label0.Location = new System.Drawing.Point(148,12);
            this.Label0.Size = new System.Drawing.Size(190,65);
            //
            // Label1
            //
            this.Label1.AutoSize =  true;
            this.Label1.Text =  "Mail";
            this.Label1.BackColor = System.Drawing.Color.LightBlue;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            //this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, Italic, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(200,136);
            this.Label1.Size = new System.Drawing.Size(83,45);
            this.Label1.TabIndex = 1;
            //
            // Label2
            //
            this.Label2 = new System.Windows.Forms.Label();
            this.Label2.AutoSize =  true;
            this.Label2.Text =  "Password";
            this.Label2.BackColor = System.Drawing.Color.LightBlue;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            //this.Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, Italic, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(168,232);
            this.Label2.Size = new System.Drawing.Size(155,45);
            this.Label2.TabIndex = 2;
            //
            // TextBox3
            //
            //this.TextBox3.CanUndo =  true;
            this.TextBox3.Modified =  true;
            this.TextBox3.Location = new System.Drawing.Point(96,188);
            this.TextBox3.Size = new System.Drawing.Size(304,31);
            this.TextBox3.TabIndex = 3;
            //
            // TextBox4
            //
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox4.UseSystemPasswordChar = true;
            this.TextBox4.Location = new System.Drawing.Point(96,288);
            this.TextBox4.Size = new System.Drawing.Size(304,31);
            this.TextBox4.TabIndex = 4;
            //
            // Button5
            //
            this.Button5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Button5.Text =  "Login";
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button5.Location = new System.Drawing.Point(192,372);
            this.Button5.Size = new System.Drawing.Size(108,68);
            this.Button5.TabIndex = 5;
         //
         // form
         //
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Size = new System.Drawing.Size(504,548);
            this.Text =  "Form1";
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Button5);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.Button Button5;
    }
}
