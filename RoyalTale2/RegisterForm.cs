using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalTale2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(registerUsernameTextBox.Text) && !String.IsNullOrEmpty(registerPasswordTextBox.Text))
            {
                try
                {
                    //---data to send to the server---
                    string textToSend = (registerUsernameTextBox.Text + "\n" + registerPasswordTextBox.Text);

                    //---create a TCPClient object at the IP and port no.---
                    TcpClient client = new TcpClient("100.2.188.147", 10667);
                    NetworkStream nwStream = client.GetStream();
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

                    //---send the text---
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);

                    //---read back the text---
                    byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                    int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                    MessageBox.Show("Successfully processed: \n\n" + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.ReadLine();
                    client.Close();
                }
                catch
                {
                    MessageBox.Show("Cannot connect to registration server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter Username and/or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
