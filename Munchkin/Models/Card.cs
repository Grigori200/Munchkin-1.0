using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Munchkin.Delegates;
using Munchkin.Models;
using System.Reflection.Emit;

namespace Munchkin.Models
{
    //Kalasa abstrakcyjna, reprezentująca poszczególną kartę. Zawiera wszystkie dane jakie zawierać powinna każda karta, bez względu na jej rodzaj.

    public abstract class Card 
    {
        [Key]
        public Guid CardID { get; protected set; }

        public string Name { get; protected set; }

        public string Text { get; protected set; }

        //Podczas wprowadzania nazw metod karty, natychmiast przekazywane jest do delegata odpowiednie odwołanie do metody.
        //Dotyczy to Enter i Leave

        protected string enterName;
        public string EnterName{
            get{
                return enterName;
            }
            set{
                enterName = value;
                Enter = CardMenager.GenerateMethod(enterName);
            }
        }

        protected string leaveName;
        public string LeaveName{
            get{
                return leaveName;
            }
            set{
                leaveName = value;
                Leave = CardMenager.GenerateMethod(leaveName);
            }
        }

        [NonSerialized]
        protected Executable Enter;

        [NonSerialized]
        protected Executable Leave;

        //Wszystkie konstruktory
        public Card(Guid CardID, string Name, string Text, string EnterName, string LeaveName)
        {
            this.CardID = CardID;
            this.Name = Name;
            this.Text = Text;
            this.EnterName = EnterName;
            this.LeaveName = LeaveName;
        }

        public Card(Guid CardID, string Name, string Text): this(CardID, Name, Text, "DefaultEnterName", "DefaultLeaveName")
        { }

        public Card(Guid CardID, string Name) : this(CardID, Name, "DefaultText")
        { }

        public Card(Guid CardID) : this(CardID, "DefaultCardName")
        { }
        
    }
}
