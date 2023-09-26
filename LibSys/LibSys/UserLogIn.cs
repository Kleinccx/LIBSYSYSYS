using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSys
{
    public partial class UserLogIn : Form
    {
        public UserLogIn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

         
            string username = Usertxt.Text;
            string password = Passwordtxt.Text;



            if (username == "admin" && password == "admin123")
            {
                this.Hide();
               
                Menustrip menu = new Menustrip();
                Console.WriteLine("LogIn Successful");
                menu.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}