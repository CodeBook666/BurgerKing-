using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        
        string teleno;
        string pwd;

        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from loggin where TeleNo = @TeleNo and PW = @PW", con);

            teleno = textBox2.Text;
            pwd = textBox3.Text;

            cmd.Parameters.AddWithValue("TeleNo",teleno);
            cmd.Parameters.AddWithValue("PW", pwd);

            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    MessageBox.Show("You have logged into our system successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid Login.Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                con.Close();
            }
        } 

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-9R49ITE; Initial Catalog = Final_Project; Integrated Security = True";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

       
       
    }
}
