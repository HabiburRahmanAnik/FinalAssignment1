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
    public partial class DeleteEvent : Form
    {
        int id = 0;
        public DeleteEvent()
        {
            InitializeComponent();
            delete_Button.Click += this.Refreash;
            delete_Button.Click += this.Clear;
        }

        private void DeleteEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            writeTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            importantComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeleteService deleteService = new DeleteService();
            int result = deleteService.DeleteNotes(id);
            if(result>0)
            {
                MessageBox.Show("Delete Successfully");
            }
            else
            {
                MessageBox.Show("Error Occur!");
            }
        }

        private void DeleteEvent_Load(object sender, EventArgs e)
        {
            HomeService homeService = new HomeService();
           dataGridView1.DataSource = homeService.GetAllNote();
        }
        void Refreash(object sender, EventArgs e)
        {
            HomeService homeService = new HomeService();
            dataGridView1.DataSource = homeService.GetAllNote();
        }
        void Clear(object sender, EventArgs e)
        {
            writeTextBox.Text = importantComboBox.Text = dateTextBox.Text = string.Empty;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom lf = new LoginFrom();
            lf.Show();
            this.Hide();
        }
    }
}
