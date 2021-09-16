using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DBConnection.GetUserList();
            dataGridView.DataSource = null;
            dataGridView.DataSource = DBConnection.dtUsers;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Заполните все поля");

            }
            else
            {
                DBConnection.addUser(textBox1.Text, textBox2.Text);
                dataGridView.Refresh();
            }
        }
        //public bool Allow
    }
}
