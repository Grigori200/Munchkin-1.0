using Munchkin.Delegates;
using Munchkin.Models;
using Munchkin.Models.Cards.Doors;
using Munchkin.Models.Cards.Treasures;
using Munchkin.Models.Cards.Treasures.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Munchkin
{
    //Klasa ta zawiera wszelkie statyczne metode potrzebne do operowania na kartach

    static class CardMenager
    {
        //Utworzenie metody na podstawie podanej jej nazwy
        public static Executable GenerateMethod(string methodName)
        {
            Type[] types = { typeof(Card), typeof(Player) };
            DynamicMethod Method = new DynamicMethod("CardMethod", null, types, typeof(CardsDelegates).Module);
            ILGenerator il = Method.GetILGenerator(256);
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldarg_1);
            il.EmitCall(OpCodes.Call, typeof(CardsDelegates).GetMethod(methodName, types), null);
            il.Emit(OpCodes.Ret);
            Executable method = (Executable)Method.CreateDelegate(typeof(Executable));
            return (Executable)Method.CreateDelegate(typeof(Executable));

        }

        //Metoda zwracająca wygenerowaną listę kart, podczas tworzenia nowej bazy kart na komputerze.
        public static List<Card> GetListOfCards()
        {
            List<Card> list = new List<Card>();
            Card[] tab = { new Instant(new Guid("00000000-0000-0000-0000-000000000000")), new Monster(new Guid("00000000-0000-0000-0000-000000000001")), new Curse(new Guid("00000000-0000-0000-0000-000000000002")), new Proffesion(new Guid("00000000-0000-0000-0000-000000000003")), new Race(new Guid("00000000-0000-0000-0000-000000000004")), new RuleExtension(new Guid("00000000-0000-0000-0000-000000000005")), new Bonus(new Guid("00000000-0000-0000-0000-000000000006")), new UsableItem(new Guid("00000000-0000-0000-0000-000000000007")), new WearableItem(new Guid("00000000-0000-0000-0000-000000000008")) };
            list.AddRange(tab);
            //TODO: Stworzyć listę kart
            return list;
        }
    }
}
