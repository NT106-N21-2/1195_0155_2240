using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
namespace Lab3
{
    public partial class Bai5_Client : Form
    {

        public Bai5_Client()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //Kết nối tới server ngay khi tạo được form
            Connect();
            
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }

        IPEndPoint ip;
        Socket client;
        void Connect()
        {
            try
            {
                //Kết nối tới server
                ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                client.Connect(ip);

                //Tạo thread để bắt đầu nhận được dữ liệu từ server
                Thread listen = new Thread(new ThreadStart(Receive));
                listen.Start();
            }
            catch
            {
                Close();
            }
        }

        void Close()
        {
            client.Close();
        }

        
        void Send()
        {
            //Gửi tin nhắn cho server
            string msg = tb_Name.Text + ": " + tb_Message.Text;
            byte[] sentBytyes = Encoding.UTF8.GetBytes(msg);
            client.Send(sentBytyes);
            AddMsg(msg);
        }

        void Receive()
        {
            try {
                //Liên tục nhận tin nhắn từ server (nếu có)
                while (true)
                {
                    byte[] receivedBytes = new byte[1024 * 5000];
                    client.Receive(receivedBytes);

                    string msg = Encoding.UTF8.GetString(receivedBytes);
                    AddMsg(msg);
                }
            }
            catch
            {
                //Nếu không thể nhận được (do lỗi) ta sẽ đóng kết nối lại
                Close();
            }
            
            
        }

        void AddMsg(string msg)
        {
            richTextBox1.Text += msg;
            richTextBox1.Text += Environment.NewLine;
            tb_Message.Clear();
        }

        private void Bai5_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void tb_Message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Send();
            }
        }
    }
}
