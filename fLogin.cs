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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                e.Cancel = false;           
        }

        private void btDN_Click(object sender, EventArgs e)
        {
            Form1 fMain = new Form1();
            this.Hide();
            fMain.ShowDialog();
            this.Close();
        }
    }
}
