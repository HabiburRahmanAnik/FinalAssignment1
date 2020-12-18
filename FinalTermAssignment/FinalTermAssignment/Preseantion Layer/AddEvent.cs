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
        
        string name;
        public AddEvent(DetailsFrom df, string name)
        {
            InitializeComponent();
            this.name = name;
            addButton.Click += this.Refreash;
            addButton.Click += this.Clear;
        }
        private void AddEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //HomeScreen homeScreen = new HomeScreen(this,name);
            //HomeService homeService = new HomeService();
            
            //homeScreen.Show();
            //this.Hide();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            dataGridView1.DataSource = addService.GetAllEvent(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
           // int result = addService.Add(writeTextBox.Text, priorityComboBox.Text, dateTimePicker1.Text);
            //if (result>0)
            //{
            //    MessageBox.Show("Add seccessfully");
            //}
            //else
            //{
            //    MessageBox.Show("Error occur");
            //}
        }
        void Refreash(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            dataGridView1.DataSource= addService.GetAllEvent(name);
        }
        void Clear(object sender, EventArgs e)
        {
            writeTextBox.Text =priorityComboBox.Text=dateTimePicker1.Text= string.Empty;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }
    }
}
