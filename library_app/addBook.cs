using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;





namespace library_app
{
    public partial class addBook : Form
    {



        private string adminId;
        public addBook(string adminId)
        {
            this.adminId = adminId;
            InitializeComponent();
            Button19.Click += Button1_Click;

        }




        public addBook()
        {
            InitializeComponent();
            Button19.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            var datasource = @"LAPTOP-DG70P2RU";//your server
            // var datasource = @"OMAR";//your server
            var database = "LibraryDatabase"; //your database name
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                       + database + ";Persist Security Info=True;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                if (string.IsNullOrEmpty(RichTextBox0.Text) || string.IsNullOrEmpty(RichTextBox3.Text) || string.IsNullOrEmpty(RichTextBox4.Text) || string.IsNullOrEmpty(RichTextBox8.Text) || string.IsNullOrEmpty(RichTextBox10.Text) || string.IsNullOrEmpty(RichTextBox12.Text) || string.IsNullOrEmpty(RichTextBox14.Text) || string.IsNullOrEmpty(RichTextBox16.Text) || string.IsNullOrEmpty(RichTextBox18.Text))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;

                }
                //open connection
                conn.Open();

                MessageBox.Show("Connection Successful...");

                string pub_phone = "INSERT INTO pub_Phone(pub_phone,pub_id) " + "VALUES ( @pub_phone,@pub_id)";
                string auth = "INSERT INTO author(name,author_id)" + " VALUES(@name,@author_id)";
                string pub_insert = "INSERT INTO Publisher(name,pub_phone,pub_id)" + " VALUES(@name,@pub_phone,@pub_id)";
                string book_insert = "INSERT INTO Book(Book_name,year,number_of_copies,author_id,pub_id,A_id,ISBN)" + " VALUES(@Book_name,@year,@number_of_copies,@author_id,@pub_id,@A_id,@ISBN)";
                SqlCommand com1 = new SqlCommand(pub_phone, conn);
                SqlCommand command2 = new SqlCommand(auth, conn);
                SqlCommand com3 = new SqlCommand(pub_insert, conn);
                SqlCommand command4 = new SqlCommand(book_insert, conn);

                com1.Parameters.AddWithValue("@pub_phone", RichTextBox16.Text);
                command2.Parameters.AddWithValue("@name", RichTextBox12.Text);
                com3.Parameters.AddWithValue("@name", RichTextBox10.Text);
                com3.Parameters.AddWithValue("@pub_phone", RichTextBox16.Text);
                command4.Parameters.AddWithValue("@Book_name", RichTextBox0.Text);
                command4.Parameters.AddWithValue("@year", RichTextBox3.Text);
                command4.Parameters.AddWithValue("@number_of_copies", RichTextBox4.Text);
                command2.Parameters.AddWithValue("@author_id", RichTextBox8.Text);
                command4.Parameters.AddWithValue("@author_id", RichTextBox8.Text);
                com3.Parameters.AddWithValue("@pub_id", RichTextBox14.Text);
                command4.Parameters.AddWithValue("@pub_id", RichTextBox14.Text);
                command4.Parameters.AddWithValue("@ISBN", RichTextBox18.Text);
                com1.Parameters.AddWithValue("@pub_id", RichTextBox14.Text);


                command4.Parameters.AddWithValue("@A_id", adminId);




                MessageBox.Show("Executing Query...");

                com1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                com3.ExecuteNonQuery();
                command4.ExecuteNonQuery();

                MessageBox.Show("Inserted Successfully!");
                // this.Hide();



                this.Hide();
                main_admin main = new main_admin(adminId);
                main.Show();




            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                conn.Close();

            }
        }

        // private void label0_Click(object sender, EventArgs e)
        // {

        // }
        // private void label1_Click(object sender, EventArgs e)
        // {

        // }
        // private void TextBox2_Click(object sender, EventArgs e)
        // {

        // }
        // private void label3_Click(object sender, EventArgs e)
        // {

        // }
        // private void TextBox4_Click(object sender, EventArgs e)
        // {

        // }
        // private void label5_Click(object sender, EventArgs e)
        // {

        // }
        // private void TextBox6_Click(object sender, EventArgs e)
        // {

        // }
        // private void label7_Click(object sender, EventArgs e)
        // {

        // }
        // private void TextBox8_Click(object sender, EventArgs e)
        // {

        // }
        // private void label9_Click(object sender, EventArgs e)
        // {

        // }
        // private void TextBox10_Click(object sender, EventArgs e)
        // {

        // }
        // private void label11_Click(object sender, EventArgs e)
        // {

        // }
        // private void TextBox12_Click(object sender, EventArgs e)
        // {

        // }
        // private void label13_Click(object sender, EventArgs e)
        // {

        // }
        // private void TextBox14_Click(object sender, EventArgs e)
        // {

        // }












    }


}
