using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_app
{
    public partial class report : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dt;

        public report()
        {
            InitializeComponent();
            LoadMostBorrowedBooks();
        }

        private void LoadMostBorrowedBooks()
        {
            // string connString = @"Data Source=OMAR;Initial Catalog=LibraryDatabase;Integrated Security=True;";
            string connString = @"Data Source=LAPTOP-DG70P2RU;Initial Catalog=LibraryDatabase;Integrated Security=True;";

            conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                // Correct SQL query
                string sqlQuery = @"
                    SELECT TOP 10 b.Book_name, b.ISBN, b.year, p.name AS PublisherName, a.name AS AuthorName, COUNT(*) AS BorrowCount
                    FROM Borrow br
                    JOIN Book b ON br.ISBN = b.ISBN
                    JOIN Author a ON b.author_id = a.author_id
                    JOIN Publisher p ON b.pub_id = p.pub_id
                    GROUP BY b.Book_name, b.ISBN, b.year, p.name, a.name
                    ORDER BY BorrowCount DESC";

                adapter = new SqlDataAdapter(sqlQuery, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
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
    }
}
