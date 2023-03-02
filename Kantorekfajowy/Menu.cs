using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantorekfajowy
{
    public class Menu
    {
        Waluta[] waluty = { new Waluta(1, "Euro", "Euro jest prawnym środkiem płatniczym w 20 państwach tworzących w Unii Europejskiej strefę euro a obejmującą swym obszarem około 341 mln Europejczyków. Waluta euro używana jest także w 11 krajach i terytoriach nienależących do UE.", 1.00), new Waluta(2, "Dolar amerykański", "oficjalna waluta Stanów Zjednoczonych, Portoryko, Mikronezji, Marianów Północnych, Palau, Wysp Marshalla, Panamy, Ekwadoru (od 2000), Salwadoru (od 2001), Timoru Wschodniego, Zimbabwe (od 2009), Turks i Caicos, Bonaire, Saby i Sint Eustatius od 2011 roku. Jeden dolar amerykański dzieli się na sto centów amerykańskich. Zapisuje się go za pomocą symbolu $.", 0.94), new Waluta(3, "Funt brytyjski", "Oficjalną jednostką monetarną w Wielkiej Brytanii jest funt szterling, jego symbol międzynarodowy to GBP. Jeden funt dzieli się na 100 pensów. W obiegu znajdują się monety o nominałach: 1, 2, 5, 10, 20 i 50 pensów oraz 1 i 2 funty. Banknoty znajdujące się w obiegu to: 5, 10, 20 i 50 funtów oraz 1 i 100 funtów tylko w Szkocji.", 1.13), new Waluta(4, "Jen japoński", "Jen japoński to jedna z najważniejszych walut w międzynarodowym systemie walutowym – zajmuje on piąte miejsce w prowadzonych transakcjach międzynarodowych, ustępując tylko dolarowi, euro, funtowi brytyjskiemu i od niedawna chińskiemu juanowi.", 0.0069)};
        public void konwersjaMenu()
        {
            try
            {
                Console.WriteLine("Wybierz walutę do przekonwertowania:");
                for (int i = 0; i < waluty.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + waluty[i].getName());
                }
                var waluta1 = waluty[Convert.ToInt32(Console.ReadLine()) - 1];
                Console.WriteLine("Podaj kwotę: ");
                var kwota = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wybierz walutę do której przekonwertujesz wybraną walutę: ");
                for (int i = 0; i < waluty.Length; i++)
                {
                    if (waluty.GetValue(i) == waluta1)
                    {
                        Console.WriteLine(i + 1 + ". " + waluty[i].getName() + " -- WYBRANA");
                    }
                    else
                    {
                        Console.WriteLine(i + 1 + ". " + waluty[i].getName());
                    }
                }
                var waluta2 = waluty[Convert.ToInt32(Console.ReadLine()) - 1];
                if (waluta2 == waluta1)
                {
                    Console.WriteLine("Po co?");
                    konwersjaMenu();
                }
                else
                {
                    string konwersja = kwota + " " + waluta1.getName() + " to " + Przelicznik.przelicz(waluta1, waluta2, kwota) + " " + waluta2.getName();
                    Console.WriteLine(konwersja);
                    var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    var subPath = Path.Combine(path, "wartosc.txt");
                    File.WriteAllText(subPath, konwersja);
                    Console.WriteLine("Wartość konwersji zapisano w katalogu Dokumenty.");

                }
                menu();
            }catch
            {
                Console.WriteLine("Podano złe dane!");
                konwersjaMenu();
            }

        }

        public void informacjeMenu()
        {
            try
            {
                Console.WriteLine("Wybierz walutę, o której informacje chcesz przeczytać: ");
                for (int i = 0; i < waluty.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + waluty[i].getName());
                }
                Console.WriteLine(waluty[Convert.ToInt32(Console.ReadLine()) - 1].getDescription());
                menu();
            }catch
            {
                Console.WriteLine("Podano złe dane!");
                informacjeMenu();
            }
        }
        public void menu()
        {
            Console.WriteLine("Witaj w Kantorze.\nWybierz opcję:\n1. Przekonwertuj walutę\n2. Poczytaj informacje o walutach\n3. Wyjdź");
            switch (Console.ReadLine())
            {
                case "1":
                    konwersjaMenu();
                    break;
                case "2":
                    informacjeMenu();
                    break;
                case "3":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Niestety nie ma takiej opcji.");
                    menu();
                    break;
            }
        }
    }
}
