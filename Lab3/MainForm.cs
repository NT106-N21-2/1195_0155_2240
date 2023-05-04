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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void bt_Bai5_Click(object sender, EventArgs e)
        {

            Bai5_Dashboard b5 = new Bai5_Dashboard();
            b5.Show();

        }
    }
}
