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

namespace FinalTermAssignment
{
    public partial class HomeScreen : Form
    {
        LoginFrom lf;
        string name;
        int id=1;
        public HomeScreen()
        {
            InitializeComponent();
        }
        public HomeScreen(LoginFrom lf,string name)
        {
            InitializeComponent();
            this.lf = lf;
            this.name = name;            
            welcomeLabel.Text +=" "+name;
           
        }

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            HomeService homeService = new HomeService();
            dataGridView1.DataSource = homeService.GetAllNote(name);
        }


        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }

        private void createNewEvenrButton_Click(object sender, EventArgs e)
        {
            AddEvent add = new AddEvent(this,name);
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent();
            deleteEvent.Show();
            this.Hide();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            ModifyEvent modifyEvent = new ModifyEvent();
            modifyEvent.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
