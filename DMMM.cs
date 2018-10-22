using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class DMMM : UserControl
    {
        public DMMM()
        {
            InitializeComponent();
        }

        public string Us_Name
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string Us_Name1
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public Image Us_Image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string Us_ButtonAdd
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }
        public string Us_ButtonEdit
        {
            get { return button2.Text; }
            set { button2.Text = value; }
        }
        public string Us_ButtonDelete
        {
            get { return button3.Text; }
            set { button3.Text = value; }
        }
    }
}
