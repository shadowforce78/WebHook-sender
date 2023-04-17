using System;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
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
        static void SendMs(string webhookLink)

        {

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            // payload for embed
            string payload = null;
            client.UploadData(webhookLink, Encoding.UTF8.GetBytes(payload));
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   SendMs();

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

        private Point FourthLocation;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                authorBox.Visible = false;
                descriptionBox.Location = authorBox.Location;
                if (FourthLocation == null)
                {
                    FourthLocation = descriptionBox.Location;
                }
                
            }
            else
            {
                authorBox.Visible = true;
                descriptionBox.Location = FourthLocation;
                
            }
        }
    }
}

//https://discord.com/api/webhooks/1097130504068800573/8gzatFV4vFn5C3txEPPPGyohaE1GznBFwS4X9GxWG3AUCyTCwoR-qLwM5QCsHTn9mZh4