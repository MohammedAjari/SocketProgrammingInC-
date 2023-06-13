using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;


namespace ChatApplication2
{
    public partial class Form1 : Form
    {
        Socket sc;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sc = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sc.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            HostIP.Text = getLocalIP();
            ClientIP.Text ="10.2.18.50";
            status.BackColor = Color.Red;
            btnDicount.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(HostIP.Text), Convert.ToInt32(HostPort.Text));
                sc.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(ClientIP.Text), Convert.ToInt32(ClientPort.Text));
                sc.Connect(epRemote);
                buffer = new byte[1500];
                sc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallback), buffer);
                status.BackColor = Color.Green;
                btnConnect.Enabled = false;
                btnDicount.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MessageCallback(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);
                Invoke((MethodInvoker)delegate {
                    listMessage.Items.Add("Client: " + receivedMessage);
                });


                buffer = new byte[1500];
                sc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallback), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding aEconding = new ASCIIEncoding();
                byte[] sendingMessage = new byte[1500];
                sendingMessage = aEconding.GetBytes(txtMessage.Text);
                sc.Send(sendingMessage);

                listMessage.Items.Add("Host: " + txtMessage.Text);
                txtMessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDicount_Click(object sender, EventArgs e)
        {
            sc.Close();
            btnConnect.Enabled = true;
            btnDicount.Enabled = false;
        }

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Host_Enter(object sender, EventArgs e)
        {

        }

        private void labels_Click(object sender, EventArgs e)
        {

        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private string getLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}