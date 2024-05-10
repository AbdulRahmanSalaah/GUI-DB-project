using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_app
{
    public partial class login_User : Form
    {
        public login_User()
        {
            InitializeComponent();
            Login_Button.Click += Login_Button_click;
        }

        private void Login_Button_click(object sender, EventArgs e)
        {
            //var datasource = @"LAPTOP-HJAK3VEB"; // Your server
            // var datasource = @"REVISION-PC";
            var datasource = @"LAPTOP-DG70P2RU"; // Your server
            var database = "LibraryDatabase"; // Your database name
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                if (string.IsNullOrEmpty(TB_mail.Text) || string.IsNullOrEmpty(TB_pass.Text))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                conn.Open();


                string select = "SELECT s_id FROM Student WHERE mail=@mail";

                SqlCommand command = new SqlCommand(select, conn);
                command.Parameters.AddWithValue("@mail", TB_mail.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Email found, now check password
                    reader.Close();

                    select = "SELECT s_id FROM Student WHERE mail=@mail AND pass=@pass";
                    command = new SqlCommand(select, conn);
                    command.Parameters.AddWithValue("@mail", TB_mail.Text);
                    command.Parameters.AddWithValue("@pass", TB_pass.Text);

                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Login Successful!");
                        string userId = reader["s_id"].ToString();
                        this.Hide();
                        main_User main_User = new main_User(userId);
                        main_User.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email address.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}