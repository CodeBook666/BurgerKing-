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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;
        string teleno;
        string addr;
        string email;

        private void button1_Click(object sender, EventArgs e)
        {
           
            teleno = textBox1.Text;
            addr = textBox2.Text;
            email = textBox3.Text;

            con.Open();

            cmd = new SqlCommand("update registrations set Address = @Address, Email = @Email where TeleNo = @TeleNo  ", con);
            cmd.Parameters.AddWithValue("TeleNo",teleno);
            cmd.Parameters.AddWithValue("Address",addr);
            cmd.Parameters.AddWithValue("Email",email);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The records has being updated!Congratulations", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-9R49ITE; Initial Catalog = Final_Project; Integrated Security = True";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }
    }
}
