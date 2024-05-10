namespace library_app
{
    partial class login_User
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
            this.TB_mail = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // Label0
            //
            this.Label0.AutoSize = true;
            this.Label0.Text = "Log in";
            this.Label0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Label0.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label0.Location = new System.Drawing.Point(164, 8);
            this.Label0.Size = new System.Drawing.Size(135, 49);
            //
            // Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Text = "User Mail";
            this.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Label1.Location = new System.Drawing.Point(20, 88);
            this.Label1.Size = new System.Drawing.Size(99, 25);
            this.Label1.TabIndex = 1;
            //
            // Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Text = "Password";
            this.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Label2.Location = new System.Drawing.Point(20, 180);
            this.Label2.Size = new System.Drawing.Size(87, 25);
            this.Label2.TabIndex = 2;
            //
            // TB_mail
            //
            this.TB_mail.Location = new System.Drawing.Point(24, 116);
            this.TB_mail.Size = new System.Drawing.Size(400, 31);
            this.TB_mail.TabIndex = 3;
            //
            // TB_pass
            //
            this.TB_pass.Location = new System.Drawing.Point(24, 212);
            this.TB_pass.Size = new System.Drawing.Size(400, 31);
            this.TB_pass.TabIndex = 4;
            //
            // Login_Button
            //
            this.Login_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_Button.Text = "Log in ->";
            this.Login_Button.Location = new System.Drawing.Point(28, 304);
            this.Login_Button.Size = new System.Drawing.Size(400, 40);
            this.Login_Button.TabIndex = 5;
            //
            // form
            //
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Size = new System.Drawing.Size(480, 436);
            this.Text = "Form1";
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TB_mail);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.Login_Button);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TB_mail;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.Button Login_Button;
    }
}

