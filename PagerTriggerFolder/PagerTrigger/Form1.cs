using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;

namespace PagerTrigger
{
    public partial class Form1 : Form
    {
        public Form1 comPortForm;
        private volatile string selectedComPort;
        System.Timers.Timer time = new System.Timers.Timer();
        double interval;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            ComPortSelector.Items.AddRange(SerialPort.GetPortNames());
            comPortForm = this;
            StopButton.Enabled = false;
            pagerCountLabel.Text = "0";
            pBar.Value = 1;
            pBar.Step = 1000;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (ComPortSelector.SelectedItem != null)
            {
                selectedComPort = ComPortSelector.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a COM Port");
                return;
            }
            
            time.Elapsed += new ElapsedEventHandler(timed_Tick);
            if (pagerInterval.Text != null) {
                interval = Double.Parse(pagerInterval.Text);
            } else {
                interval = 30000; //default
            }

            pBar.Visible = true;
            pBar.Minimum = 1;
            pBar.Maximum = (int)Double.Parse(pagerInterval.Text);
            pBar.Value = 1;
            sysTime.Interval =  ((int)interval) / 10;
            time.Interval = interval;
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            i = 0;
            pagerCountLabel.Text = i.ToString();
            sysTime.Enabled = true;
            sysTime.Tick +=new EventHandler(sysTime_Tick);
            time.Enabled = true;
            time.Start();
        }

        private void sysTime_Tick(object sender, EventArgs e)
        {
            pBar.PerformStep();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            time.Enabled = false;
            sysTime.Enabled = false;
            sysTime.Stop();
            time.Stop();
            time.Elapsed -= new ElapsedEventHandler(timed_Tick);
            sysTime.Tick -= new EventHandler(sysTime_Tick);
            pBar.Value = 1;
        }

        private void FormUpdatePages()
        {
            lock (this)
            {
                //int i = int.Parse(pagerCountLabel.Text.ToString());
                i += 1;
                pagerCountLabel.Text = i.ToString();
                pBar.Value = 1;
            }
        }

        //************ Below is code that runs as a thread instantiated by the timer event *****************

        public void PortCalls(string name)
        {
            SerialPort port = null;
            try
            {
                port = new SerialPort(name);
                port.BaudRate = 9600;
                port.Encoding = Encoding.ASCII;
                port.Open();
                port.Write("PPG,1,0A,5!4\r");
                port.ReadLine();
                port.NewLine = "\n";
                port.Close();
                port.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        delegate void ComPortSelectorDelegate();

        public void SwitchThreads()
        {
            if (comPortForm.InvokeRequired)
            {
                comPortForm.BeginInvoke(new ComPortSelectorDelegate(SwitchThreads), new object[] { });
                return;
            }
            comPortForm.FormUpdatePages();
        }

        private void timed_Tick(object sender, ElapsedEventArgs e)
        {
            PortCalls(selectedComPort);
            SwitchThreads();
        }
    }
}
