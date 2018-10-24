using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btQLTT_Click(object sender, EventArgs e)
        {
            fQLTT frmTT = new fQLTT();
            this.Hide();
            frmTT.ShowDialog();
            this.Show();
        }

        private void btQLS_Click(object sender, EventArgs e)
        {
            QLS frmS = new QLS();
            this.Hide();
            frmS.ShowDialog();
            this.Show();
        }

        private void btQLKH_Click(object sender, EventArgs e)
        {
            fQLKT frmKT = new fQLKT();
            this.Hide();
            frmKT.ShowDialog();
            this.Show();
        }

        private void btQLNV_Click(object sender, EventArgs e)
        {
            fQLNV frmNV = new fQLNV();
            this.Hide();
            frmNV.ShowDialog();
            this.Show();
        }
    }
}
