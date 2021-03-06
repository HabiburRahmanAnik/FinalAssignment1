﻿using FinalTermAssignment.Diary_Logic_Layer;
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
    public partial class DetailsFrom : Form
    {
        HomeScreen homeScreen;
        string name;
        public DetailsFrom()
        {
            InitializeComponent();
        }
        public DetailsFrom(HomeScreen homeScreen,string name)
        {
            InitializeComponent();
            this.homeScreen = homeScreen;
            this.name = name;
        }

        private void DetailsFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DetailsFrom_Load(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            dataGridView1.DataSource = addService.GetAllEvent(name);
        }

        private void createNewEvenrButton_Click(object sender, EventArgs e)
        {
            AddEvent add = new AddEvent(this, name);
            add.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent(this,name);
            deleteEvent.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }

        private void modifyButton_Click_1(object sender, EventArgs e)
        {
            ModifyEvent modifyEvent = new ModifyEvent(this, name);
            modifyEvent.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void homeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeScreen = new HomeScreen(this, name);
            homeScreen.Show();
            this.Hide();
        }
    }
}
