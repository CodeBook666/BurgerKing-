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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;

        string cusname;
        string teleno;
        string addr;
        string email;


        private void button2_Click(object sender, EventArgs e)
        {
            class3BindingSource.DataSource = new Class3();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            class3BindingSource.EndEdit();
            Class3 class3 = class3BindingSource.Current as Class3;
            if (class3 != null)
            {
                ValidationContext context = new ValidationContext(class3, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(class3, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            teleno= textBox1.Text;
            cusname = textBox2.Text;
            addr = textBox3.Text;
            email = textBox4.Text;

            cmd = new SqlCommand("insert into registrations values (@CusName, @TeleNo, @Address, @Email)", con);
            cmd.Parameters.AddWithValue("CusName", cusname);
            cmd.Parameters.AddWithValue("TeleNo", teleno);
            cmd.Parameters.AddWithValue("Address", addr);
            cmd.Parameters.AddWithValue("Email", email);
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Congrtaulations!Your Data has being inserted into our system", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form2 ft2 = new Form2();
            ft2.Show();
            this.Hide();

        }
                                  
        private void Form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-9R49ITE; Initial Catalog = Final_Project; Integrated Security = True";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }

       

       
    }
}
