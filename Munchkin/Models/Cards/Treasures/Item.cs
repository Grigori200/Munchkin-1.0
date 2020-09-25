using Munchkin.Delegates;
using Munchkin.Models;
using Munchkin.Models.Cards.CardsInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Munchkin.Models.Cards.Treasures
{
    //Klasa reprezentująca kartę Przedmiotu.
    //Jest permanentem.
    //Ma wartość, przez co gracz może ją sprzedać w zamian za złoto.

    abstract class Item: Treasure, IPermanent
    {
        public int Value { get; protected set; }

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

        public Item(Guid CardID, string Name, string Text, string EnterName, string LeaveName, int Value, string UseName) :
            base(CardID, Name, Text, EnterName, LeaveName)
        {
            this.UseName = UseName;
            this.Value = Value;
        }

        public Item(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName", 0, "DefaultUseName")
        { }

        public Item(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Item(Guid CardID) : this(CardID, "DefaultCardName")
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
