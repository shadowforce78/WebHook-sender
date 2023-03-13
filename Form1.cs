using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
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
        static void SendMs(string message, string webhook)

        {

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            // payload for embed
            string payload = "{\"content\": \"" + message + "\"}";
            client.UploadData(webhook, Encoding.UTF8.GetBytes(payload));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // if textbox1 is empty, mesasge box error
            if (textBox1.Text == "")
            {
                MessageBox.Show("Cant send an empty message");
                return;
            }

            // if textbox2 dont have the right form error
            if (textBox2.Text == " ")
            {
                MessageBox.Show("Cant send an empty message");
                return;
            }
            if (textBox2.Text == "WebHook")
            {
                MessageBox.Show("Invalide WebHook");
                return;
            }




            // send message to webhook
            SendMs(this.textBox1.Text, this.textBox2.Text);


        }
    }
}