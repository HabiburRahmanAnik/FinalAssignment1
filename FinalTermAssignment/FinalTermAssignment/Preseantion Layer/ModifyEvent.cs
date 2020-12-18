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
    public partial class ModifyEvent : Form
    {
        DetailsFrom df;
        HomeScreen homeScreen;
        AddEvent addEvent;
        DeleteEvent deleteEvent;
        string name;
        int eventId = 0;

        public ModifyEvent(AddEvent addEvent,string name)
        {
            InitializeComponent();
            this.addEvent = addEvent;
            this.name = name;
        }
        public ModifyEvent(DetailsFrom df,string name)
        {
            InitializeComponent();
            this.df = df;
            this.name = name;
            modifyButton.Click += this.Refreash;
            modifyButton.Click += this.Clear;
        }

        private void ModifyEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ModifyService modifyService = new ModifyService();
           int result = modifyService.ModifyNotes(eventId,titleTextBox.Text, writeTextBox.Text, dateTimePicker.Text, importantComboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Modify Successfully");
            }
            else
            {
                MessageBox.Show("Error Occur!");
            }
        }

        private void ModifyEvent_Load(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            modifyDataGridView.DataSource = addService.GetAllEvent(name);
        }

        private void modifyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eventId = (int)modifyDataGridView.Rows[e.RowIndex].Cells[0].Value;
            titleTextBox.Text= modifyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            writeTextBox.Text = modifyDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            importantComboBox.Text = modifyDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker.Text = modifyDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        void Refreash(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            modifyDataGridView.DataSource = addService.GetAllEvent(name);
        }
        void Clear(object sender, EventArgs e)
        {
            writeTextBox.Text = importantComboBox.Text = dateTimePicker.Text = string.Empty;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
