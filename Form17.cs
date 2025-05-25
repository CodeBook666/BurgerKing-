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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;

        string user;
        string pd;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from admin_login where UN = @UN and PWD = @PWD", con);

            user = textBox1.Text;
            pd = textBox3.Text;
            cmd.Parameters.AddWithValue("UN", user);
            cmd.Parameters.AddWithValue("PWD", pd);

            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    MessageBox.Show("You have logged into our system successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form11 f11 = new Form11();
                    f11.Show();
                    this.Hide();
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
            Form19 f19 = new Form19();
            f19.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }
        private void Form17_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-9R49ITE; Initial Catalog = Final_Project; Integrated Security = True";
        }
    }
}
