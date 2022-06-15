using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseCRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void Kondisiawal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Laki laki");
            comboBox1.Items.Add("Perempuan");
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            button1.Text = "Input";
            button2.Text = "Edit";
            button3.Text = "Delete";
            button4.Text = "Exit";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            textBox1.MaxLength = 50;
        }
        void Bukakunci()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apkRegisDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.apkRegisDataSet.users);

            Kondisiawal();
            Bukakunci();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Save")
            {
                if (textBox1.Text == ""|| textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Lengkapi Data Anda");
                }
                else
                {

                }
            }
            else
            {
                Bukakunci();
                button1.Text = "Save";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Text = "cancel";

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

