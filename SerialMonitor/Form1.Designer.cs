namespace Arduino_Test_2
{
    partial class ArduinoSerialMonitor
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ToggleLEDButton = new System.Windows.Forms.Button();
            this.SerialAudit = new System.Windows.Forms.RichTextBox();
            this.COMPortList = new System.Windows.Forms.ComboBox();
            this.COMPortLabel = new System.Windows.Forms.Label();
            this.OpenPortButton = new System.Windows.Forms.Button();
            this.ClosePortButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BaudRateList = new System.Windows.Forms.ComboBox();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.CommStatusTextBox = new System.Windows.Forms.TextBox();
            this.CommStatusLabel = new System.Windows.Forms.Label();
            this.ClearOutputButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPUUsageTextBox = new System.Windows.Forms.TextBox();
            this.CPUUsageLabel = new System.Windows.Forms.Label();
            this.RamTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // ToggleLEDButton
            // 
            this.ToggleLEDButton.Location = new System.Drawing.Point(1074, 551);
            this.ToggleLEDButton.Name = "ToggleLEDButton";
            this.ToggleLEDButton.Size = new System.Drawing.Size(75, 52);
            this.ToggleLEDButton.TabIndex = 0;
            this.ToggleLEDButton.Text = "Toggle LED";
            this.ToggleLEDButton.UseVisualStyleBackColor = true;
            this.ToggleLEDButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // SerialAudit
            // 
            this.SerialAudit.Location = new System.Drawing.Point(12, 63);
            this.SerialAudit.Name = "SerialAudit";
            this.SerialAudit.ReadOnly = true;
            this.SerialAudit.Size = new System.Drawing.Size(895, 678);
            this.SerialAudit.TabIndex = 2;
            this.SerialAudit.Text = "";
            // 
            // COMPortList
            // 
            this.COMPortList.FormattingEnabled = true;
            this.COMPortList.Location = new System.Drawing.Point(1074, 115);
            this.COMPortList.Name = "COMPortList";
            this.COMPortList.Size = new System.Drawing.Size(224, 21);
            this.COMPortList.TabIndex = 6;
            // 
            // COMPortLabel
            // 
            this.COMPortLabel.AutoSize = true;
            this.COMPortLabel.Location = new System.Drawing.Point(1003, 118);
            this.COMPortLabel.Name = "COMPortLabel";
            this.COMPortLabel.Size = new System.Drawing.Size(53, 13);
            this.COMPortLabel.TabIndex = 8;
            this.COMPortLabel.Text = "COM Port";
            // 
            // OpenPortButton
            // 
            this.OpenPortButton.Location = new System.Drawing.Point(1001, 373);
            this.OpenPortButton.Name = "OpenPortButton";
            this.OpenPortButton.Size = new System.Drawing.Size(75, 23);
            this.OpenPortButton.TabIndex = 9;
            this.OpenPortButton.Text = "Open Port";
            this.OpenPortButton.UseVisualStyleBackColor = true;
            this.OpenPortButton.Click += new System.EventHandler(this.OpenPortButton_Click);
            // 
            // ClosePortButton
            // 
            this.ClosePortButton.Location = new System.Drawing.Point(1114, 373);
            this.ClosePortButton.Name = "ClosePortButton";
            this.ClosePortButton.Size = new System.Drawing.Size(75, 23);
            this.ClosePortButton.TabIndex = 10;
            this.ClosePortButton.Text = "Close Port";
            this.ClosePortButton.UseVisualStyleBackColor = true;
            this.ClosePortButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(134, 772);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(526, 23);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox1_KeyDown);
            // 
            // BaudRateList
            // 
            this.BaudRateList.FormatString = "N0";
            this.BaudRateList.FormattingEnabled = true;
            this.BaudRateList.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.BaudRateList.Location = new System.Drawing.Point(1074, 161);
            this.BaudRateList.Name = "BaudRateList";
            this.BaudRateList.Size = new System.Drawing.Size(224, 21);
            this.BaudRateList.TabIndex = 12;
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(998, 164);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(58, 13);
            this.BaudRateLabel.TabIndex = 13;
            this.BaudRateLabel.Text = "Baud Rate";
            // 
            // CommStatusTextBox
            // 
            this.CommStatusTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CommStatusTextBox.Location = new System.Drawing.Point(1114, 421);
            this.CommStatusTextBox.Name = "CommStatusTextBox";
            this.CommStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.CommStatusTextBox.TabIndex = 14;
            // 
            // CommStatusLabel
            // 
            this.CommStatusLabel.AutoSize = true;
            this.CommStatusLabel.Location = new System.Drawing.Point(1029, 424);
            this.CommStatusLabel.Name = "CommStatusLabel";
            this.CommStatusLabel.Size = new System.Drawing.Size(69, 13);
            this.CommStatusLabel.TabIndex = 15;
            this.CommStatusLabel.Text = "Comm Status";
            // 
            // ClearOutputButton
            // 
            this.ClearOutputButton.Location = new System.Drawing.Point(786, 761);
            this.ClearOutputButton.Name = "ClearOutputButton";
            this.ClearOutputButton.Size = new System.Drawing.Size(75, 23);
            this.ClearOutputButton.TabIndex = 16;
            this.ClearOutputButton.Text = "Clear Output";
            this.ClearOutputButton.UseVisualStyleBackColor = true;
            this.ClearOutputButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(27, 772);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 17;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CPUUsageTextBox
            // 
            this.CPUUsageTextBox.Location = new System.Drawing.Point(1088, 670);
            this.CPUUsageTextBox.Name = "CPUUsageTextBox";
            this.CPUUsageTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPUUsageTextBox.TabIndex = 18;
            // 
            // CPUUsageLabel
            // 
            this.CPUUsageLabel.AutoSize = true;
            this.CPUUsageLabel.Location = new System.Drawing.Point(1006, 676);
            this.CPUUsageLabel.Name = "CPUUsageLabel";
            this.CPUUsageLabel.Size = new System.Drawing.Size(63, 13);
            this.CPUUsageLabel.TabIndex = 19;
            this.CPUUsageLabel.Text = "CPU Usage";
            // 
            // RamTextbox
            // 
            this.RamTextbox.Location = new System.Drawing.Point(1089, 711);
            this.RamTextbox.Name = "RamTextbox";
            this.RamTextbox.Size = new System.Drawing.Size(100, 20);
            this.RamTextbox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1006, 711);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Memory";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // SerialTimer
            // 
            this.SerialTimer.Interval = 1000;
            this.SerialTimer.Tick += new System.EventHandler(this.SerialTimer_Tick);
            // 
            // ArduinoSerialMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RamTextbox);
            this.Controls.Add(this.CPUUsageLabel);
            this.Controls.Add(this.CPUUsageTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ClearOutputButton);
            this.Controls.Add(this.CommStatusLabel);
            this.Controls.Add(this.CommStatusTextBox);
            this.Controls.Add(this.BaudRateLabel);
            this.Controls.Add(this.BaudRateList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ClosePortButton);
            this.Controls.Add(this.OpenPortButton);
            this.Controls.Add(this.COMPortLabel);
            this.Controls.Add(this.COMPortList);
            this.Controls.Add(this.SerialAudit);
            this.Controls.Add(this.ToggleLEDButton);
            this.Name = "ArduinoSerialMonitor";
            this.Text = "ArduinoSerialMonitor";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ToggleLEDButton;
        private System.Windows.Forms.RichTextBox SerialAudit;
        private System.Windows.Forms.ComboBox COMPortList;
        private System.Windows.Forms.Label COMPortLabel;
        private System.Windows.Forms.Button OpenPortButton;
        private System.Windows.Forms.Button ClosePortButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox BaudRateList;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.TextBox CommStatusTextBox;
        private System.Windows.Forms.Label CommStatusLabel;
        private System.Windows.Forms.Button ClearOutputButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox CPUUsageTextBox;
        private System.Windows.Forms.Label CPUUsageLabel;
        private System.Windows.Forms.TextBox RamTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SerialTimer;
    }
}

