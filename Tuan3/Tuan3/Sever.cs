using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3
{
    public partial class Sever : Form
    {
        UdpClient udpSever;
        IPEndPoint endPoint;
        public Sever()
        {
            InitializeComponent();
        }

        private void Sever_Load(object sender, EventArgs e)
        {

        }
        public bool abc = true;
        private void Start_Click(object sender, EventArgs e)
        {
            udpSever = new UdpClient(int.Parse(SeverPort.Text));
            endPoint = new IPEndPoint(IPAddress.Any, 0);

            WriteBoard("Action : Server Started Successfully...");
            Thread thr = new Thread(new ThreadStart(SeverStart));
            thr.Start();
            Start.Enabled = false;
            NewClient.Enabled = true;
            SeverPort.Enabled = false;
        }

        private void SeverStart()
        {           
            while(abc)
            {
                byte[] buffer = udpSever.Receive(ref endPoint);
                string[] msg = Encoding.Unicode.GetString(buffer).Split('.');

                string clientPort = msg[0];
                string clientHostName = msg[1];
                string request = msg[2];
                WriteBoard(string.Format("Client as Port: {0} - as Host: {1} - Send: {2}.", clientPort, clientHostName, request));


                 buffer = Encoding.Unicode.GetBytes(DateTime.Now.ToString());
                udpSever.Send(buffer, buffer.Length, msg[1], int.Parse(msg[0]));
            }  
            
        }
        private void WriteBoard(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { Log.AppendText(msg + Environment.NewLine); });
            this.BeginInvoke(invoker);
        }

        private void SeverPort_TextChanged(object sender, EventArgs e)
        {
            SeverPort.BackColor = Color.AliceBlue;
        }
       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void Log_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            abc = false;
            Application.Exit();
        }
    }
}
