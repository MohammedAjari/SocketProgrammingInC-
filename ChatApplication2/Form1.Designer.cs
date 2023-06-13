namespace ChatApplication2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Host = new System.Windows.Forms.GroupBox();
            this.HostPort = new System.Windows.Forms.TextBox();
            this.HostIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientPort = new System.Windows.Forms.TextBox();
            this.ClientIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDicount = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.labels = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.Host.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Host
            // 
            this.Host.Controls.Add(this.HostPort);
            this.Host.Controls.Add(this.HostIP);
            this.Host.Controls.Add(this.label2);
            this.Host.Controls.Add(this.label1);
            this.Host.Location = new System.Drawing.Point(35, 33);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(250, 142);
            this.Host.TabIndex = 0;
            this.Host.TabStop = false;
            this.Host.Text = "Host";
            this.Host.Enter += new System.EventHandler(this.Host_Enter);
            // 
            // HostPort
            // 
            this.HostPort.Location = new System.Drawing.Point(89, 80);
            this.HostPort.Name = "HostPort";
            this.HostPort.Size = new System.Drawing.Size(152, 23);
            this.HostPort.TabIndex = 3;
            // 
            // HostIP
            // 
            this.HostIP.Location = new System.Drawing.Point(89, 39);
            this.HostIP.Name = "HostIP";
            this.HostIP.Size = new System.Drawing.Size(152, 23);
            this.HostIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientPort);
            this.groupBox1.Controls.Add(this.ClientIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(490, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ClientPort
            // 
            this.ClientPort.Location = new System.Drawing.Point(89, 80);
            this.ClientPort.Name = "ClientPort";
            this.ClientPort.Size = new System.Drawing.Size(152, 23);
            this.ClientPort.TabIndex = 3;
            // 
            // ClientIP
            // 
            this.ClientIP.Location = new System.Drawing.Point(89, 39);
            this.ClientIP.Name = "ClientIP";
            this.ClientIP.Size = new System.Drawing.Size(152, 23);
            this.ClientIP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(325, 49);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 26);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDicount
            // 
            this.btnDicount.Location = new System.Drawing.Point(327, 127);
            this.btnDicount.Name = "btnDicount";
            this.btnDicount.Size = new System.Drawing.Size(116, 26);
            this.btnDicount.TabIndex = 3;
            this.btnDicount.Text = "Disconnect";
            this.btnDicount.UseVisualStyleBackColor = true;
            this.btnDicount.Click += new System.EventHandler(this.btnDicount_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(35, 205);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(697, 23);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 15;
            this.listMessage.Location = new System.Drawing.Point(35, 256);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(822, 394);
            this.listMessage.TabIndex = 5;
            this.listMessage.SelectedIndexChanged += new System.EventHandler(this.listMessage_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(758, 205);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 26);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Location = new System.Drawing.Point(334, 91);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(39, 15);
            this.labels.TabIndex = 7;
            this.labels.Text = "Status";
            this.labels.Click += new System.EventHandler(this.labels_Click);
            // 
            // status
            // 
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.status.Location = new System.Drawing.Point(380, 90);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(42, 16);
            this.status.TabIndex = 8;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 791);
            this.Controls.Add(this.status);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnDicount);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Host);
            this.Name = "Form1";
            this.Text = "SSMChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Host.ResumeLayout(false);
            this.Host.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Host;
        private Label label1;
        private Label label2;
        private TextBox HostPort;
        private TextBox HostIP;
        private GroupBox groupBox1;
        private TextBox ClientPort;
        private TextBox ClientIP;
        private Label label3;
        private Label label4;
        private Button btnConnect;
        private Button btnDicount;
        private TextBox txtMessage;
        private ListBox listMessage;
        private Button btnSend;
        private Label labels;
        private TextBox status;
    }
}