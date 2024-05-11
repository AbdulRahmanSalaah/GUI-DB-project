using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_app
{
    public partial class BrowseBooks : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dt;

        public BrowseBooks()
        {
            InitializeComponent();
            //  string connString = @"Data Source=OMAR;Initial Catalog=LibraryDatabase;Integrated Security=True;";
           string connString = @"Data Source=LAPTOP-DG70P2RU;Initial Catalog=LibraryDatabase;Integrated Security=True;";
            conn = new SqlConnection(connString);
            LoadData(true); // Load full list by default
        }

        // LoadData method loads data based on selected criteria or fully if specified
        private void LoadData(bool showFullList = false)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Build SQL query dynamically based on selected criteria
                string selectedCriteria = "Book.ISBN, ";
                if (showFullList || checkBoxName.Checked) selectedCriteria += "Book.Book_name, ";
                if (showFullList || checkBoxAuthor.Checked) selectedCriteria += "Author.name AS AuthorName, ";
                if (showFullList || checkBoxPublisher.Checked) selectedCriteria += "Publisher.name AS PublisherName, ";
                if (showFullList || checkBoxYear.Checked) selectedCriteria += "Book.year, ";

                // Remove trailing comma
                selectedCriteria = selectedCriteria.TrimEnd(' ', ',');

                // Fallback to the default selection if no criteria are chosen
                if (string.IsNullOrWhiteSpace(selectedCriteria))
                {
                    selectedCriteria = "Book.ISBN, Book.Book_name, Author.name AS AuthorName, Publisher.name AS PublisherName, Book.year";
                }

                string sqlQuery = $"SELECT {selectedCriteria} " +
                                  "FROM Book " +
                                  "JOIN Author ON Book.author_id = Author.author_id " +
                                  "JOIN Publisher ON Book.pub_id = Publisher.pub_id";

                adapter = new SqlDataAdapter(sqlQuery, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // Reload data on filtering button click
        private void filterButton_Click(object sender, EventArgs e)
        {
            LoadData(false); // Load with selected criteria
        }

        // Delete the selected book
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string isbn = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    // Delete the book by ISBN
                    string sqlDeleteCopy = "DELETE FROM Copy WHERE ISBN = @ISBN";
                    string sqlDeleteBorrow = "DELETE FROM Borrow WHERE ISBN = @ISBN";
                    string sqlDeleteBook = "DELETE FROM Book WHERE ISBN = @ISBN";
                    SqlCommand cmdDeleteBook = new SqlCommand(sqlDeleteBook, conn);
                    SqlCommand cmdDeleteBorrow = new SqlCommand(sqlDeleteBorrow, conn);
                    SqlCommand cmdDeleteCopy = new SqlCommand(sqlDeleteCopy, conn);
                    cmdDeleteCopy.Parameters.AddWithValue("@ISBN", isbn);
                    cmdDeleteBorrow.Parameters.AddWithValue("@ISBN", isbn);
                    cmdDeleteBook.Parameters.AddWithValue("@ISBN", isbn);
                    int rowsAffected1 = cmdDeleteCopy.ExecuteNonQuery();
                    int rowsAffected0 = cmdDeleteBorrow.ExecuteNonQuery();
                    int rowsAffected = cmdDeleteBook.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book deleted successfully.");
                        LoadData(true); // Refresh data grid with full list
                    }
                    else
                    {
                        MessageBox.Show("Error: No book found with the specified ISBN.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting book: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }
    }
}
