using Munchkin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Munchkin.Delegates
{
    public static class CardsDelegates
    {
        //Miejsce przeznaczone na metody wszystkich kart, jakie będą przechowywane w bazie danych.
        //Nie jesteśmy niestety w stanie przechować w bazie samych metod, nawet jako delegaty lub metody dynamiczne, więc przekazujemy tylko ich nazwy.
        //Prawdopodobnie możliwe byłoby to przez zapisanie ich w pliku xml jako kod Assembly, ale nie potrafiłem togo zrobić.

        //TODO: Stworzyć metody kart (Jak będzie już wiadomo jak ma działać sama rozgrywka i jak funkcjonuje graficzne jej przedstawienie.

        public static void DefaultEnterName(Card card, Player player)
        {
            
        }

        public static void DefaultLeaveName(Card card, Player player)
        {

        }

        public static void DefaultUseName(Card card, Player player)
        {

        }

        public static void DefaultWinName(Card card, Player player)
        {

        }

        public static void DefaultLoseName(Card card, Player player)
        {

        }
    }
}
