using Munchkin.Models;
using Munchkin.Models.Cards.CardsInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Munchkin.Models.Cards.Treasures
{
    //Klasa reprezentująca kartę bonusu.
    //Po zagraniu przyznaje zagrywającemu ją graczowi poziom.
    //Czasem zagrywający musi spełniać określony warunek, by zadziałała.
    class Bonus: Treasure, ISpell
    {
        public Bonus(Guid CardID, string Name, string Text, string EnterName, string LeaveName) :
            base(CardID, Name, Text, EnterName, LeaveName)
        { }

        public Bonus(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName")
        { }

        public Bonus(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Bonus(Guid CardID) : this(CardID, "DefaultCardName")
        { }

        public void Cast(Player player)
        {
            Enter(this, player);
            Leave(this, player);
            throw new NotImplementedException();
        }
    }
}
