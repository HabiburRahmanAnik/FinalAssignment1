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
        AddEvent addEvent;
        DeleteEvent deleteEvent;
        ModifyEvent modifyEvent;
        DetailsFrom detailsFrom;
        LoginFrom lf;
        string name;

        public HomeScreen()
        {
            InitializeComponent();
        }
        public HomeScreen(AddEvent addEvent,string name)
        {
            InitializeComponent();
            this.addEvent = addEvent;
            this.name = name;
        }
        public HomeScreen(DeleteEvent deleteEvent, string name)
        {
            InitializeComponent();
            this.deleteEvent = deleteEvent;
            this.name = name;
        }
        public HomeScreen(ModifyEvent modifyEvent, string name)
        {
            InitializeComponent();
            this.modifyEvent = modifyEvent;
            this.name = name;
        }
        public HomeScreen(LoginFrom lf,string name)
        {
            InitializeComponent();
            this.lf = lf;
            this.name = name;                     
        }
        public HomeScreen(DetailsFrom detailsFrom,string name)
        {
            InitializeComponent();
            this.detailsFrom = detailsFrom;
            this.name = name;
        }

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

            HomeService homeService = new HomeService();
            homeScreenDataGridView.DataSource = homeService.GetAllNote(name);
        }


        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailsFrom dt = new DetailsFrom(this,name);
            dt.Show();
            this.Hide();
        }
    }
}
