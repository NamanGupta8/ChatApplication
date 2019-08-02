namespace N_Client
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
            this.Info1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.Udp = new System.Windows.Forms.Button();
            this.Tcp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.udpClient1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tcpClient1 = new System.Windows.Forms.TextBox();
            this.udpServer1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcpServer1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info1
            // 
            this.Info1.Location = new System.Drawing.Point(52, 36);
            this.Info1.Multiline = true;
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(206, 144);
            this.Info1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "SendTcp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.submit_onClick);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(314, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(288, 358);
            this.Info.TabIndex = 2;
            this.Info.Text = "";
            // 
            // Udp
            // 
            this.Udp.Location = new System.Drawing.Point(164, 297);
            this.Udp.Name = "Udp";
            this.Udp.Size = new System.Drawing.Size(94, 33);
            this.Udp.TabIndex = 7;
            this.Udp.Text = "Connect Udp";
            this.Udp.UseVisualStyleBackColor = true;
            this.Udp.Click += new System.EventHandler(this.Udp_Click);
            // 
            // Tcp
            // 
            this.Tcp.Location = new System.Drawing.Point(50, 297);
            this.Tcp.Name = "Tcp";
            this.Tcp.Size = new System.Drawing.Size(94, 33);
            this.Tcp.TabIndex = 6;
            this.Tcp.Text = "Connect Tcp";
            this.Tcp.UseVisualStyleBackColor = true;
            this.Tcp.Click += new System.EventHandler(this.Tcp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "SendUdp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Disconnect Tcp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Disconnect_Tcp);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 33);
            this.button4.TabIndex = 10;
            this.button4.Text = "Disconnect Udp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Disconnect_Udp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(52, 402);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "Connect Tcp Client";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ConnectTcpClient);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(164, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 40);
            this.button6.TabIndex = 12;
            this.button6.Text = "Connect Udp Client";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ConnectUdpClient);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Enter Port Udp Client";
            // 
            // udpClient1
            // 
            this.udpClient1.Location = new System.Drawing.Point(456, 512);
            this.udpClient1.Name = "udpClient1";
            this.udpClient1.Size = new System.Drawing.Size(146, 20);
            this.udpClient1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Enter Port Tcp Client";
            // 
            // tcpClient1
            // 
            this.tcpClient1.Location = new System.Drawing.Point(456, 444);
            this.tcpClient1.Name = "tcpClient1";
            this.tcpClient1.Size = new System.Drawing.Size(146, 20);
            this.tcpClient1.TabIndex = 27;
            // 
            // udpServer1
            // 
            this.udpServer1.Location = new System.Drawing.Point(456, 479);
            this.udpServer1.Name = "udpServer1";
            this.udpServer1.Size = new System.Drawing.Size(146, 20);
            this.udpServer1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Enter Port Udp Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ip Address";
            // 
            // tcpServer1
            // 
            this.tcpServer1.Location = new System.Drawing.Point(456, 409);
            this.tcpServer1.Name = "tcpServer1";
            this.tcpServer1.Size = new System.Drawing.Size(146, 20);
            this.tcpServer1.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 475);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Enter Port Tcp Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 574);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.udpClient1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tcpClient1);
            this.Controls.Add(this.udpServer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcpServer1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Udp);
            this.Controls.Add(this.Tcp);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Info1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Info1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.Button Udp;
        private System.Windows.Forms.Button Tcp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox udpClient1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tcpClient1;
        private System.Windows.Forms.TextBox udpServer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcpServer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

