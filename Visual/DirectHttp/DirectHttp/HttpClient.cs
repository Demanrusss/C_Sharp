using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace DirectHttp
{
    public class HttpClient
    {
        public const int Web_PAGE_STATUS_OK = 200;

        public const int Web_ERROR_UNKNOWN_ERROR = 0;
        public const int Web_ERROR_HOST_NOT_FOUND = -1;
        public const int Web_ERROR_CANT_CONNECT = -2;
        public const int Web_ERROR_UNAVAILABLE = -3;
        public const int Web_ERROR_UNKNOWN_CODE = -4;

        // Constructor will init a port by default
        public HttpClient()
        {
            Port = 80;
        }

        // Constructor will init a port added by a user
        public HttpClient(int port)
        {
            if (port > 0 && port < 65535)
                Port = port;
        }

        // Here we will store our loaded web-page
        StringBuilder pageContent = null;

        public StringBuilder PageContent
        {
            get { return pageContent; }
        }

        // Just in case creating a port variable
        int Port { get; set; }

        // Method that returns status of a web-page
        public int GetPageStatus(Uri url)
        {
            IPAddress address = GetAddress(url.Host);

            if (address == null)
                return Web_ERROR_HOST_NOT_FOUND;

            Socket socket = new Socket(AddressFamily.InterNetwork, 
                SocketType.Stream, ProtocolType.Tcp);
            EndPoint endPoint = new IPEndPoint(address, Port);

            try
            {
                socket.Connect(endPoint);
            }
            catch (Exception)
            {
                return Web_ERROR_CANT_CONNECT;
            }

            string command = GetCommand(url);
            Byte[] bytesSent = Encoding.ASCII.GetBytes(command.Substring(1, 
                command.Length - 1) + "\r\n");
            socket.Send(bytesSent);

            byte[] buffer = new byte[1024];

            int readBytes;
            int result = Web_ERROR_UNAVAILABLE;
            pageContent = null;

            while ((readBytes = socket.Receive(buffer)) > 0)
            {
                string resultStr = System.Text.Encoding.ASCII.GetString(
                    buffer, 0, readBytes);

                if (pageContent == null)
                {
                    string statusStr = resultStr.Remove(0, 
                        resultStr.IndexOf(' ') + 1);

                    try
                    {
                        result = Convert.ToInt32(statusStr.Substring(0, 3));
                    }
                    catch (Exception)
                    {
                        result = Web_ERROR_UNKNOWN_CODE;
                    }

                    pageContent = new StringBuilder();
                }

                pageContent.Append(resultStr);
            }

            socket.Close();
            return result;
        }

        // A small method in order to create Http-request
        protected string GetCommand(Uri url)
        {
            string command = "GET " + url.PathAndQuery + " HTTP/1.1\r\n";
            command += "Host: " + url.Host + "\r\n";
            command += "User-Agent: CyD Network Utilities\r\n";
            command += "Accept: */* \r\n";
            command += "Accept-Language: en-us \r\n";
            command += "Accept-Encoding: gzip, deflate \r\n";
            command += "\r\n";

            return command;
        }

        // Transforming address string into an object
        public IPAddress GetAddress(string address)
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
    }
}
