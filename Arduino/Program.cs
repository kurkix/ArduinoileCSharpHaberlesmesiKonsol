using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Arduino
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SerialPort port = new SerialPort();
            port.BaudRate = 9600;
            port.PortName = "COM5";
            ledyak(port);
        }

        public static void ledyak(SerialPort port)
        {
            port.Open();
            port.WriteLine("1");
            port.Close();
        }
        public static void ledsondur(SerialPort port)
        {
            port.Open();
            port.WriteLine("0");
            port.Close();
        }
    }
}
