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
    public partial class Lab03_Bai3 : Form
    {
        public Lab03_Bai3()
        {
            InitializeComponent();
        }
        void ServerClick()
        {
            ServerLab3 frmservLab3 = new ServerLab3();
            frmservLab3.ShowDialog();
        }
        private void TCPServer_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(ServerClick));
            serverThread.Start();
        }

        private void TCPClient_Click(object sender, EventArgs e)
        {
            ClientLab3 frmclientLab3 = new ClientLab3();
            frmclientLab3.ShowDialog();
        }
    }
}
