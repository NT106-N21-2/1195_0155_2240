using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Lab3
{
    public partial class ServerLab3 : Form
    {
        public ServerLab3()
        {
            InitializeComponent();
        }

        static ASCIIEncoding encoding = new ASCIIEncoding();

        private void ServerLab3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(Listener));
            serverThread.Start();
        }
        void Listener()
        {
            try
            {
                //Khởi tạo cổng và local address cho server
                Int32 port = 50443;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                //Khởi tạo server
                TcpListener server = new TcpListener(localAddr, port);

                //server bắt đầu lắng nghe client
                server.Start();
                richTextBox1.Text = "Server started\n";

                //server chấp nhận yêu cầu kết nối từ client qua socket
                Socket socket = server.AcceptSocket();
                richTextBox1.Text += "Connection accepted from" + socket.LocalEndPoint;

                //Khởi tạo mảng nhận dữ liệu
                byte[] recv = new byte[256];
                string data = null;

                
                socket.Receive(recv);
                data = Encoding.UTF8.GetString(recv);
                richTextBox1.Text += "\n" + data;
                //socket.Send(encoding.GetBytes("Hello" + data));

                //Đóng kết nối
                socket.Close();
                server.Stop();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
