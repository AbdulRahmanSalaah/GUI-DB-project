// using System;
// using System.Data.SqlClient;
// using System.Text;
// using System.Windows.Forms;





// namespace library_app
// {
//     public partial class update_user : Form
//     {



//         private string userId;

//         public update_user(string userId)
//         {
//             InitializeComponent();
//             this.userId = userId; // Store the ID passed from the insert page
//             // PopulateFormData(); // Populate the form with the existing data
//             Button20.Click += Button20_Click;
//         }
//         // public update_admin()
//         // {
//         //     InitializeComponent();
//         //     Button0.Click += Button0_Click;


//         // }

//         private void Button20_Click(object? sender, EventArgs e)
//         {
//             var datasource = @"REVISION-PC";
//             //var datasource = @"LAPTOP-DG70P2RU";//your server
//             var database = "LibraryDatabase"; //your database name
//             // var username = "sa"; //username of server to connect
//             // var password = "password"; //password
//             // string connString = "Server=localhost;Database=YourDatabaseName;Integrated Security=True;";


//             // your connection string 
//             string connString = @"Data Source=" + datasource + ";Initial Catalog="
//                        + database + ";Persist Security Info=True;Integrated Security=True;";

//             // string connString = "Server= localhost; Database= LibraryDatabase; Integrated Security=True;";
//             // string connString = "Server= LAPTOP-DG70P2RU; Database= LibraryDatabase; Integrated Security=True;";
//             // string connString = "Data Source=LAPTOP-DG70P2RU;Initial Catalog=LibraryDatabase;Integrated Security=True;";
//             SqlConnection conn = new SqlConnection(connString);


//             try
//             {

//                 conn.Open();

//                 MessageBox.Show("Connection Successful...");


//                 string sqlQueryUpdate = "UPDATE Student SET first_name = @first_name, last_name = @last_name , pass = @pass, mail = @mail , address = @address , B_date = @B_date ,St_phone = @St_phone WHERE s_id = @s_id ";
//                 SqlCommand command = new SqlCommand(sqlQueryUpdate, conn);

//                 command.Parameters.AddWithValue("@first_name", TextBox1.Text);
//                 command.Parameters.AddWithValue("@last_name", TextBox2.Text);
//                 command.Parameters.AddWithValue("@pass", TextBox3.Text);
//                 command.Parameters.AddWithValue("@address", TextBox4.Text);
//                 command.Parameters.AddWithValue("@mail", TextBox5.Text);
//                 command.Parameters.AddWithValue("@B_date", TextBox6.Text);
//                 command.Parameters.AddWithValue("@St_phone", TextBox7.Text);
//                 command.Parameters.AddWithValue("@s_id", userId);
//                 command.ExecuteNonQuery();

//                 string sqlQueryUpdateStuPhone = "UPDATE stu_phone SET st_phone = @st_phone WHERE s_id = @s_id";
//                 SqlCommand commandUpdateStuPhone = new SqlCommand(sqlQueryUpdateStuPhone, conn);
//                 commandUpdateStuPhone.Parameters.AddWithValue("@st_phone", TextBox7.Text);
//                 commandUpdateStuPhone.Parameters.AddWithValue("@s_id", userId);
//                 commandUpdateStuPhone.ExecuteNonQuery();

//                 // string sqlQueryUpdateStuPhone = "UPDATE stu_phones SET st_phone = @St_phone WHERE s_id = @s_id";
//                 // SqlCommand commandUpdateStuPhone = new SqlCommand(sqlQueryUpdateStuPhone, conn);
//                 // commandUpdateStuPhone.Parameters.AddWithValue("@St_phone", TextBox7.Text);
//                 // commandUpdateStuPhone.Parameters.AddWithValue("@s_id", userId);
//                 // commandUpdateStuPhone.ExecuteNonQuery();

//                 MessageBox.Show("Executing Query...");

//                 MessageBox.Show("Updated Successfully!");


//                 this.Hide();
//                 main_User main_User = new main_User(userId);
//                 main_User.Show();

//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("Error: " + ex.Message);
//             }
//             finally
//             {

//                 conn.Close();

//             }




//         }

//     }

//.
// }
using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_app
{
    public partial class update_user : Form
    {
        private string userId;

        public update_user(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            Button20.Click += Button20_Click;
        }

        private void Button20_Click(object? sender, EventArgs e)
        {
            // var datasource = @"REVISION-PC";
            var datasource = @"LAPTOP-DG70P2RU";
            var database = "LibraryDatabase";

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                       + database + ";Persist Security Info=True;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                MessageBox.Show("Connection Successful...");

                // First, update the Student table
                string sqlQueryUpdate = "UPDATE Student SET first_name = @first_name, last_name = @last_name , pass = @pass, mail = @mail , address = @address , B_date = @B_date  WHERE s_id = @s_id ";
                SqlCommand command = new SqlCommand(sqlQueryUpdate, conn);
                command.Parameters.AddWithValue("@first_name", TextBox1.Text);
                command.Parameters.AddWithValue("@last_name", TextBox2.Text);
                command.Parameters.AddWithValue("@pass", TextBox3.Text);
                command.Parameters.AddWithValue("@address", TextBox4.Text);
                command.Parameters.AddWithValue("@mail", TextBox5.Text);
                command.Parameters.AddWithValue("@B_date", TextBox6.Text);
                // command.Parameters.AddWithValue("@St_phone", TextBox7.Text);
                command.Parameters.AddWithValue("@s_id", userId);
                command.ExecuteNonQuery();

                // Then, update the stu_phone table
                // string sqlQueryUpdatePhone = "UPDATE stu_phone SET st_phone = @st_phone WHERE s_id = @s_id";
                // SqlCommand commandUpdatePhone = new SqlCommand(sqlQueryUpdatePhone, conn);
                // commandUpdatePhone.Parameters.AddWithValue("@st_phone", TextBox7.Text);
                // commandUpdatePhone.Parameters.AddWithValue("@s_id", userId);
                // commandUpdatePhone.ExecuteNonQuery();



                MessageBox.Show("Executing Query...");
                MessageBox.Show("Updated Successfully!");

                this.Hide();
                main_User main_User = new main_User(userId);
                main_User.Show();
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
