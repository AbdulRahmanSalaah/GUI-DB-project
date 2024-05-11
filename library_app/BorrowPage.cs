using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_app
{
    public partial class BorrowPage : Form

    {
        // private SqlConnection conn;

        private string userId;

        private string isbn;


        public BorrowPage(string userId, string isbn)
        {
            this.userId = userId;
            this.isbn = isbn;


            InitializeComponent();
            Button0.Click += Button0_Click;

            Label6.Text = "ISBN: " + isbn;






        }
        public BorrowPage()
        {
            InitializeComponent();
            Button0.Click += Button0_Click;

        }

        private void Button0_Click(object sender, EventArgs e)
        {



            // string connString = @"Data Source=OMAR;Initial Catalog=LibraryDatabase;Integrated Security=True;";

            string connString = @"Data Source=LAPTOP-DG70P2RU;Initial Catalog=LibraryDatabase;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);


            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }



                // Proceed with the Borrow insertion if the student exists
                string sqlQuery = "INSERT INTO Borrow (s_id, ISBN, return_date, Issue_date) VALUES (@s_id, @ISBN, @return_date, @Issue_date)";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                // Make sure to assign all parameter values correctly
                command.Parameters.AddWithValue("@return_date", RichTextBox3.Text);
                command.Parameters.AddWithValue("@Issue_date", RichTextBox5.Text);
                command.Parameters.AddWithValue("@s_id", userId);
                command.Parameters.AddWithValue("@ISBN", isbn);

                // MessageBox.Show(userId);

                // Delete the top copy from the Copy table
                string deleteTopCopyQuery = "DELETE FROM Copy WHERE ISBN = @ISBN AND copyNum = (SELECT MAX(copyNum) FROM Copy WHERE ISBN = @ISBN)";
                SqlCommand deleteTopCopyCommand = new SqlCommand(deleteTopCopyQuery, conn);
                deleteTopCopyCommand.Parameters.AddWithValue("@ISBN", isbn);
                deleteTopCopyCommand.ExecuteNonQuery();

                // Update the number of copies of the book
                string sqlUpdate = "UPDATE Book SET  number_of_copies = number_of_copies - 1 WHERE ISBN = @ISBN";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@ISBN", isbn);

                cmdUpdate.ExecuteNonQuery();



                command.ExecuteNonQuery();
                MessageBox.Show("Book Borrowed Successfully");
                this.Hide();
            }
            catch (Exception ex)
            {
                // Display the error message
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                conn.Close();
            }
        }



    }

}

