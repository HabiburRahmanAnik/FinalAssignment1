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
        //int id;
        //string name;
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
            bool result = loginService.Login(userNameTextBox.Text, passwordTextBox.Text);
            if (result)
            {
                MessageBox.Show("Login Successfully");
                HomeScreen homeScreen = new HomeScreen(this, userNameTextBox.Text);
                homeScreen.Show();
                this.Hide();

            }
            else
            {
                invalidLabel.Visible = true;
            }
        }
    }
}
