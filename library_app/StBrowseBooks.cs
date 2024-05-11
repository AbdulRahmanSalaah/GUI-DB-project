using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_app
{
    public partial class StBrowseBooks : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dt;

        private string userId;


        public StBrowseBooks(string userId)
        {
            this.userId = userId;
            InitializeComponent();
            string connString = @"Data Source=LAPTOP-DG70P2RU;Initial Catalog=LibraryDatabase;Integrated Security=True;";
            conn = new SqlConnection(connString);
            LoadData(true);

        }
        public StBrowseBooks()
        {
            InitializeComponent();
            string connString = @"Data Source=LAPTOP-DG70P2RU;Initial Catalog=LibraryDatabase;Integrated Security=True;";
            conn = new SqlConnection(connString);
            LoadData(true);
        }



        private void LoadData(bool showFullList = false)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string selectedCriteria = "Book.ISBN, ";
                if (showFullList || checkBoxName.Checked) selectedCriteria += "Book.Book_name, ";
                if (showFullList || checkBoxAuthor.Checked) selectedCriteria += "Author.name AS AuthorName, ";
                if (showFullList || checkBoxPublisher.Checked) selectedCriteria += "Publisher.name AS PublisherName, ";
                if (showFullList || checkBoxYear.Checked) selectedCriteria += "Book.year, ";
                selectedCriteria = selectedCriteria.TrimEnd(' ', ',');

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

        private void filterButton_Click(object sender, EventArgs e)
        {
            LoadData(false);
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string isbn = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();

                try
                {
                    conn.Open();

                    // Check if the number of copies is greater than 0
                    string sqlCheckCopies = "SELECT number_of_copies FROM Book WHERE ISBN = @ISBN";
                    SqlCommand cmdCheckCopies = new SqlCommand(sqlCheckCopies, conn);
                    cmdCheckCopies.Parameters.AddWithValue("@ISBN", isbn);

                    int copies = Convert.ToInt32(cmdCheckCopies.ExecuteScalar());

                    if (copies > 0)
                    {
                       


                        BorrowPage borrowPage = new BorrowPage(userId, isbn);
                        // MessageBox.Show(isbn);
                        // MessageBox.Show(userId);



                        borrowPage.Show();




                    }
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error borrowing book: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to borrow.");
            }
        }


        // private void returnButton_Click(object sender, EventArgs e)
        // {
        //     if (dataGridView1.CurrentRow != null)
        //     {
        //         string isbn = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();

        //         try
        //         {
        //             conn.Open();

        //             string sqlUpdate = "UPDATE Book SET is_borrowed = 0 WHERE ISBN = @ISBN";
        //             SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
        //             cmdUpdate.Parameters.AddWithValue("@ISBN", isbn);

        //             int rowsAffected = cmdUpdate.ExecuteNonQuery();

        //             if (rowsAffected > 0)
        //             {
        //                 MessageBox.Show("Book returned successfully.");
        //                 LoadData(false);
        //             }
        //             else
        //             {
        //                 MessageBox.Show("Error: No book found with the specified ISBN.");
        //             }
        //         }
        //         catch (Exception ex)
        //         {
        //             MessageBox.Show("Error returning book: " + ex.Message);
        //         }
        //         finally
        //         {
        //             conn.Close();
        //         }
        //     }
        //     else
        //     {
        //         MessageBox.Show("Please select a book to return.");
        //     }
        // }
    }
}
