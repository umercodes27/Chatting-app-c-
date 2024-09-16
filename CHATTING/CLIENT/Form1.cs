
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CLIENT // SERVER
{
    public partial class Form1 : Form
    {
        static Dictionary<string, TcpClient> clients = new Dictionary<string, TcpClient>();
        private TcpListener listener;
        private Thread listenerThread;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void StartServer(string serverIP, int port)
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse(serverIP), port);
                listener.Start();
                Invoke(new Action(() => ServerLogs.Items.Add("Server started. Waiting for clients...")));

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Thread clientThread = new Thread(HandleClient);
                    clientThread.Start(client);
                }
            }
            catch (Exception e)
            {
                Invoke(new Action(() => ServerLogs.Items.Add($"Exception: {e.Message}")));
            }
        }
       
        private void HandleClient(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;
            NetworkStream stream = client.GetStream();
            byte[] data = new byte[256];

            try
            {
                
                int bytes = stream.Read(data, 0, data.Length);
                string clientName = Encoding.ASCII.GetString(data, 0, bytes);

                lock (clients)
                {
                    clients.Add(clientName, client);
                    
                    Invoke(new Action(() => ServerLogs.Items.Add($"Client '{clientName}' connected. Total clients: {clients.Count}")));
                }

                while (true)
                {
                    bytes = stream.Read(data, 0, data.Length);
                    string receivedData = Encoding.ASCII.GetString(data, 0, bytes);
                    Invoke(new Action(() => ServerLogs.Items.Add($"Received from client '{clientName}': {receivedData}")));

                    string[] parts = receivedData.Split('|');
                    if (parts.Length < 2)
                    {
                        byte[] responseData = Encoding.ASCII.GetBytes("Invalid message format.");
                        stream.Write(responseData, 0, responseData.Length);
                        continue;
                    }

                    string recipient = parts[0];
                    string message = parts[1];

                    if (clients.ContainsKey(recipient))
                    {
                        TcpClient recipientClient;
                        lock (clients)
                        {
                            recipientClient = clients[recipient];
                        }

                        NetworkStream recipientStream = recipientClient.GetStream();
                        byte[] responseData = Encoding.ASCII.GetBytes($"From '{clientName}': {message}");
                        recipientStream.Write(responseData, 0, responseData.Length);
                    }
                    else
                    {
                        byte[] responseData = Encoding.ASCII.GetBytes($"Recipient '{recipient}' not found.");
                        stream.Write(responseData, 0, responseData.Length);
                    }
                }
            }
            catch (Exception e)
            {
                Invoke(new Action(() => ServerLogs.Items.Add($"Client disconnected: {e.Message}")));
            }

            lock (clients)
            {
                clients.Remove(client.ToString());
                Invoke(new Action(() => ServerLogs.Items.Add($"Total clients: {clients.Count}")));
            }

            stream.Close();
            client.Close();
        }
      
        private void startButton_Click_1(object sender, EventArgs e)
        {
            string serverIP = "127.0.0.1";
            int port = 12345;
            listenerThread = new Thread(() => StartServer(serverIP, port));
            listenerThread.Start();
            startButton.Enabled = false;

        }
    }
}
