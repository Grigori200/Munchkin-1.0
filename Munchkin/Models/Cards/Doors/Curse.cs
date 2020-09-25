using System;
using System.Collections.Generic;
using System.Text;
using Munchkin.Models;
using Munchkin.Models.Cards.CardsInterfaces;

namespace Munchkin.Models.Cards.Doors
{
    //Klasa reprezentująca kartę klątwy.
    //Jest zagrywana natyczmiast po ujawnieniu jej przez gracza podczas fazy pierwszego eksplorowania drzwi.
    //Istnieją efekty które chronią przed ich działaniem.
    class Curse : Door, ISpell
    {
        public Curse(Guid CardID, string Name, string Text, string EnterName, string LeaveName) :
            base(CardID, Name, Text, EnterName, LeaveName)
        { }

        public Curse(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName")
        { }

        public Curse(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Curse(Guid CardID) : this(CardID, "DefaultCardName")
        { }

        //Metoda zagrania karty

        public void Cast(Player player)
        {
            Enter(this, player);
            Leave(this, player);
            throw new NotImplementedException();
        }
    }
}
