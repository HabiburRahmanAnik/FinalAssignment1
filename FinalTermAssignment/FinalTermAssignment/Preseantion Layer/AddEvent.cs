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
    public partial class AddEvent : Form
    {
        ModifyEvent modifyEvent;
        HomeScreen HomeScreen;
        DeleteEvent deleteEvent;
        string name;

        public AddEvent()
        {
            InitializeComponent();           
        }
        public AddEvent(DetailsFrom df, string name)
        {
            InitializeComponent();
            this.name = name;
            addButton.Click += this.Refreash;
            addButton.Click += this.Clear;
        }
        public AddEvent(DeleteEvent deleteEvent, string name)
        {
            InitializeComponent();
            this.deleteEvent = deleteEvent;
            this.name = name;
            
        }
        public AddEvent(HomeScreen homeScreen)
        {
            InitializeComponent();
            this.HomeScreen = homeScreen;
            
        }
        public AddEvent(ModifyEvent modifyEvent,string name)
        {
            InitializeComponent();
            this.modifyEvent = modifyEvent;
            this.name = name;
           
        }
        private void AddEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            dataGridView1.DataSource = addService.GetAllEvent(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            int result = addService.Add(titleTextBox.Text,writeTextBox.Text, priorityComboBox.Text, dateTimePicker1.Text, Convert.ToInt32( userIdTextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("Add seccessfully");
                this.Refreash(this, null);
                this.Clear(this, null);
            }
            else
            {
                MessageBox.Show("Error occur");
            }
        }
        void Refreash(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            dataGridView1.DataSource= addService.GetAllEvent(name);
        }
        void Clear(object sender, EventArgs e)
        {
           titleTextBox.Text= writeTextBox.Text =priorityComboBox.Text=dateTimePicker1.Text= userIdTextBox.Text= string.Empty;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }

        private void modifyEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyEvent = new ModifyEvent(this,name);
            modifyEvent.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeScreen=new HomeScreen(this,name);
            HomeScreen.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void deleteEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteEvent = new DeleteEvent(this,name);
            deleteEvent.Show();
            this.Hide();
        }
    }
}
