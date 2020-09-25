using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Munchkin.Models;

namespace Munchkin.Contexts
{

    //Klasa ta stanowi kontekst dla Entity Framework'u - Pozwala na połączenie się z bazą danych.
    //Karty do bazy danych dodajemy metodą .Cards.Add(). Po wykonaniu każdej zmiany w bazie danych musimy wywołać metodę .SaveChanges() .
    //Do poprawnego działania DBContext, po którym dziedziczy CardsDBContext, wymagane jest określenie connectionString w App.config (Nie jest to jedyna opcja).
    class CardsDBContext : DbContext
    {
        //Konstruktor wywołuje konstruktor podstawowy DbContext, przekazując mu nazwę używanego ConnectionString.
        //W przypadku braku istaniejącej bazy danych na danej jednostce, tworzy on nową i uzupełnia ją o brakujące karty.
        public CardsDBContext(): base("name=CardsDBContext")
        {
            Database.SetInitializer<CardsDBContext>(new CreateDatabaseIfNotExists<CardsDBContext>());
            if (!Database.Exists())
                this.Cards.AddRange(CardMenager.GetListOfCards());
            this.SaveChanges();
        }

        //Właściwość Cards reprezentuje naszą bazę danych.
        //Za pośrednictwem tej właściwości możemy pobierać karty z bazy danych, dodawać je i usuwać.
        //Po wprowadzeniu każdej zmiany do bazy danych należy wywołać metodę DbContext - SaveChanges().
        //https://docs.microsoft.com/en-us/dotnet/api/system.data.entity.dbset?view=entity-framework-6.2.0
        //https://docs.microsoft.com/en-us/dotnet/api/system.data.entity.dbcontext?view=entity-framework-6.2.0

        public DbSet<Card> Cards { get; set; }
    }
}
