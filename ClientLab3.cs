using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class ClientLab3 : Form
    {
        TcpClient client = new TcpClient();
        Stream stream;
        Byte[] data;
        public ClientLab3()
        {
            InitializeComponent();
        }

        static ASCIIEncoding encoding = new ASCIIEncoding();

        private void Client_Load(object sender, EventArgs e)
        {
            new ServerLab3().Show();
        }
        
        private void Connect_Click(object sender, EventArgs e)
        {
            
            try
            {
                Int32 ports = 50443;   
                client.Connect("127.0.0.1",ports);
            }
            catch (ArgumentNullException a)
            {
               MessageBox.Show(a.ToString());
            }
            catch (SocketException s)
            {
                MessageBox.Show(s.ToString());
            }
        }
       
        private void Send_Click(object sender, EventArgs e)
        {
                stream = client.GetStream();
                data = encoding.GetBytes(richTextBox1.Text);
                stream.Write(data, 0, data.Length);
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            stream.Close();
            client.Close();
            Close();
        }
    }
}
