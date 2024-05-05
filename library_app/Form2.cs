using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;





namespace library_app
{
    public partial class Form2 : Form
    {



        public Form2()
        {
            InitializeComponent();
            Button0.Click += Button0_Click;

        }

        private void Button0_Click(object? sender, EventArgs e)
        {
            //var datasource = @"LAPTOP-DG70P2RU";//your server
             var datasource = @"REVISION-PC";
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

                if (string.IsNullOrEmpty(TextBox7.Text) || string.IsNullOrEmpty(TextBox12.Text) || string.IsNullOrEmpty(TextBox14.Text))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                conn.Open();

                MessageBox.Show("Connection Successful...");


                string sqlQueryInsert = "INSERT INTO Admin (name,pass,mail,A_id) " +
                            "VALUES (@name,@pass,@mail,@A_id)";


                // string sqlQueryInsert = "INSERT INTO Admin (name, pass, mail) OUTPUT INSERTED.A_id VALUES (@name, @pass, @mail)";


                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                command.Parameters.AddWithValue("@name", TextBox12.Text);
                command.Parameters.AddWithValue("@pass", TextBox14.Text);
                command.Parameters.AddWithValue("@mail", TextBox7.Text);
                command.Parameters.AddWithValue("@A_id", TextBox16.Text);

                MessageBox.Show("Executing Query...");
                command.ExecuteNonQuery();
                string adminId = TextBox16.Text;
                MessageBox.Show("Inserted Successfully!");

                // Retrieve the ID of the inserted record
                // string sqlQuerySelectId = "SELECT SCOPE_IDENTITY()";
                // SqlCommand selectIdCommand = new SqlCommand(sqlQuerySelectId, conn);
                // int insertedId = Convert.ToInt32(selectIdCommand.ExecuteScalar());






                // MessageBox.Show("Inserted ID: " + adminId);


                this.Hide();
                main_admin main_admin = new main_admin(adminId);
                main_admin.Show();


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
