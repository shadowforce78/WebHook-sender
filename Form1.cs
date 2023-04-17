using System;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
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
        static void SendMs(string webhookLink, string titleBox, string authorBox, string descriptionBox)

        {

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            // payload for embed 
            string payload = "{\"embeds\":[{\"title\":"+titleBox+",\"description\":"+descriptionBox+",\"author\":{\"name\":"+authorBox+"}}]}";
            client.UploadData(webhookLink, Encoding.UTF8.GetBytes(payload));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMs(textBox2.Text, titleBox.Text, authorBox.Text, descriptionBox.Text);

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