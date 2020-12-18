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
        public DetailsFrom()
        {
            InitializeComponent();
        }

        private void DetailsFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
