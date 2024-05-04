using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;





namespace library_app
{
    public partial class main : Form
    {



        public main()
        {
            InitializeComponent();
            Button2.Click += Button2_Click;
            Button3.Click += Button3_Click;


        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

        }
















    }


}
