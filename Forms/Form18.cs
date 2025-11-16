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
    public partial class Form18 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =; Initial Catalog = Final_Project; Integrated Security = True");
        double val = 0;

        public Form18()
        {
            InitializeComponent();
        }

        int ordid;
        string cusname;
        string teleno;
        string addr;
        string email;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            ordid = Convert.ToInt32(label8.Text);
            cusname = textBox1.Text;
            teleno = textBox2.Text;
            addr = textBox3.Text;
            email = textBox4.Text;

            SqlCommand cmd = new SqlCommand("Insert into ordering values (@OrdID, @Cusname, @TeleNo, @Address,@Email)", con);
            cmd.Parameters.AddWithValue("OrdID",ordid);
            cmd.Parameters.AddWithValue("Cusname", cusname);
            cmd.Parameters.AddWithValue("TeleNo", teleno);
            cmd.Parameters.AddWithValue("Address", addr);
            cmd.Parameters.AddWithValue("Email", email);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Congrtaulations!Your Data has being inserted into our system", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            FinalProject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form20 f20 = new Form20();
            f20.Show();
            this.Hide();
        }

        private void FinalProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(OrdID)from [ordering]", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            label8.Text = val + i.ToString();
        }
    }
}
