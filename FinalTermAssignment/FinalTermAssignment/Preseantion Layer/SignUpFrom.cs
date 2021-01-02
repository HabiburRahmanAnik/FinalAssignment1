using FinalTermAssignment.Diary_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTermAssignment.Preseantion_Layer
{
    public partial class SignUpFrom : Form
    {
        public SignUpFrom()
        {
            InitializeComponent();
        }

        private void signUpbutton_Click(object sender, EventArgs e)
        {
            string gen = null;
            if (maleRadioButton.Checked)
            {
                gen = maleRadioButton.Text;
            }
            else
            {
                gen = femaleRadioButton.Text;
            }
            if (nameTextBox.Text == "" || userNameTextBox.Text == "" || passwordTextBox.Text == "" || emailTextBox.Text == "" || checkBox1.Checked == false || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Fill up the requirde from");
            }
            else if(passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password not match");
            }
            else if(maleRadioButton.Checked==false && femaleRadioButton.Checked==false)
            {
                MessageBox.Show("Fill up the erquired from");
            }
            else
            {
                SignUpService signUpService = new SignUpService();
                int result = signUpService.InsertUser(nameTextBox.Text,userNameTextBox.Text,passwordTextBox.Text,emailTextBox.Text,dateTimePicker1.Text,gen);
                if(result>0)
                {
                    MessageBox.Show("Account create successfully");
                    LoginFrom loginFrom = new LoginFrom();
                    loginFrom.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error occur");
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void SignUpFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
