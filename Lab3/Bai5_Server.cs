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
    public partial class Bai5_Server : Form
    {
        public Bai5_Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        IPEndPoint ip;
        Socket server;

        //Tạo một danh sách để lưu tên các client đang kết nối
        List<Socket> clientList;
        void Connect()
        {
            //Bind kết nối trên port 8080
            clientList = new List<Socket>();
            ip = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(ip);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    //Lắng nghe liên tục các kết nối
                    while (true)
                    {
                        server.Listen(100);

                        //Accept kết nối mới và add client vào list
                        Socket client = server.Accept();
                        clientList.Add(client);

                        //Tạo thread để nhận các tin nhắn từ client ở trên
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                    server.Bind(ip);
                }
                
                
            });

            Listen.IsBackground = true;
            Listen.Start();
        }

        void Close()
        {
            server.Close();
        }


        void Receive(object obj)
        {
            Socket client = obj as Socket;
            while (true)
            {
                //Nhận tin nhắn từ người dùng
                byte[] receivedBytes = new byte[1024 * 5000];
                client.Receive(receivedBytes);

                string msg = IPAddress.Parse(((IPEndPoint)client.RemoteEndPoint).Address.ToString()) + ":" 
                    + IPAddress.Parse(((IPEndPoint)client.RemoteEndPoint).Port.ToString()) + ": ";
                msg += Encoding.UTF8.GetString(receivedBytes);
                
                AddMsg(msg);

                //Boardcast tin nhắn tới tất cả người dùng (trừ người đã gửi)
                foreach (Socket item in clientList)
                {
                    if (item != client)
                        item.Send(receivedBytes);
                }

                
            }

        }

        void AddMsg(string msg)
        {
            txtLog.Text += msg;
            txtLog.Text += Environment.NewLine;
        }

        private void Bai5_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            txtLog.Text += "Server đang chạy trên 127.0.0.1:8080";
            txtLog.Text += Environment.NewLine;
            Connect();
        }
    }
}
