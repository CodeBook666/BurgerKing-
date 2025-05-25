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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }


    
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-9R49ITE; Initial Catalog = Final_Project; Integrated Security = True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from registrations where TeleNo=@TeleNo", con);
            cmd.Parameters.AddWithValue("TeleNo", int.Parse(textBox1.Text));
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            ad.Fill(ds);
            dataGridView1.DataSource = ds;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg|PNG files(.*png)|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.Show();
            this.Hide();
        }
    }
}
