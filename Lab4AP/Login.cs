using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4AP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            for (int i = 0; i < 3; i++)
            {
                if (username == Form1.users[i] && password == Form1.passwords[i])
                {
                    Form1.login = true;
                    Form1.currentuser = i;
                }
            }
            if (!Form1.login)
            {
                MessageBox.Show("Wrong username or password!!");
            }
        }
    }
}
