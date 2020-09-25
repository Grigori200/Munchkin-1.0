using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Munchkin.Server
{
    //Klasa reprezentująca klienta TCP

    class Client
    {
        TcpClient client;
        public string IP { get; private set; }

        public Client(string IP)
        {
            this.IP = IP;
            client = new TcpClient(IP, 9999);
            client.SendBufferSize = 1024;
            client.ReceiveBufferSize = 1024;
            Thread t = new Thread(ListenToServer);
            t.Name = "ClientListenThread";
            t.Start();
        }

        //Metoda wysyłająca wiadomość
        public void SendMessage(TcpClient client, string message)
        {
            Communication.SendMessage(client, message);
        }

        //Metoda nasłuchująca wiadomości
        private void ListenToServer()
        {
            Communication.ListenToMessages(client);
        }

        //Metoda zamykająca klienta
        public void CloseClient()
        {
            client.Close();
            client.Dispose();
        }
    }
}
