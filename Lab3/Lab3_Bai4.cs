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
    public partial class Lab3_Bai4 : Form
    {
        public Lab3_Bai4()
        {
            InitializeComponent();
        }

        private void Lab3_Bai4_Load(object sender, EventArgs e)
        {

        }

        private void client_Click(object sender, EventArgs e)
        {
            TCPClient tmp = new TCPClient();
            tmp.Show();
        }

        private void server1_Click(object sender, EventArgs e)
        {
            TCPServer tmp = new TCPServer();
            tmp.Show();
        }

        private void server2_Click(object sender, EventArgs e)
        {
            TCPServer tmp = new TCPServer();
            tmp.Show();
        }
    }
}
