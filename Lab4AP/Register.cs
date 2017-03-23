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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.users[Form1.user]=textBox1.Text;
            Form1.passwords[Form1.user] = textBox1.Text;
            Form1.user++;
            Form1.login = true;
            Form1.currentuser = Form1.user;
           
        }
    }
}
