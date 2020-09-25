using System;
using System.Collections.Generic;
using System.Text;
using Munchkin.Models;

namespace Munchkin.Delegates
{
    //Jest to delegat przeznaczony dla metod wywoływanych na skutek interakcji z różnymi kartami.

    //https://docs.microsoft.com/pl-pl/dotnet/csharp/programming-guide/delegates/
    //https://docs.microsoft.com/pl-pl/dotnet/csharp/programming-guide/delegates/using-delegates

    public delegate void Executable(Card card, Player player);
}
