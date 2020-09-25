using System;
using System.Collections.Generic;
using System.Text;
using Munchkin.Delegates;

namespace Munchkin.Models.Cards.CardsInterfaces
{
    //Interfejs dla kart, które po zaraniu pozostają na stole
    interface IPermanent
    {
        void PlayPermanent(Player player);

        void UseAbility(Player player);

        void LeaveBattlefield(Player player);
    }
}
