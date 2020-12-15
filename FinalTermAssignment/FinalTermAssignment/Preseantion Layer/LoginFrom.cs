using FinalTermAssignment.Diary_Logic_Layer;
using FinalTermAssignment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTermAssignment
{
    public partial class LoginFrom : Form
    {
        int id;
        string name;
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void LoginFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginService loginService = new LoginService();
            loginService.Login(userNameTextBox.Text, passwordTextBox.Text);
            MessageBox.Show("login successfully");
            HomeScreen hs = new HomeScreen(this, userNameTextBox.Text);
            hs.Show();
            this.Hide();

        }
    }
}
