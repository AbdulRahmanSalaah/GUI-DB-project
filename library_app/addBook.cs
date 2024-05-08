using System;
using System.Data.SqlClient;
using System.Windows.Forms;
//.
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
            // var datasource = @"REVISION-PC";//your server
            // var datasource = @"OMAR";//your server
            var datasource = @"LAPTOP-DG70P2RU"; // your server
            var database = "LibraryDatabase"; //your database name
            // var datasource = @"OMAR"; // your server
            // var datasource = @"LAPTOP-DG70P2RU"; // your server
            // var database = "LibraryDatabase"; // your database name
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

                // Open connection
                conn.Open();
                MessageBox.Show("Connection Successful...");

                // Check if the provided publisher phone exists in the pub_Phone table
                // SqlCommand phoneCheckCommand = new SqlCommand("SELECT COUNT(*) FROM pub_Phone WHERE pub_phone = @pub_phone", conn);
                // phoneCheckCommand.Parameters.AddWithValue("@pub_phone", RichTextBox16.Text);
                // int phoneCount = (int)phoneCheckCommand.ExecuteScalar();

                // // Insert into pub_Phone table only if the provided pub_phone doesn't exist
                // if (phoneCount == 0)
                // {
                //     SqlCommand com1 = new SqlCommand("INSERT INTO pub_Phone(pub_phone) VALUES (@pub_phone)", conn);
                //     com1.Parameters.AddWithValue("@pub_phone", RichTextBox16.Text);
                //     com1.ExecuteNonQuery();
                // }

                // Check if the provided publisher ID already exists
                SqlCommand pubCheckCommand = new SqlCommand("SELECT COUNT(*) FROM Publisher WHERE pub_id = @pub_id", conn);
                pubCheckCommand.Parameters.AddWithValue("@pub_id", RichTextBox14.Text);
                int pubCount = (int)pubCheckCommand.ExecuteScalar();

                // Check if the provided author ID already exists
                SqlCommand authCheckCommand = new SqlCommand("SELECT COUNT(*) FROM author WHERE author_id = @author_id", conn);
                authCheckCommand.Parameters.AddWithValue("@author_id", RichTextBox8.Text);
                int authCount = (int)authCheckCommand.ExecuteScalar();

                // Insert into Publisher table only if the provided pub_id doesn't exist
                if (pubCount == 0)
                {
                    SqlCommand com3 = new SqlCommand("INSERT INTO Publisher(name, pub_phone, pub_id) VALUES (@name, @pub_phone, @pub_id)", conn);
                    com3.Parameters.AddWithValue("@name", RichTextBox10.Text);
                    com3.Parameters.AddWithValue("@pub_phone", RichTextBox16.Text);
                    com3.Parameters.AddWithValue("@pub_id", RichTextBox14.Text);
                    com3.ExecuteNonQuery();
                }

                // Insert into Author table only if the provided author_id doesn't exist
                if (authCount == 0)
                {
                    SqlCommand command2 = new SqlCommand("INSERT INTO author(name, author_id) VALUES (@name, @author_id)", conn);
                    command2.Parameters.AddWithValue("@name", RichTextBox12.Text);
                    command2.Parameters.AddWithValue("@author_id", RichTextBox8.Text);
                    command2.ExecuteNonQuery();
                }

                // Insert into Book table
                SqlCommand command4 = new SqlCommand("INSERT INTO Book(Book_name, year, number_of_copies, author_id, pub_id, A_id, ISBN) VALUES (@Book_name, @year, @number_of_copies, @author_id, @pub_id, @A_id, @ISBN)", conn);
                command4.Parameters.AddWithValue("@Book_name", RichTextBox0.Text);
                command4.Parameters.AddWithValue("@year", RichTextBox3.Text);
                command4.Parameters.AddWithValue("@number_of_copies", RichTextBox4.Text);
                command4.Parameters.AddWithValue("@author_id", RichTextBox8.Text);
                command4.Parameters.AddWithValue("@pub_id", RichTextBox14.Text);
                command4.Parameters.AddWithValue("@A_id", adminId);
                command4.Parameters.AddWithValue("@ISBN", RichTextBox18.Text);
                command4.ExecuteNonQuery();

                MessageBox.Show("Inserted Successfully!");
                this.Hide();
                main_admin main = new main_admin(adminId);
                // main.Show();
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
    }
}
