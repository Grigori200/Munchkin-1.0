using Munchkin.Models.Cards.CardsInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Munchkin.Enums;
using Munchkin.Delegates;
using Munchkin.Models;

namespace Munchkin.Models.Cards.Doors
{
    //Klasa reprezentująca kartę Rasy.
    //Jest permanentem i przyznaje graczowi, który ją zagrał, odpowiednią rasę.
    //Gracz może posiadać na raz tylko jedną kartę rasy w stole, chyba że ma kartę pozwalającą nagiąć tą zasadę.

    class Race: Door, IPermanent
    {
        public Races RaceType { get; private set; }

        //Podczas wprowadzania nazw metod karty, natychmiast przekazywane jest do delegata odpowiednie odwołanie do metody.
        //Dotyczy to Use

        [NonSerialized]
        private Executable Use;

        protected string useName;
        public string UseName
        {
            get
            {
                return useName;
            }
            set
            {
                useName = value;
                Use = CardMenager.GenerateMethod(useName);
            }
        }

        public Race(Guid CardID, string Name, string Text, string EnterName, string LeaveName, Races RaceType, string UseName) :
            base(CardID, Name, Text, EnterName, LeaveName)
        {
            this.UseName = UseName;
            this.RaceType = RaceType;
        }

        public Race(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName", 0, "DefaultUseName")
        { }

        public Race(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Race(Guid CardID) : this(CardID, "DefaultCardName")
        { }

        public void LeaveBattlefield(Player player)
        {
            Leave(this, player);
            throw new NotImplementedException();
        }

        public void PlayPermanent(Player player)
        {
            Enter(this, player);
            throw new NotImplementedException();
        }

        public void UseAbility(Player player)
        {
            Use(this, player);
            throw new NotImplementedException();
        }
    }
}
