using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace Arduino_Test_2
{
    public partial class ArduinoSerialMonitor : Form
    {
        public delegate void AddDataDelegate(String myString);// Delegate for richtextbox
        public AddDataDelegate myDelegate;// An instance of AddDataDelegate
        public delegate void AddDataDelegate_button(String myString);// Delegate for button
        public AddDataDelegate_button myDelegate_button;// An instance of AddDataDelegate_button
        bool status = false;// LED status
        bool CommStatus = false; //

        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;



        public string getCurrentCpuUsage()
        {
            return cpuCounter.NextValue() + "%";
        }

        public string getAvailableRAM()
        {
            return ramCounter.NextValue() + "MB";
        }

        public ArduinoSerialMonitor()
        {
            InitializeComponent();
        }
        public void AddDataMethod_button(String myString)
        {
            ToggleLEDButton.Text = myString;//changes button text
        }
        public void AddDataMethod(String myString)
        {
            SerialAudit.AppendText(myString + Environment.NewLine); //changes richtextbox text
        }

        public bool InitSerial()
        {
            try
            {
                string[] ports = System.IO.Ports.SerialPort.GetPortNames();

                COMPortList.Items.AddRange(ports);
                COMPortList.SelectedIndex = 0; //Default Comm Port

                BaudRateList.SelectedIndex = 0; //Default Baud Rate

                foreach (string port in ports)
                {
                    SerialAudit.AppendText(Environment.NewLine + "Ports Available: " + port);
                }
            }
            ////catch (Win32Exception)
            ////{
            ////    SerialAudit.Text = "Arduino not connected";
            ////    return false;
            ///}
            catch (ArgumentOutOfRangeException)
            {
                SerialAudit.Text = "Arduino not connected";
                OpenPortButton.Enabled = false;
                SerialTimer.Enabled = true;
                return false;
            }
            OpenPortButton.Enabled = true;
            return true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            InitSerial();
            this.myDelegate = new AddDataDelegate(AddDataMethod);   //Assigning "the function that changes richtextbox text" to the delegate
            this.myDelegate_button = new AddDataDelegate_button(AddDataMethod_button);  //Assigning "the function that changes button text" to the delegate
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        public void sendData()
        {
            serialPort1.WriteLine(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string s = serialPort1.ReadExisting();//reads the serialport buffer
            s = s.Trim();
            if (s.Contains("state="))//checks if it is status
            {

                string new_s = s.Replace("state=", "");
                if (new_s.Contains("0"))
                {
                    status = false;
                    ToggleLEDButton.Invoke(this.myDelegate_button, new Object[] { "ON" });//sets button text to on
                }
                else
                {
                    status = true;
                    ToggleLEDButton.Invoke(this.myDelegate_button, new Object[] { "OFF" });//sets button text to off
                }
            }
            else
            {
                SerialAudit.Invoke(this.myDelegate, new Object[] { s });//adds the recieved bytes to the richtextbox
                //SerialAudit.AppendText(s);
            }
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (ToggleLEDButton.Text.Contains("ON"))
            {
                serialPort1.WriteLine("OFF");//sends off command when the previous state was on
                ToggleLEDButton.Text = "OFF";
                status = false;
            }
            else
            {
                serialPort1.WriteLine("ON");//sends on command when the previous state was off
                ToggleLEDButton.Text = "ON";
                status = true;
            }
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            SerialAudit.AppendText(Environment.NewLine + "Port Closed");
            CommStatus = false;
            CommStatusTextBox.Text = "Offline";
            CommStatusTextBox.BackColor = Color.White;
            OpenPortButton.Enabled = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SerialAudit.Clear();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               sendData();
            }
        }

        private void OpenPortButton_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = COMPortList.Text;
            serialPort1.BaudRate = Int32.Parse(BaudRateList.Text);


            serialPort1.Open();//Opening the serial port

            serialPort1.WriteLine("STATE");

            SerialAudit.AppendText(Environment.NewLine + "Serial Ready");

            //serialPort1.WriteLine("HANDSHAKE");

            CommStatus = true;
            CommStatusTextBox.Text = "Online";
            CommStatusTextBox.BackColor = Color.Green;
            OpenPortButton.Enabled = false;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string cpuUsage = getCurrentCpuUsage();
            CPUUsageTextBox.Text = cpuUsage;

            string memory = getAvailableRAM();
            RamTextbox.Text = memory;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SerialTimer_Tick(object sender, EventArgs e)
        {
            if(InitSerial())
            {
                SerialTimer.Enabled = false;
            }
        }
    }
}
