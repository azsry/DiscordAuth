using System;
using System.Windows.Forms;
using Discord;

namespace DiscordAuth
{
    public partial class Form1 : Form
    {
        bool connected = false;
        DiscordClient _client = new DiscordClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await _client.Connect(textBox1.Text, textBox2.Text);
            connected = true;
            foreach (Server _server in _client.Servers)
            {
                listBox1.Items.Add(_server.Name + "::" + _server.Id);
            }
        }
    }
}
