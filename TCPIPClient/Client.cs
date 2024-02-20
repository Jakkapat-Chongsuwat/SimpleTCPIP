using SimpleTCP;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TCPIPClient
{
    public partial class Client : Form
    {
        SimpleTcpClient _client;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, System.EventArgs e)
        {
            _client = new SimpleTcpClient
            {
                StringEncoder = Encoding.UTF8
            };
            _client.DataReceived += HandleClientdataReceived;
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            _client.DataReceived -= HandleClientdataReceived;
            _client.Disconnect();
        }

        private void HandleClientdataReceived(object sender, SimpleTCP.Message e)
        {
            statusTxt.Invoke((MethodInvoker)delegate ()
            {
                statusTxt.Text += e.MessageString;
            });
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            connectBtn.Enabled = false;
            _client.Connect(hostIPTextBox.Text.ToString(), Int32.Parse(portTxt.Text));
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            _client.WriteLineAndGetReply(Environment.NewLine + messageTxt.Text, TimeSpan.FromSeconds(3));
        }
    }
}
