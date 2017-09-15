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
using System.Collections.Concurrent;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();
        Queue<int> X = new Queue<int>();
        Queue<int> Y = new Queue<int>();
        Queue<int> Z = new Queue<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (dropDownBox.SelectedIndex > -1)
            {
                string selected = dropDownBox.SelectedItem.ToString();

                if (gumStick.IsOpen)
                {
                    gumStick.Close();
                    button.Text = "Connect";
                }
                else if (!gumStick.IsOpen)
                {
                    gumStick.PortName = selected;
                    gumStick.Open();
                    button.Text = "Disconnect";
                }
            }
            else
            {
                MessageBox.Show("Please Select a Com Port");
            }
        }

        private void dropDownBox_DropDown(object sender, EventArgs e)
        {
            string[] comPorts = SerialPort.GetPortNames();
            dropDownBox.DataSource = comPorts;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dataQueue.TryDequeue(out int result);

            if (result == 255 && dataQueue.Count > 3)
            {
                dataQueue.TryDequeue(out int X);
                dataQueue.TryDequeue(out int Y);
                dataQueue.TryDequeue(out int Z);
                txtXAxis.Text = X.ToString();
                txtYAxis.Text = Y.ToString();
                txtZAxis.Text = Z.ToString();
            }
        }

        private void gumStick_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bufferSize = gumStick.BytesToRead;

            for (int i = 0; i < bufferSize; i++)
            {
                int temp = gumStick.ReadByte();
                dataQueue.Enqueue(temp);
            }
        }
    }
}
