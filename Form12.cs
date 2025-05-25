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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;
        string teleno;

        private void button1_Click(object sender, EventArgs e)
        {
            teleno = textBox1.Text;
            con.Open();
            cmd = new SqlCommand("Delete from registrations where TeleNo = @TeleNo", con);

            cmd.Parameters.AddWithValue("TeleNo", teleno);
            if (MessageBox.Show("Are you sure to delete this record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                MessageBox.Show("Client Delete Successfully...", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form12_Load(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }
    }
}
