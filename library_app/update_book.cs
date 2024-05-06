using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;





namespace library_app
{
    public partial class update_book : Form
    {



        private string ISBN;
        private string  adminId;

        public update_book(string  adminId)
        {
            InitializeComponent();
            this.adminId =  adminId; 
            Button17.Click += Button17_Click;
        }
        
        private void Button17_Click(object? sender, EventArgs e)
        {
            var datasource = @"REVISION-PC";
            //var datasource = @"LAPTOP-DG70P2RU";//your server
            var database = "LibraryDatabase"; //your database name
            
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                       + database + ";Persist Security Info=True;Integrated Security=True;";

            
            SqlConnection conn = new SqlConnection(connString);


            try
            {

                
                conn.Open();

                MessageBox.Show("Connection Successful...");

                string ISBN = TextBox15.Text;

                string sqlQueryAuthorId = "SELECT author_id FROM BOOK WHERE ISBN = @ISBN";
                SqlCommand commandAuthorId = new SqlCommand(sqlQueryAuthorId, conn);
                commandAuthorId.Parameters.AddWithValue("@ISBN", ISBN);
                string author_id = commandAuthorId.ExecuteScalar()?.ToString();

                if (author_id != null)
                {
                    string sqlQueryUpdateAuthor = @"UPDATE author
                                                SET name = @name
                                                WHERE author_id = @author_id";
                    SqlCommand commandUpdatePub = new SqlCommand(sqlQueryUpdateAuthor, conn);
                    commandUpdatePub.Parameters.AddWithValue("@name", TextBox10.Text);
                    commandUpdatePub.Parameters.AddWithValue("@author_id", author_id);
                    commandUpdatePub.ExecuteNonQuery();
                }


                string sqlQueryPUPId = "SELECT pub_id FROM BOOK WHERE ISBN = @ISBN";
                SqlCommand commandPUPId = new SqlCommand(sqlQueryPUPId, conn);
                commandPUPId.Parameters.AddWithValue("@ISBN", ISBN);
                string pub_id = commandAuthorId.ExecuteScalar()?.ToString();

                if (pub_id != null)
                {
                    string sqlQueryUpdatePUP = @"UPDATE Publisher
                                                SET name = @name
                                                WHERE pub_id = @pub_id";
                    SqlCommand commandUpdatePub = new SqlCommand(sqlQueryUpdatePUP, conn);
                    commandUpdatePub.Parameters.AddWithValue("@name", TextBox14.Text);
                    commandUpdatePub.Parameters.AddWithValue("@pub_id", pub_id);
                    commandUpdatePub.ExecuteNonQuery();
                }

               

                string sqlQueryUpdate = @"UPDATE BOOK 
                                        SET Book_name = @Book_name, 
                                            year = @year, 
                                            number_of_copies = @number_of_copies 
                                        WHERE ISBN = @ISBN";
                SqlCommand command = new SqlCommand(sqlQueryUpdate, conn);
                command.Parameters.AddWithValue("@ISBN", ISBN);
                command.Parameters.AddWithValue("@Book_name", TextBox18.Text);
                command.Parameters.AddWithValue("@year", TextBox2.Text);
                command.Parameters.AddWithValue("@number_of_copies", Convert.ToInt32(TextBox6.Text)); 

                int updatedDetails = command.ExecuteNonQuery();
                if (updatedDetails > 0)
                {
                    MessageBox.Show("Executing Query...");
                    MessageBox.Show("Book details updated successfully!");
                    this.Hide();
                    main_admin main_admin = new main_admin(adminId);
                    main_admin.Show();
                }
                else
                {
                    MessageBox.Show("No book found with the provided ISBN.");
                }


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
