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

namespace SocketServer
{
    public partial class Form1 : Form
    {
        Socket server = null;
        Socket client = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void launchServerButton_Click(object sender, EventArgs e)
        {
            if (server != null && server.Connected)
                server.Disconnect(false);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, 
                ProtocolType.Tcp);
            EndPoint endPoint = new IPEndPoint(IPAddress.Any, 12345);

            try
            {
                server.Bind(endPoint);
                server.Listen(100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to launch a server " + ex.Message);
                return;
            }

            server.BeginAccept(new AsyncCallback(AsyncAcceptCallBack), server);
        }

        private void AsyncAcceptCallBack(IAsyncResult result)
        {
            Socket serverSocket = (Socket)result.AsyncState;

            SocketData data = new SocketData();
            data.ClientConnection = serverSocket.EndAccept(result);

            data.ClientConnection.BeginReceive(data.Buffer, 0, 1024, 
                SocketFlags.None, new AsyncCallback(ReadCallBack), data);
        }

        private void ReadCallBack(IAsyncResult result)
        {
            SocketData data = (SocketData)result.AsyncState;
            int bytes = data.ClientConnection.EndReceive(result);

            if (bytes > 0)
            {
                string s = Encoding.UTF8.GetString(data.Buffer, 0, bytes);
                data.ClientConnection.Send(Encoding.UTF8.GetBytes("Received: " + 
                    s.Length + " symbols"));
            }
        }

        private void connectToServerButton_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
                client.Disconnect(false);

            IPAddress addr = GetAddress(serverAddressTextBox.Text);

            if (addr == null)
            {
                MessageBox.Show("Ups... Could not understand the address");
                return;
            }

            client = new Socket(AddressFamily.InterNetwork, 
                SocketType.Stream, ProtocolType.Tcp);
            EndPoint point = new IPEndPoint(addr, 12345);

            try
            {
                client.Connect(point);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection mistake: " + ex.Message);
            }
        }

        private IPAddress GetAddress(string address)
        {
            IPAddress ipAddress = null;

            try
            {
                ipAddress = IPAddress.Parse(address);
            }
            catch
            {
                IPHostEntry heserver;

                try
                {
                    heserver = Dns.GetHostEntry(address);
                    if (heserver.AddressList.Length == 0)
                        return null;

                    ipAddress = heserver.AddressList[0];
                }
                catch
                {
                    return null;
                }
            }

            return ipAddress;
        }

        private void commandSendButton_Click(object sender, EventArgs e)
        {
            if (client == null && !client.Connected)
            {
                MessageBox.Show("Connect to a server first");
                return;
            }

            client.Send(Encoding.ASCII.GetBytes(commandTextBox.Text));

            byte[] buffer = new byte[1024];
            int bytes = client.Receive(buffer);

            if (bytes > 0)
            {
                string s = Encoding.UTF8.GetString(buffer, 0, bytes);
                richTextBox1.AppendText(s + "\n");
            }
        }
    }
}
