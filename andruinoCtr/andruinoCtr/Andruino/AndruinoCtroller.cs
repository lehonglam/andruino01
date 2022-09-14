using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andruinoCtr.Andruino
{

    class AndruinoCtroller
    {
        public int XPIN { get; set; } = 2;

        public bool isConnected { get; set; }= false;
        public string serialPortsName { get; set; }="";
        SerialPort port;

        private void connectToArduino(string selectedPort)
        {
            serialPortsName = selectedPort;
            port = new SerialPort(serialPortsName, 9600, Parity.None, 8, StopBits.One);
            try
            {
                port.Open();
                isConnected = true;
            }
            catch (Exception ex)
            {
                isConnected = false;
            }
        }
        private void disconnectFromArduino()
        {
            try
            {
                port.Close();
                isConnected = false;
            }
            catch (Exception ex)
            {
            }
        }
        public void writeCommand(string command)
        {
            if (isConnected)
            {
               port.Write(command);
            }
        }

    }
}
