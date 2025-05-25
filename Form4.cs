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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        string teleno;
        string pwd;
        string repwd;

        private void button1_Click(object sender, EventArgs e)
        {
            teleno = textBox1.Text;
            pwd = textBox3.Text;
            repwd = textBox3.Text;

            if (pwd == repwd)
            {
                con.Open();

                cmd = new SqlCommand("update loggin set PW = @PW where TeleNo = @TeleNo ", con);
                cmd.Parameters.AddWithValue("TeleNo", teleno);
                cmd.Parameters.AddWithValue("PW", pwd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password has being updated!!!", "Update password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }         
             else
             {
                MessageBox.Show("Password does not match", "Wrong values", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-9R49ITE; Initial Catalog = Final_Project; Integrated Security = True";
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

        
    }
}
