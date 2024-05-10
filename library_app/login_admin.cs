using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;





namespace library_app
{
    public partial class login_admin : Form
    {



        public login_admin()
        {
            InitializeComponent();
            Button5.Click += Button5_Click;

        }

        private void Button5_Click(object? sender, EventArgs e)
        {
            //var datasource = @"LAPTOP-DG70P2RU";//your server
            // var datasource = @"REVISION-PC";
            var datasource = @"LAPTOP-DG70P2RU"; // Your server
            var database = "LibraryDatabase"; //your database name
            


            // your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                       + database + ";Persist Security Info=True;Integrated Security=True;";


            string mail = TextBox3.Text;
            string pass = TextBox4.Text;

            
            SqlConnection conn = new SqlConnection(connString);



            try
            {

                if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                conn.Open();
                string sqlQuery = "SELECT A_id FROM Admin WHERE mail = @mail";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@mail", mail);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    // Email found, now check password
                    sqlQuery = "SELECT A_id FROM Admin WHERE mail = @mail AND pass = @pass";
                    command = new SqlCommand(sqlQuery, conn);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@pass", pass);
                    result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string adminId = result.ToString();
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        main_admin main_admin = new main_admin(adminId);
                        main_admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.");
                    }
                }
                else
                {
                    MessageBox.Show("Email address not found.");
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