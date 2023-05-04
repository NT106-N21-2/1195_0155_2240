using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Lab3_Bai1 tmp = new Lab3_Bai1();
            tmp.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Lab3_Bai2 tmp = new Lab3_Bai2();
            tmp.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Lab3_Bai4 tmp = new Lab3_Bai4();
            tmp.Show();
        }
    }
}
