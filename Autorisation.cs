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
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (password_check.Checked)
            {
                password_text.UseSystemPasswordChar = false;
            }
            else
            {
                password_text.UseSystemPasswordChar = true;
            }

        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            DBConnection.Connect();
            DBConnection.Authorization(login_text.Text,password_text.Text);
            if (DBConnection.User != null)
            {
                main f1 = new main();
                f1.Show();
                this.Hide();
            }
            
                else
                {
                    MessageBox.Show("Такого пользователя нет");
                }
          
        }
    }
}
