using Munchkin.Models.Cards.CardsInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Munchkin.Enums;
using Munchkin.Delegates;
using Munchkin.Models;

namespace Munchkin.Models.Cards.Doors
{
    //Klasa reprezentująca kartę Profesji.
    //Jest Permanentem i przyznaje graczowi który ją zagrał profesję.
    //Gracz może posiadać w stole tylko jedną kartę profesji na raz, chyba że ma kartę pozwalającą nagiąć tą zasadę.

    class Proffesion: Door, IPermanent
    {
        public Proffesions ProffesionType { get; private set; }

        //Podczas wprowadzania nazw metod karty, natychmiast przekazywane jest do delegata odpowiednie odwołanie do metody.
        //Dotyczy to Use

        [NonSerialized]
        private Executable Use;

        protected string useName;
        public string UseName{
            get{
                return useName;
            }
            set{
                useName = value;
                Use = CardMenager.GenerateMethod(useName);
            }
        }

        public Proffesion(Guid CardID, string Name, string Text, string EnterName, string LeaveName, Proffesions ProffesionType, string UseName) :
            base(CardID, Name, Text, EnterName, LeaveName)
        {
            this.UseName = UseName;
            this.ProffesionType = ProffesionType;
        }

        public Proffesion(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName", 0, "DefaultUseName")
        { }

        public Proffesion(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Proffesion(Guid CardID) : this(CardID, "DefaultCardName")
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
