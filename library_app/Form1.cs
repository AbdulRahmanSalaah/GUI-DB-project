using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;





namespace library_app
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            Button17.Click += Button17_Click;

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




        private void Button17_Click(object sender, EventArgs e)
        {
            var datasource = @"LAPTOP-DG70P2RU";//your server
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

                if (string.IsNullOrEmpty(TextBox2.Text) || string.IsNullOrEmpty(TextBox4.Text) || string.IsNullOrEmpty(TextBox6.Text) ||
                string.IsNullOrEmpty(TextBox8.Text) || string.IsNullOrEmpty(TextBox10.Text) || string.IsNullOrEmpty(TextBox12.Text) ||
                string.IsNullOrEmpty(TextBox14.Text))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                //open connection
                conn.Open();

                MessageBox.Show("Connection Successful...");

                // string sqlQueryInsert = "INSERT INTO LibraryDatabase.dbo.Student VALUES " +
                //     "(@first_name, @last_name, @pass, @address, @mail,@B_date,@St_phone)";
                string pho = "INSERT INTO stu_Phone ( st_phone,s_id) " +
                         "VALUES ( @st_phone,@s_id)";

                string sqlQueryInsert = "INSERT INTO Student (first_name, last_name, pass, address, mail, B_date,St_phone,s_id) " +
                         "VALUES (@first_name, @last_name, @pass, @address, @mail, @B_date,@St_phone,@s_id)";




                SqlCommand com2 = new SqlCommand(pho, conn);
                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                command.Parameters.AddWithValue("@first_name", TextBox2.Text);
                command.Parameters.AddWithValue("@last_name", TextBox4.Text);
                command.Parameters.AddWithValue("@pass", TextBox6.Text);
                command.Parameters.AddWithValue("@address", TextBox8.Text);
                command.Parameters.AddWithValue("@mail", TextBox10.Text);
                command.Parameters.AddWithValue("@B_date", TextBox12.Text);
                com2.Parameters.AddWithValue("@st_phone", TextBox14.Text);
                command.Parameters.AddWithValue("@St_phone", TextBox14.Text);
                command.Parameters.AddWithValue("@s_id", TextBox16.Text);
                com2.Parameters.AddWithValue("@s_id", TextBox16.Text);






                MessageBox.Show("Executing Query...");

                com2.ExecuteNonQuery();
                command.ExecuteNonQuery(); //execute the Query





                MessageBox.Show("Inserted Successfully!");
                // this.Hide();



                this.Hide();







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
