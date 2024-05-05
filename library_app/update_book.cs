using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;





namespace library_app
{
    public partial class update_book : Form
    {



        private string ISBN;
        //private string pub_id;
        //private string author_id;
        private string  adminId;

        public update_book(string ISBN , string  adminId)
        {
            InitializeComponent();
            this.ISBN = ISBN; // Store the ID passed from the insert page
            //this.pub_id = pub_id;
            //this.author_id = author_id;
            this.adminId =  adminId;
            // PopulateFormData(); // Populate the form with the existing data
            Button17.Click += Button17_Click;
        }
        // public update_admin()
        // {
        //     InitializeComponent();
        //     Button0.Click += Button0_Click;


        // }

        private void Button17_Click(object? sender, EventArgs e)
        {
            var datasource = @"REVISION-PC";
            //var datasource = @"LAPTOP-DG70P2RU";//your server
            var database = "LibraryDatabase"; //your database name
            // var username = "sa"; //username of server to connect
            // var password = "password"; //password
            // string connString = "Server=localhost;Database=YourDatabaseName;Integrated Security=True;";


            // your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                       + database + ";Persist Security Info=True;Integrated Security=True;";

            // string connString = "Server= localhost; Database= LibraryDatabase; Integrated Security=True;";
            // string connString = "Server= LAPTOP-DG70P2RU; Database= LibraryDatabase; Integrated Security=True;";
            // string connString = "Data Source=LAPTOP-DG70P2RU;Initial Catalog=LibraryDatabase;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);


            try
            {

                
                conn.Open();

                MessageBox.Show("Connection Successful...");

                // string sqlQueryUpdatePubphone = "UPDATE pub_Phone SET pub_phone = @pub_phone WHERE pub_id = @pub_id ";
                // SqlCommand command0 = new SqlCommand(sqlQueryUpdatePubphone, conn);
                // command0.Parameters.AddWithValue("@pub_phone", TextBox16.Text);
                // command0.Parameters.AddWithValue("@pub_id", pub_id);

                // string sqlQueryUpdatePub = "UPDATE Publisher SET pub_phone = @pub_phone WHERE pub_id = @pub_id ";
                // SqlCommand command3 = new SqlCommand(sqlQueryUpdatePub, conn);
                // command3.Parameters.AddWithValue("@pub_phone", TextBox16.Text);
                // command3.Parameters.AddWithValue("@pub_id", pub_id);

                // string sqlQueryUpdateAdmin = "UPDATE Publisher SET pub_phone = @pub_phone WHERE pub_id = @pub_id ";
                // SqlCommand command4 = new SqlCommand(sqlQueryUpdateAdmin, conn);
                // command4.Parameters.AddWithValue("@pub_phone", TextBox16.Text);
                // command4.Parameters.AddWithValue("@pub_id", pub_id);


                // string sqlQueryUpdateAuthor = "UPDATE author SET name = @name WHERE author_id = @author_id ";
                // SqlCommand command2 = new SqlCommand(sqlQueryUpdateAuthor, conn);
                // command2.Parameters.AddWithValue("@name", TextBox10.Text);
                // command2.Parameters.AddWithValue("@author_id", author_id);


                string sqlQueryUpdate = "UPDATE BOOK SET Book_name = @Book_name , year = @year ,number_of_copies = @number_of_copies  WHERE ISBN = @ISBN ";
                SqlCommand command1 = new SqlCommand(sqlQueryUpdate, conn);
                command1.Parameters.AddWithValue("@Book_name", TextBox18.Text);
                command1.Parameters.AddWithValue("@year", TextBox2.Text);
                command1.Parameters.AddWithValue("@number_of_copies", TextBox6.Text);
                command1.Parameters.AddWithValue("@ISBN", ISBN);




                
                // command0.ExecuteNonQuery();
                // command2.ExecuteNonQuery();
                // command3.ExecuteNonQuery();
                command1.ExecuteNonQuery();
               
                

                MessageBox.Show("Executing Query...");

                MessageBox.Show("Updated Successfully!");


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

    }


}
