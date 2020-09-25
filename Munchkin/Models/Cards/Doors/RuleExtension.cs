using Munchkin.Delegates;
using Munchkin.Models;
using Munchkin.Models.Cards.CardsInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Munchkin.Models.Cards.Doors
{
    //Klasa ta reprezentuje kartę pozwalającą nagiąć zasady rozgrywki.
    //Jest permanentem.

    class RuleExtension: Door, IPermanent
    {
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

        public RuleExtension(Guid CardID, string Name, string Text, string EnterName, string LeaveName, string UseName) :
            base(CardID, Name, Text, EnterName, LeaveName)
        {
            this.UseName = UseName;
        }

        public RuleExtension(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName", "DefaultUseName")
        { }

        public RuleExtension(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public RuleExtension(Guid CardID) : this(CardID, "DefaultCardName")
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
