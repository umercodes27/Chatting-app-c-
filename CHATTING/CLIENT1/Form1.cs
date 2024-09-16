using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;

using System.Windows.Forms;

namespace CLIENT1
{
    public partial class Form1 : Form
    {

        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void RunClient(string serverIP, int port)
        {
            try
            {
                client = new TcpClient(serverIP, port);
                stream = client.GetStream();

                string clientName = nameTextBox.Text;
                byte[] nameData = Encoding.ASCII.GetBytes(clientName);
                stream.Write(nameData, 0, nameData.Length);

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                sendButton.Enabled = true;
                connectButton.Enabled = false;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Exception: {e.Message}");
            }
        }

        private void ReceiveMessages()
        {
            byte[] data = new byte[256];

            try
            {
                while (true)
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    string receivedData = Encoding.ASCII.GetString(data, 0, bytes);

                  
                        Invoke(new Action(() =>
                        {
                            messageListBox.Items.Add($"Received from server: {receivedData}");
                        }));
                    }
                
            }
            catch (Exception e)
            {
                MessageBox.Show($"Server disconnected: {e.Message}");
            }

            stream.Close();
            client.Close();
        }

     



        private void connectButton_Click_1(object sender, EventArgs e)
        {
            string serverIP = "127.0.0.1";
            int port = 12345;
            RunClient(serverIP, port);

        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input = inputTextBox.Text;
                byte[] data = Encoding.ASCII.GetBytes(input);
                stream.Write(data, 0, data.Length);
                inputTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message: {ex.Message}");
            }
        }

        private void ConnectButtonColorChanged(object sender, EventArgs e)
        {
            connectButton.BackColor = Color.White;
            connectButton.ForeColor = Color.Black;
            
        }
        private void ConnectButtonColorUnchanged(object sender, EventArgs e)
        {
            connectButton.BackColor = Color.DarkSlateGray;
            connectButton.ForeColor = Color.White;
        }
        private void SendButtonColorChanged(object sender, EventArgs e)
        {
            sendButton.BackColor = Color.White;
            sendButton.ForeColor = Color.Black;

        }
        
        private void SendButton_MouseHover(object sender, EventArgs e)
        {
            sendButton.Image = Properties.Resources.send; 
            sendButton.Text = ""; 
            sendButton.BackColor = Color.White;
            
        }

        private void SendButton_MouseLeave(object sender, EventArgs e)
        {
            sendButton.Image = null; 
            sendButton.Text = "Send Message"; 
            sendButton.BackColor = Color.DarkSlateGray;
            sendButton.ForeColor = Color.White;
        }
    }
}

