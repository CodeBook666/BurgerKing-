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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(checkBox1.Text);
            }
            else
            {
                listBox1.Items.Remove(checkBox1.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(checkBox2.Text);
            }
            else
            {
                listBox1.Items.Remove(checkBox2.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                listBox1.Items.Add(checkBox3.Text);
            }
            else
            {
                listBox1.Items.Remove(checkBox3.Text);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                listBox1.Items.Add(checkBox4.Text);
            }
            else
            {
                listBox1.Items.Remove(checkBox4.Text);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                listBox2.Items.Add(checkBox5.Text);
            }
            else
            {
                listBox2.Items.Remove(checkBox5.Text);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                listBox2.Items.Add(checkBox6.Text);
            }
            else
            {
                listBox2.Items.Remove(checkBox6.Text);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                listBox2.Items.Add(checkBox7.Text);
            }
            else
            {
                listBox2.Items.Remove(checkBox7.Text);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                listBox2.Items.Add(checkBox8.Text);
            }
            else
            {
                listBox2.Items.Remove(checkBox8.Text);
            }
        }





        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                listBox3.Items.Add(checkBox9.Text);
            }
            else
            {
                listBox3.Items.Remove(checkBox9.Text);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                listBox3.Items.Add(checkBox10.Text);
            }
            else
            {
                listBox3.Items.Remove(checkBox10.Text);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                listBox3.Items.Add(checkBox11.Text);
            }
            else
            {
                listBox3.Items.Remove(checkBox11.Text);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                listBox3.Items.Add(checkBox12.Text);
            }
            else
            {
                listBox3.Items.Remove(checkBox12.Text);
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                listBox3.Items.Add(checkBox13.Text);
            }
            else
            {
                listBox3.Items.Remove(checkBox13.Text);
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                listBox3.Items.Add(checkBox14.Text);
            }
            else
            {
                listBox3.Items.Remove(checkBox14.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

      
    }
}
