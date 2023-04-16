using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        static void SendMs(string title, string webhook, string author, string description)

        {

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            // payload for embed
            string payload = "{\"embeds\":[{\"title\":" + title + ",\"author\":{\"name\":" + author + "},\"description\":" + description + ",}]}";
            client.UploadData(webhook, Encoding.UTF8.GetBytes(payload));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMs(titleBox.Text, textBox2.Text, authorBox.Text, descriptionBox.Text);

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