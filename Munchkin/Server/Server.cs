using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Munchkin.Server
{
    //Klasa reprezentująca serwer TCP.

    class Server
    {
        List<TcpClient> clients = new List<TcpClient>();

        TcpListener listener = new TcpListener(IPAddress.Any, 9999);

        bool isListening;

        //Uruchamianie serwera
        public void ServerStart()
        {
            isListening = true;
            listener.Start();
            AcceptConnection();
        }

        //Asynchroniczne akceptowanie połączeń klientów.
        private void AcceptConnection()
        {
            //System.InvalidOperationException
            listener.BeginAcceptTcpClient(HandleConnection, listener);
        }

        //Ustawianie szczegółów połączenia z nowo połączonym klientem i rozpoczynanie nasłuchiwania go na nowym wątku.
        private void HandleConnection(IAsyncResult result)
        {
            if(isListening)
            {
                AcceptConnection();
                TcpClient client = listener.EndAcceptTcpClient(result);
                clients.Add(client);
                
                client.ReceiveBufferSize = 1024;
                client.SendBufferSize = 1024;
                Thread t = new Thread(ListenToClient);
                t.Name = "ServerListenThread";
                t.Start(client);
            }
        }

        //Nasłuchiwanie wiadomości od klienta
        private void ListenToClient(object tmpClient)
        {
            Communication.ListenToMessages((TcpClient)tmpClient);
        }

        //Wysyłanie wiadomości do klienta
        public void SendMessage(TcpClient client, string message)
        {
            Communication.SendMessage(client, message);
        }

        //Zamykanie serwera.
        public void CloseServer()
        {
            foreach(TcpClient client in clients)
            {
                client.Close();
                client.Dispose();
            }
            clients.Clear();
            isListening = false;
            listener.Stop();
        }
    }
}
