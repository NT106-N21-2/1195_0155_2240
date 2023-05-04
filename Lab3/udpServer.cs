using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class udpServer : Form
    {
        public udpServer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void serverThread()
        {
            int Port = int.Parse(port.Text.Trim());
            UdpClient udpClent = new UdpClient(Port);
            while(true)
            {
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, int.Parse(port.Text.Trim()));
                Byte[] recieveBytes = udpClent.Receive(ref remoteIPEndPoint);
                string returnData = Encoding.UTF8.GetString(recieveBytes);
                string mess = remoteIPEndPoint.Address.ToString() + ": " + returnData.ToString();
                richTextBox1.Text += mess + "\n";
            }    
        }

        private void listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPsever = new Thread(new ThreadStart(serverThread));
            thdUDPsever.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
