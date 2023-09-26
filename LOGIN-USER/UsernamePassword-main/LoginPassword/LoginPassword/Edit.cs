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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginPassword
{
    public partial class Form6 : Form
    {
        public string UpdatedUsername { get; private set; }
        public string UpdatedPassword { get; private set; }

        string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\LOGIN-USER\\UsernamePassword-main\\LoginPassword\\LoginPassword\\Password.mdb";
        private OleDbConnection connection;
        private DataGridViewRow _selectedRow;
        public Form6(DataGridViewRow selectedRow)
        {
            
            InitializeComponent();
            connection = new OleDbConnection(con);

            _selectedRow = selectedRow;

            // get the username and password from the selected row
            _selectedRow = selectedRow;
            UpdateUser.Text = selectedRow.Cells["username"].Value.ToString();
            UpdatePass.Text = selectedRow.Cells["password"].Value.ToString();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
         
            string newUsername = UpdateUser.Text;
            string newPassword = UpdatePass.Text;
            int ID = (int)_selectedRow.Cells["ID"].Value;

            string commandText = "UPDATE thePassword SET username=@username [username],password=@password WHERE username=@ID";
            OleDbCommand command = new OleDbCommand(commandText, connection);
            command.Parameters.AddWithValue("@Username", newUsername);
            command.Parameters.AddWithValue("@Password", newPassword);
            command.Parameters.AddWithValue("@ID", ID);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            // set the updated values
            UpdatedUsername = newUsername;
            UpdatedPassword = newPassword;
        }
        }
   }

