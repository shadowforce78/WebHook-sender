using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WebhookSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        static void SendMs(string title, string webhook, string color, string author, string description)

        {

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            // payload for embed
            string payload = "{\"embeds\":[{\"title\":" + title + ",\"color\":" + color + ",\"author\":{\"name\":" + author + "},\"description\":" + description + ",}]}";
            client.UploadData(webhook, Encoding.UTF8.GetBytes(payload));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMs(titleBox.Text, webhookBox.Text, colorBox.Text, authorBox.Text, descriptionBox.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void colorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//https://discord.com/api/webhooks/1084963375668269116/grVkFsv5F7MLkHj9w93wakfoiH36MejeomnVIGyhCDULLwtjGyiYUD5kgD0HvGPJMtu3