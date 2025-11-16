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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlDataAdapter ad;
        public DataSet ds = new DataSet();

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            ad = new SqlDataAdapter("select * from ordering", con);
            ad.Fill(ds, "ordering");
            con.Close();

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ordering";
        }

        private void Form10_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }
    }
}
