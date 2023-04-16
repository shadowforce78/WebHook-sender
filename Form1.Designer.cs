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
            this.webhookBox = new System.Windows.Forms.TextBox();
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
            this.sendBtn.Location = new System.Drawing.Point(921, 563);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(261, 111);
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
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1187, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Webhook Sender By DLX | SaumonDeLuxe#2960";
            // 
            // webhookBox
            // 
            this.webhookBox.Location = new System.Drawing.Point(84, 605);
            this.webhookBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webhookBox.Name = "webhookBox";
            this.webhookBox.Size = new System.Drawing.Size(540, 26);
            this.webhookBox.TabIndex = 3;
            this.webhookBox.Text = "WebHook Link";
            this.webhookBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(84, 107);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(540, 26);
            this.titleBox.TabIndex = 4;
            this.titleBox.Text = "Title";
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(84, 220);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(540, 26);
            this.authorBox.TabIndex = 5;
            this.authorBox.Text = "Author";
            this.authorBox.TextChanged += new System.EventHandler(this.authorBox_TextChanged);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(84, 281);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(540, 26);
            this.descriptionBox.TabIndex = 6;
            this.descriptionBox.Text = "Descritption";
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(84, 162);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(540, 26);
            this.colorBox.TabIndex = 7;
            this.colorBox.Text = "Color";
            this.colorBox.TextChanged += new System.EventHandler(this.colorBox_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleDescription = "Little program made in 1 hour";
            this.AccessibleName = "WebHook sender";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.webhookBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "WebHook sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox webhookBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox colorBox;
    }
}

