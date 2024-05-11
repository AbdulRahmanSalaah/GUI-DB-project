using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;





namespace library_app
{
    public partial class main : Form
    {



        public main()
        {
            InitializeComponent();
            Button2.Click += Button2_Click;
            Button3.Click += Button3_Click;
            Button6.Click += Button6_Click;
            Button4.Click += Button4_Click;
            RetrieveBooksButton.Click+= RetrieveBooksButton_Click;




        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            login_User login_User = new login_User();
            this.Hide();
            login_User.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            login_admin login_admin = new login_admin();
            this.Hide();
            login_admin.Show();

        }
        private void RetrieveBooksButton_Click(object sender, EventArgs e){
            report report = new report();
            report.Show();

        }



    }


}