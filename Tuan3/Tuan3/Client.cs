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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tuan3
{
    public partial class Client : Form
    {
        UdpClient udpClient;
        IPEndPoint endPoint;
        public Client()
        {
            InitializeComponent();
        }
        private void Send_Click(object sender, EventArgs e)
        {
            if (BoxMessage.Text == "")
            {

            }
            else
            {

                try
                {
                    int severPort = int.Parse(SeverPort.Text);
                    int clientPort = int.Parse(BoxClient.Text);
                    string HostName = BoxHostName.Text;



                    // udpClient = new UdpClient(clientPort);

                    string msg = string.Format("{0}.{1}.{2}", clientPort, HostName, BoxMessage.Text.Trim());
                    byte[] buffer = Encoding.Unicode.GetBytes(msg);

                    //string a = clientPort + "." + HostName + "." + BoxMessage.Text;
                    // byte[] buffer = Encoding.UTF8.GetBytes(BoxMessage.Text);     

                    udpClient.Send(buffer, buffer.Length, HostName, severPort);

                    endPoint = new IPEndPoint(IPAddress.Any, 0);
                    buffer = udpClient.Receive(ref endPoint);
                    msg = Encoding.Unicode.GetString(buffer);

                    //    ListSend.AppendText(    BoxMessage.Text);
                    WriteLog(msg);
                    listBoxSend.Items.Insert(0,BoxMessage.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                ListReceive.Text += string.Format("Message Received {0}.{1}", msg, Environment.NewLine);
                BoxMessage.Text = string.Empty;
            });

            this.BeginInvoke(invoker);
        }
        private void BoxSever_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxHostName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxSend_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
           
                
                int clientPort = int.Parse(BoxClient.Text);            
                udpClient = new UdpClient(clientPort);
                button1.Enabled = BoxClient.Enabled = BoxHostName.Enabled = SeverPort.Enabled = false;
                Send.Enabled = true;         

        }

        private void ListSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListReceive_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeverPort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
