namespace WebhookSender
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(614, 366);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(174, 72);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "Send Webhook";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Webhook Sender By DLX | SaumonDeLuxe#2960";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 393);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(361, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "WebHook Link";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(56, 70);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(361, 20);
            this.titleBox.TabIndex = 4;
            this.titleBox.Text = "Title";
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(56, 143);
            this.authorBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(361, 20);
            this.authorBox.TabIndex = 5;
            this.authorBox.Text = "Author";
            this.authorBox.TextChanged += new System.EventHandler(this.authorBox_TextChanged);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(56, 183);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(361, 20);
            this.descriptionBox.TabIndex = 6;
            this.descriptionBox.Text = "Descritption";
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(56, 105);
            this.colorBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(361, 20);
            this.colorBox.TabIndex = 7;
            this.colorBox.Text = "Color";
            this.colorBox.TextChanged += new System.EventHandler(this.colorBox_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleDescription = "Little program made in 1 hour";
            this.AccessibleName = "WebHook sender";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Name = "Form1";
            this.Text = "WebHook sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox colorBox;
    }
}

