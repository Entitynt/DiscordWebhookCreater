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
        string webhookUrl = "yourUrl";
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
