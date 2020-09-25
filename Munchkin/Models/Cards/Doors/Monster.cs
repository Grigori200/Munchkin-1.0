using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Munchkin.Delegates;
using Munchkin.Models;

namespace Munchkin.Models.Cards.Doors
{
    //Klasa reprezentująca kartę potwora.
    //Po ujawnieniu potwora w fazie pierwszego eksplorowania drzwi, gracz, który go ujawnił, musi stoczyć z nim pojedynek.
    //Potwór po pokonaniu przyzanje graczowi inicjującemu z nim walkę nagrodę w postaci poziomu (nagradza też pomagajce elfy) i przyznaje odpowiednim graczom skarby.

    class Monster : Door
    {
        public int Level { get; private set; }

        public int Treasure { get; private set; }

        public int LevelUp { get; private set; } = 1;

        //Podczas wprowadzania nazw metod karty, natychmiast przekazywane jest do delegata odpowiednie odwołanie do metody.
        //Dotyczy to Win i Lose

        protected string winName;
        public string WinName
        {
            get
            {
                return winName;
            }
            set
            {
                winName = value;
                Win = CardMenager.GenerateMethod(winName);
            }
        }

        [NonSerialized]
        protected Executable Win;

        protected string loseName;
        public string LoseName
        {
            get
            {
                return loseName;
            }
            set
            {
                loseName = value;
                Lose = CardMenager.GenerateMethod(loseName);
            }
        }

        [NonSerialized]
        protected Executable Lose;

        public Monster(Guid CardID, string Name, string Text, string EnterName, string LeaveName, string WinName, string LoseName) :
            base(CardID, Name, Text, EnterName, LeaveName)
        {
            this.WinName = WinName;
            this.LoseName = LoseName;
        }

        public Monster(Guid CardID, string Name, string Text) : this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName", "DefaultWinName", "DefaultLoseName")
        { }

        public Monster(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Monster(Guid CardID) : this(CardID, "DefaultCardName")
        { }

        //Metoda wywoływana na zakończenie walki

        public void EndFight(Player player)
        {
            if(true) //TODO: Walka
            {
                Win(this, player);
            }
            else
            {
                Lose(this, player);
            }
        }

    }
}
