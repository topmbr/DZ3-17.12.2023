using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp41
{
    public partial class Form1 : Form
    {
        private UdpClient udpServer;
        private Dictionary<string, double> componentPrices;

        public Form1()
        {
            InitializeComponent();
            udpServer = new UdpClient(1234);
            componentPrices = new Dictionary<string, double>
            {
                {"processor", 200.0},
                {"memory", 50.0},
                {"storage", 100.0},
                {"graphics card", 300.0},
            };

            StartReceiving();

        }
        private async void StartReceiving()
        {
            while (true)
            {
                UdpReceiveResult result = await udpServer.ReceiveAsync();
                IPEndPoint clientEndpoint = result.RemoteEndPoint;
                byte[] data = result.Buffer;

                string clientAddress = clientEndpoint.Address.ToString();
                string request = Encoding.ASCII.GetString(data);

                string response = ProcessRequest(request);

                LogClientActivity(clientAddress, request);

                byte[] responseData = Encoding.ASCII.GetBytes(response);
                await udpServer.SendAsync(responseData, responseData.Length, clientEndpoint);
            }
        }


        private string ProcessRequest(string request)
        {
            string response;

            if (componentPrices.ContainsKey(request.ToLower()))
            {
                double price = componentPrices[request.ToLower()];
                response = $"Price for {request} is ${price}";
            }
            else
            {
                response = $"Component {request} not found";
            }

            return response;
        }

        private void LogClientActivity(string clientAddress, string request)
        {
            string logEntry = $"Logged: Client {clientAddress}, Request: {request}, Time: {DateTime.Now}";
            listBoxLog.Items.Add(logEntry);
        }


    }
}
