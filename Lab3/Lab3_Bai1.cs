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
    public partial class Lab3_Bai1 : Form
    {
        public Lab3_Bai1()
        {
            InitializeComponent();
        }

        private void udpServer_Click(object sender, EventArgs e)
        {
            udpServer tmp = new udpServer();
            tmp.Show();
        }

        private void udpClient_Click(object sender, EventArgs e)
        {
            udpClient tmp = new udpClient();
            tmp.Show();
        }
    }
}
