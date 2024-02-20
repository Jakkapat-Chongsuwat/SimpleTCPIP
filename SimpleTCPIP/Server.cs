using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SimpleTCP;

namespace SimpleTCPIP
{
    public partial class Server : Form
    {
        private SimpleTcpServer _server;

        public Server()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            _server = new SimpleTcpServer
            {
                Delimiter = 0x13, //end
                StringEncoder = Encoding.UTF8
            };
            _server.DataReceived += HandleServerDataReceived;
        }

        private void HandleServerDataReceived(object sender, SimpleTCP.Message e)
        {
            statusTxt.Invoke((MethodInvoker)delegate ()
            {
                statusTxt.Text += e.MessageString;
                e.Reply(string.Format(Environment.NewLine + "You said: {0}", e.MessageString.Trim()));
            });
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            _server.DataReceived -= HandleServerDataReceived;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            statusTxt.Text += "Server Starting...";
            IPAddress ip = IPAddress.Parse(hostIPTxt.Text);
            _server.Start(ip, Int32.Parse(hostPortTxt.Text));
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (_server.IsStarted)
            {
                _server.Stop();
            }
        }
    }
}
