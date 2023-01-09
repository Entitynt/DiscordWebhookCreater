using Discord.Webhook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWebhookCreate
{
    public partial class Form1 : Form
    {
        string webhookUrl = "https://discord.com/api/webhooks/1062066687412817960/_A6N0xi2hM0-4K0LnGNahmX4KzYm6H4-kEyRer_bBX9gbQRMu-liqZt9P-OnlB2neeaj";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new WebhookClient with the WebhookUrl
            DiscordWebhookClient client = new DiscordWebhookClient(webhookUrl);

            // Send the message to the webhook
            client.SendMessageAsync(richTextBox1.Text);
        }
    }
}
