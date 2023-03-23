namespace Tuan3
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.Send = new System.Windows.Forms.Button();
            this.BoxClient = new System.Windows.Forms.TextBox();
            this.BoxHostName = new System.Windows.Forms.TextBox();
            this.BoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSend = new System.Windows.Forms.ListBox();
            this.ListReceive = new System.Windows.Forms.TextBox();
            this.SeverPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(170)))));
            this.Send.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Send.FlatAppearance.BorderSize = 0;
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Cursor = System.Windows.Forms.Cursors.Default;
            this.Send.Enabled = false;
            this.Send.Location = new System.Drawing.Point(568, 373);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(101, 47);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // BoxClient
            // 
            this.BoxClient.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BoxClient.Location = new System.Drawing.Point(597, 125);
            this.BoxClient.Name = "BoxClient";
            this.BoxClient.Size = new System.Drawing.Size(134, 22);
            this.BoxClient.TabIndex = 15;
            this.BoxClient.Text = "2222";
            this.BoxClient.TextChanged += new System.EventHandler(this.BoxClient_TextChanged);
            // 
            // BoxHostName
            // 
            this.BoxHostName.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BoxHostName.Location = new System.Drawing.Point(597, 189);
            this.BoxHostName.Name = "BoxHostName";
            this.BoxHostName.Size = new System.Drawing.Size(134, 22);
            this.BoxHostName.TabIndex = 3;
            this.BoxHostName.Text = "localhost";
            this.BoxHostName.TextChanged += new System.EventHandler(this.BoxHostName_TextChanged);
            // 
            // BoxMessage
            // 
            this.BoxMessage.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BoxMessage.Location = new System.Drawing.Point(127, 373);
            this.BoxMessage.Name = "BoxMessage";
            this.BoxMessage.Size = new System.Drawing.Size(415, 22);
            this.BoxMessage.TabIndex = 4;
            this.BoxMessage.TextChanged += new System.EventHandler(this.BoxMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sever Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Client Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(594, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Host Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Message";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(170)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(597, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Connect to Sever";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSend
            // 
            this.listBoxSend.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listBoxSend.Enabled = false;
            this.listBoxSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSend.FormattingEnabled = true;
            this.listBoxSend.ItemHeight = 20;
            this.listBoxSend.Location = new System.Drawing.Point(12, 33);
            this.listBoxSend.Name = "listBoxSend";
            this.listBoxSend.Size = new System.Drawing.Size(530, 144);
            this.listBoxSend.TabIndex = 6;
            this.listBoxSend.SelectedIndexChanged += new System.EventHandler(this.listBoxSend_SelectedIndexChanged);
            // 
            // ListReceive
            // 
            this.ListReceive.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ListReceive.Enabled = false;
            this.ListReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListReceive.Location = new System.Drawing.Point(12, 213);
            this.ListReceive.Multiline = true;
            this.ListReceive.Name = "ListReceive";
            this.ListReceive.Size = new System.Drawing.Size(530, 142);
            this.ListReceive.TabIndex = 14;
            this.ListReceive.TextChanged += new System.EventHandler(this.ListReceive_TextChanged);
            // 
            // SeverPort
            // 
            this.SeverPort.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.SeverPort.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SeverPort.Location = new System.Drawing.Point(597, 55);
            this.SeverPort.Name = "SeverPort";
            this.SeverPort.Size = new System.Drawing.Size(136, 22);
            this.SeverPort.TabIndex = 0;
            this.SeverPort.Text = "1234";
            this.SeverPort.TextChanged += new System.EventHandler(this.SeverPort_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Message Had Sent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sever Response";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SeverPort);
            this.Controls.Add(this.ListReceive);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSend);
            this.Controls.Add(this.BoxMessage);
            this.Controls.Add(this.BoxHostName);
            this.Controls.Add(this.BoxClient);
            this.Controls.Add(this.Send);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox BoxClient;
        private System.Windows.Forms.TextBox BoxHostName;
        private System.Windows.Forms.TextBox BoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxSend;
        private System.Windows.Forms.TextBox ListReceive;
        public System.Windows.Forms.TextBox SeverPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

