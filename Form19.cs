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
using System.ComponentModel.DataAnnotations;

namespace FinalProject
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;
        string casname;
        string branch;
        string teleno;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            casname = textBox1.Text;
            branch = comboBox1.Text;
            teleno = textBox2.Text;

            cmd = new SqlCommand("insert into admin_registrations values (@CasName, @Branch, @TeleNo)", con);
            cmd.Parameters.AddWithValue("CasName", casname);
            cmd.Parameters.AddWithValue("TeleNo", teleno);
            cmd.Parameters.AddWithValue("Branch", branch);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Congrtaulations!Your Data has being inserted into our system", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form17 f17 = new Form17();
            f17.Show();
            this.Hide();

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-9R49ITE; Initial Catalog = Final_Project; Integrated Security = True";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            class4BindingSource.EndEdit();
            Class4 class4 = class4BindingSource.Current as Class4;
            if (class4 != null)
            {
                ValidationContext context = new ValidationContext(class4, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(class4, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            class4BindingSource.DataSource = new Class4();
        }
    }
}
