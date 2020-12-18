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
        int id = 0;
        public ModifyEvent()
        {
            InitializeComponent();
            modifyButton.Click += this.Refreash;
            modifyButton.Click += this.Clear;
        }

        private void ModifyEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifyService modifyService = new ModifyService();
           int result = modifyService.ModifyNotes(id, writeTextBox.Text, dateTimePicker.Text, importantComboBox.Text);
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
            HomeService homeService = new HomeService();
           // modifyDataGridView.DataSource = homeService.GetAllNote();
        }

        private void modifyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)modifyDataGridView.Rows[e.RowIndex].Cells[0].Value;
            writeTextBox.Text = modifyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker.Text = modifyDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            importantComboBox.Text = modifyDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        void Refreash(object sender, EventArgs e)
        {
            HomeService homeService = new HomeService();
            //modifyDataGridView.DataSource = homeService.GetAllNote();
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
    }
}
