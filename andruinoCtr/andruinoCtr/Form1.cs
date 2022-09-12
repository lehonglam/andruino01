using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace andruinoCtr
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }
        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            try
            {
                port.Open();
                port.Write("#STAR\n");
                buttonConnect.Text = "Disconnect";
                enableControls();
            }
            catch(Exception ex)
            {
                isConnected = false;
                MessageBox.Show(ex.Message);
            }
        }
        private void disconnectFromArduino()
        {
            try
            {
                port.Write("#STOP\n");
                port.Close();
                buttonConnect.Text = "Connect";
                disableControls();
                resetDefaults();
                isConnected = false;
            }
            catch (Exception ex)
            {
                isConnected = false;
                MessageBox.Show(ex.Message);
            }

        }
        private void enableControls()
        {
            checkBoxLed1.Enabled = true;
            checkBoxLed2 .Enabled = true;
            checkBoxLed3.Enabled = true;
            buttonWriteLCD.Enabled = true;
            textBox1.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

        }

        private void disableControls()
        {
            checkBoxLed1.Enabled = false;
            checkBoxLed2.Enabled = false;
            checkBoxLed3.Enabled = false;
            buttonWriteLCD.Enabled = false;
            textBox1.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void resetDefaults()
        {
            checkBoxLed1.Checked = false;
            checkBoxLed2.Checked = false;
            checkBoxLed3.Checked = false;
            textBox1.Text = "";

        }

        private void buttonWriteLCD_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#TEXT" + textBox1.Text + "#\n");
            }
        }

        private void checkBoxLed1_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBoxLed1.Checked)
                {
                    port.Write("#LED1ON\n");
                }
                else
                {
                    port.Write("#LED1OF\n");
                }
            }
        }

        private void checkBoxLed2_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBoxLed2.Checked)
                {
                    port.Write("#LED2ON\n");
                }
                else
                {
                    port.Write("#LED2OF\n");
                }
            }
        }

        private void checkBoxLed3_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBoxLed3.Checked)
                {
                    port.Write("#LED3ON\n");
                }
                else
                {
                    port.Write("#LED3OF\n");
                }
            }
        }
    }
}
