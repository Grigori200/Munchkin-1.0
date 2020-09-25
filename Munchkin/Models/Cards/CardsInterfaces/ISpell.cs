using System;
using System.Collections.Generic;
using System.Text;
using Munchkin.Delegates;


namespace Munchkin.Models.Cards.CardsInterfaces
{
    //Interfejs dla kart, które po zagraniu natychmiast schodzą ze stołu.
    interface ISpell
    {
        void Cast(Player player);
    }
}
