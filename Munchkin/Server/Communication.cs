using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Munchkin.Server
{
    //Klasa statyczna Communications zawiera metody wysyłania wiadomości jak i nasłuchiwania przychodzących wiadomości.
    //Metody te mogą być wykorzystywane zarówno przezserwer jak i klienta.
    static class Communication
    {
        //Metoda wysyłania wiadomości
        public static void SendMessage(TcpClient client, string message)
        {
            NetworkStream ns = client.GetStream();
            byte[] bytes = ASCIIEncoding.ASCII.GetBytes(message);
            ns.Write(bytes, 0, bytes.Length);
        }

        //Metoda nasłuchiwania na przychodzące wiadomości. Musi zostać odpalona na osobnym wątku, gdyż zawiera niemal nieskończoną pętlę.
        public static void ListenToMessages(TcpClient client)
        {
            string str;
            using (NetworkStream ns = client.GetStream())
            {
                try
                {
                    while (client.Connected)
                    {
                        byte[] data = new byte[client.ReceiveBufferSize];
                        using (MemoryStream ms = new MemoryStream())
                        {
                            int numBytesRead;
                            while (ns.DataAvailable)
                            {
                                numBytesRead = ns.Read(data, 0, data.Length);
                                ms.Write(data, 0, numBytesRead);
                            }
                            if (ms.Length > 0)
                            {
                                //str = Encoding.ASCII.GetString(ms.ToArray(), 0, (int)ms.Length);
                                //TODO: Handle Data
                            }
                        }
                    }
                }
                catch (ObjectDisposedException ex)
                {

                }
            }
        }

    }
}
