using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using PlayerLib;

namespace BasicUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ready to write UDP message");
                string message = Console.ReadLine();

                UdpClient socket = new UdpClient();
                SendData(socket, message);
                Thread.Sleep(4000);
            }
        }

        public static void SendData(UdpClient socket, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            socket.Send(data, data.Length, "255.255.255.255", 6000);
        }
    }
}
