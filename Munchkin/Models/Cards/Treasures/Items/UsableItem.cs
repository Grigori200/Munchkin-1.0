using System;
using System.Collections.Generic;
using System.Text;

namespace Munchkin.Models.Cards.Treasures.Items
{
    //Klasa ta reprezentuje przedmiot, którego można użyć.

    class UsableItem: Item
    {
        public UsableItem(Guid CardID, string Name, string Text, string EnterName, string LeaveName, int Value, string UseName) :
            base(CardID, Name, Text, EnterName, LeaveName, Value, UseName)
        { }

        public UsableItem(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName", 0, "DefaultUseName")
        { }

        public UsableItem(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public UsableItem(Guid CardID) : this(CardID, "DefaultCardName")
        { }
    }
}
