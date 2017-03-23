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
    
    public partial class Form1 : Form
    {
        public static string[] users = new string[3];
        public static string[] passwords = new string[3];
        public static bool[] form1 = new bool[3];
        public static bool[] form2 = new bool[3];
        public static bool[] form3 = new bool[3];
        public static int user = 0;
        public static bool login = false;
        public static int currentuser = -1; 
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                users[i] = "";
                passwords[i] = "";
                form1[i] = false;
                form1[i] = false;
                form1[i] = false;
            }
        }

        public bool ifUser(){

            for (int i = 0; i < 3; i++)
            {
                if (users[i] != "")
                {
                    return true;
                }
              
            }
            return false;

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ifUser() && !login)
            {
                Login l = new Login();
                l.MdiParent = this;
                l.Show();
            }
            else if(login){
                MessageBox.Show("User is already login!");
            }
            else
            {
                MessageBox.Show("There are no users!");
                Register r = new Register();
                r.MdiParent = this;
                r.Show();
            }

        }
        public void UpdateForm()
        {
            if (!form1[currentuser])
            {
                form1ToolStripMenuItem.HideDropDown();
            }
            if (!form2[currentuser])
            {
                form1ToolStripMenuItem.HideDropDown();
            }
            if (!form3[currentuser])
            {
                form1ToolStripMenuItem.HideDropDown();
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user != 3)
            {
                Register r = new Register();
                r.MdiParent = this;
                r.Show();
            }
            else
            {
                MessageBox.Show("Only three users can register");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login = false;
            currentuser = -1;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void permissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permission p = new Permission();
            p.MdiParent = this;
            p.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (currentuser > -1)
            {
                UpdateForm();
            }
        }
    }
}
