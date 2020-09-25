using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Munchkin.Server;
using Munchkin.Contexts;
using Munchkin.Models;
using Munchkin.Models.Cards.Doors;
using Munchkin.Models.Cards.Treasures;
using Munchkin.Models.Cards.Treasures.Items;
using System.Text.RegularExpressions;
using System.Net.Sockets;

namespace Munchkin
{
    //Klasa ta zawiera wszystkie metody używane przez aplikację okienkową.
    //Stwożona jest, aby zachować porządek w klasie samego okna i pozwolić, aby cała logika odbywała się poza nią, czasem nawet na osobnych wątkach.
    //Reprezentuje poniekąd Menu Gry i wszystkie dane jakie powinno ono posiadać.

    static class WindowMenager
    {
        //Formuła regex do weryfikowania, czy podany tekst jest IP
        //https://docs.microsoft.com/pl-pl/dotnet/api/system.text.regularexpressions.regex?view=netcore-3.1
        //https://regexr.com/

        static Regex IPPattern = new Regex(@"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.|$)){4}\b");

        static public string UserName { get; set; }

        static public CardsDBContext Ctx { get; set; }

        static Client client;

        static Server.Server server = null;

        //Metoda inicjująca bazę danych i ustawiająca domyślną nazwę gracza.
        //Wywoływana podczas odpalenia aplikacji.
        public static void SetDefaultData()
        {
            UserName = "Player";
            Ctx = new CardsDBContext();
        }

        //Metoda uruchamiająca serwer
        public static void StartServer()
        {
            server = new Server.Server();
            server.ServerStart();
        }

        //Metoda uruchamiająca klienta, połączonego z serwerem o danym IP
        public static void StartClient(string IP)
        {
            client = new Client(IP);
        }

        //Metoda zamykająca serwer, wraz z klientem.
        public static void CloseServer()
        {
            CloseClient();
            server.CloseServer();
            server = null;
        }

        //Metoda zamykająca klienta.
        public static void CloseClient()
        {
            client.CloseClient();
            client = null;
        }

        //Metoda sprawdzająca czy klient nadal działa.
        public static bool IsClientRunning()
        {
            return (client != null);
        }

        //Metoda zwracająca IP serwera, do którego jest połączony kliet
        public static string IPOfConnectedServer()
        {
            return client.IP;
        }

        //Metoda zwracająca listę graczy połaczonych z serwerem.
        public static List<Object> GetListOfPlayers()
        {

            //TODO: Implementacja
            throw new NotImplementedException();
        }

        //Metoda sprawdzająca czy podane IP do połącznia z serwerem jest poprawne, tworząca klienta izwracająca odpowiedni komunikat.
        public static string CheckIP(string IP)
        {

            if (WindowMenager.IsClientRunning())
            {
                if (WindowMenager.IPOfConnectedServer() == IP)
                {
                    return "Już połączono z tym serwerem/nOczekiwanie na rozpoczecie gry przez hosta";
                }
            }
            if (WindowMenager.IPPattern.Match(IP).Length > 0)
            {
                try
                {
                    WindowMenager.StartClient(IP);
                    return "Połączono z serwerem";
                }
                catch (SocketException ex)
                {
                    return "Zły serwer";

                }
            }
            else
            {
                return "To nie IP!";
            }
        }
    }
}
