using Munchkin.Models;
using Munchkin.Models.Cards.CardsInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Munchkin.Models.Cards.Doors
{
    //Klasa reprezentuje jednorazowe zaklęcia.
    //Ich efekty aktywują się natychmiast po zagraniu

    class Instant: Door, ISpell
    {
        public Instant(Guid CardID, string Name, string Text, string EnterName, string LeaveName) :
            base(CardID, Name, Text, EnterName, LeaveName)
        { }

        public Instant(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName")
        { }

        public Instant(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Instant(Guid CardID) : this(CardID, "DefaultCardName")
        { }

        public void Cast(Player player)
        {
            Enter(this, player);
            Leave(this, player);
            throw new NotImplementedException();
        }
    }
}
