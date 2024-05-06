using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


//.


namespace library_app
{
    public partial class main_admin : Form
    {


        private string adminId;
        private string ISBN;
        //private string pub_id;
        //private string author_id;


        public main_admin(string adminId)
        {
            this.adminId = adminId;
            InitializeComponent();
            Button2.Click += Button2_Click;
            Button3.Click += Button3_Click;
            Button4.Click += Button4_Click;
            Button5.Click += Button5_Click;


        }

        public main_admin()
        {
            InitializeComponent();
            Button2.Click += Button2_Click;
            Button3.Click += Button3_Click;
            Button4.Click += Button4_Click;
            Button5.Click += Button5_Click;
        }


        private void Button2_Click(object sender, EventArgs e)
        {


            this.Hide();
            update_admin update_admin = new update_admin(adminId);
            update_admin.Show();

        }


        private void Button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            addBook addBook = new addBook(adminId);
            addBook.Show();


        }
        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_book update_book = new update_book(adminId);
            update_book.Show();



        }

        private void Button5_Click(object sender, EventArgs e)
        {

            // this.Hide();
            BrowseBooks BrowseBooks = new BrowseBooks();
            BrowseBooks.Show();


        }
















    }


}
