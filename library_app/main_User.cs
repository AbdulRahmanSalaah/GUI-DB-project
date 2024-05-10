using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

//.



namespace library_app
{
    public partial class main_User : Form
    {


        private string userId;

        public main_User( string userId )
        {
            this.userId = userId;
            InitializeComponent();
            Button1.Click += Button1_Click;
            Button2.Click += Button2_Click;
            //Button3.Click += Button3_Click;
            Button4.Click += Button4_Click;
            


        }

        public main_User ()
        {
            InitializeComponent();
            Button2.Click += Button2_Click;
            //Button3.Click += Button3_Click;
            Button4.Click += Button4_Click;
            Button1.Click += Button1_Click;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            // this.Hide();
            update_user update_user = new update_user(userId);
            update_user.Show();


        }


        private void Button2_Click(object sender, EventArgs e)
        {


            
        }


        // private void Button3_Click(object sender, EventArgs e)
        // {

           

        // }
        private void Button4_Click(object sender, EventArgs e)
        {


            // this.Hide();
            StBrowseBooks stBrowseBooks = new StBrowseBooks(userId);
            stBrowseBooks.Show();


        }

    }

}

        


