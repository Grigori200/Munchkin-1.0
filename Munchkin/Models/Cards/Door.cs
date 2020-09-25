using System;
using System.Collections.Generic;
using System.Text;

namespace Munchkin.Models.Cards
{
    //Klasa ta reprezentuje kartę Drzwi, dobieraną ze stosu kart drzwi.

    abstract class Door: Card
    {
        public Door(Guid CardID, string Name, string Text, string EnterName, string LeaveName) :
            base(CardID, Name, Text, EnterName, LeaveName){ }

        public Door(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName")
        { }

        public Door(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Door(Guid CardID) : this(CardID, "DefaultCardName")
        { }
    }
}
