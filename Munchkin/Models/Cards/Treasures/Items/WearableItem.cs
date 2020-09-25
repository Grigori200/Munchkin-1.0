using System;
using System.Collections.Generic;
using System.Text;
using Munchkin.Enums;

namespace Munchkin.Models.Cards.Treasures.Items
{
    //Klasa ta reprezentuje przedmiot, który przyznaje pasywny bonus.
    class WearableItem: Item
    {
        public bool IsBig { get; private set; }

        public Locations LocationType {get; private set;}

        public WearableItem(Guid CardID, string Name, string Text, string EnterName, string LeaveName, int Value, string UseName, Locations LocationType, bool IsBig) :
            base(CardID, Name, Text, EnterName, LeaveName, Value, UseName)
        {
            this.LocationType = LocationType;
            this.IsBig = IsBig;
        }

        public WearableItem(Guid CardID, string Name, string Text, string EnterName, string LeaveName, int Value, string UseName) :
            this(CardID, Name, Text, EnterName, LeaveName, Value, UseName, 0, false)
        { }

        public WearableItem(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName", 0, "DefaultUseName")
        { }

        public WearableItem(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public WearableItem(Guid CardID) : this(CardID, "DefaultCardName")
        { }
    }
}
