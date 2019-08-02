namespace W_Server
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
            this.Info = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tcp = new System.Windows.Forms.Button();
            this.Udp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DUdp = new System.Windows.Forms.Button();
            this.DTcp = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tcpServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.udpServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tcpClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.udpClient = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(12, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(288, 371);
            this.Info.TabIndex = 0;
            this.Info.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "SendTCP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 154);
            this.textBox1.TabIndex = 2;
            // 
            // Tcp
            // 
            this.Tcp.Location = new System.Drawing.Point(363, 315);
            this.Tcp.Name = "Tcp";
            this.Tcp.Size = new System.Drawing.Size(96, 37);
            this.Tcp.TabIndex = 4;
            this.Tcp.Text = "Begin Tcp Server";
            this.Tcp.UseVisualStyleBackColor = true;
            this.Tcp.Click += new System.EventHandler(this.Connect_Tcp);
            // 
            // Udp
            // 
            this.Udp.Location = new System.Drawing.Point(465, 315);
            this.Udp.Name = "Udp";
            this.Udp.Size = new System.Drawing.Size(97, 37);
            this.Udp.TabIndex = 5;
            this.Udp.Text = "Begin Udp Server";
            this.Udp.UseVisualStyleBackColor = true;
            this.Udp.Click += new System.EventHandler(this.Connect_Udp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "SendUdp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DUdp
            // 
            this.DUdp.Location = new System.Drawing.Point(465, 371);
            this.DUdp.Name = "DUdp";
            this.DUdp.Size = new System.Drawing.Size(97, 41);
            this.DUdp.TabIndex = 7;
            this.DUdp.Text = "Stop Udp Server";
            this.DUdp.UseVisualStyleBackColor = true;
            this.DUdp.Click += new System.EventHandler(this.Disconnect_Udp);
            // 
            // DTcp
            // 
            this.DTcp.Location = new System.Drawing.Point(363, 371);
            this.DTcp.Name = "DTcp";
            this.DTcp.Size = new System.Drawing.Size(96, 41);
            this.DTcp.TabIndex = 8;
            this.DTcp.Text = "Stop Tcp Server ";
            this.DTcp.UseVisualStyleBackColor = true;
            this.DTcp.Click += new System.EventHandler(this.Disconnect_Tcp);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(468, 432);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 40);
            this.button6.TabIndex = 14;
            this.button6.Text = "Connect Udp Client";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ConnectUdpClient);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 40);
            this.button5.TabIndex = 13;
            this.button5.Text = "Connect Tcp Client";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ConnectTcpClient);
            // 
            // tcpServer
            // 
            this.tcpServer.Location = new System.Drawing.Point(154, 408);
            this.tcpServer.Name = "tcpServer";
            this.tcpServer.Size = new System.Drawing.Size(146, 20);
            this.tcpServer.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter Port Tcp Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Port Udp Server";
            // 
            // udpServer
            // 
            this.udpServer.Location = new System.Drawing.Point(154, 478);
            this.udpServer.Name = "udpServer";
            this.udpServer.Size = new System.Drawing.Size(146, 20);
            this.udpServer.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter Port Tcp Client";
            // 
            // tcpClient
            // 
            this.tcpClient.Location = new System.Drawing.Point(154, 443);
            this.tcpClient.Name = "tcpClient";
            this.tcpClient.Size = new System.Drawing.Size(146, 20);
            this.tcpClient.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Enter Port Udp Client";
            // 
            // udpClient
            // 
            this.udpClient.Location = new System.Drawing.Point(154, 511);
            this.udpClient.Name = "udpClient";
            this.udpClient.Size = new System.Drawing.Size(146, 20);
            this.udpClient.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(396, 511);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ip Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 589);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.udpClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tcpClient);
            this.Controls.Add(this.udpServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcpServer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DTcp);
            this.Controls.Add(this.DUdp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Udp);
            this.Controls.Add(this.Tcp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Info);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Tcp;
        private System.Windows.Forms.Button Udp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DUdp;
        private System.Windows.Forms.Button DTcp;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tcpServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox udpServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tcpClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox udpClient;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}

