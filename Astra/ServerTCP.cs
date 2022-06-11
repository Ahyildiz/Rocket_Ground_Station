using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApp1
{
    class ServerTCP
    {
        static void Send_message(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("10.70.21.179"), 4158);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Connect(ipep);
            server.Send(data, data.Length, SocketFlags.None);
            server.Close();
        }
    }
}