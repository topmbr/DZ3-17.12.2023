using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;

        public Form1()
        {
            InitializeComponent();
            udpClient = new UdpClient();
        }

        private async void SendRequest(string request)
        {
            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            byte[] data = Encoding.ASCII.GetBytes(request);
            await udpClient.SendAsync(data, data.Length, serverEndpoint);

            UdpReceiveResult result = await udpClient.ReceiveAsync();
            string response = Encoding.ASCII.GetString(result.Buffer);

            listBoxResponses.Items.Add($"Server response: {response}");
        }

        private void btnSendRequest_Click_1(object sender, EventArgs e)
        {
            string request = txtRequest.Text;
            SendRequest(request);
        }
    }
}
