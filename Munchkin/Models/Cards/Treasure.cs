using System;
using System.Collections.Generic;
using System.Text;

namespace Munchkin.Models.Cards
{
    //Klasa ta reprezentuje kartę Skarbu, dobieraną ze stosu kart skarbów.

    abstract class Treasure: Card
    {
        public Treasure(Guid CardID, string Name, string Text, string EnterName, string LeaveName) :
            base(CardID, Name, Text, EnterName, LeaveName){ }

        public Treasure(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName")
        { }

        public Treasure(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Treasure(Guid CardID) : this(CardID, "DefaultCardName")
        { }
    }
}
