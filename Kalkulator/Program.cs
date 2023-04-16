using System;

    class Kalkulator
    {
        static void Main(string[] args)
        {

        Console.WriteLine("witaj w kalkulatorze dwóch liczb\n \rpodaj pierwszą liczbę ");
        int liczbaA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę");
        int liczbaB = Convert.ToInt32(Console.ReadLine());

        int wynik = 0;

        Console.WriteLine("wybierz jedno z nastepujących działań");
        Console.WriteLine("");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");

        string wybór = Console.ReadLine();

        if (wybór == "1")
        {
            wynik = liczbaA + liczbaB;
            Console.WriteLine("wynik to " + wynik);
        }

        else if (wybór == "2")
        {
            wynik = liczbaA - liczbaB;
            Console.WriteLine("Wynik to " + wynik);
        }
        
        else if (wybór=="3")
        {
            wynik = liczbaA * liczbaB;
            Console.WriteLine("wynik to " + wynik);
        }
        else
        {
            wynik = liczbaA / liczbaB;
            int resztaDzielenie = liczbaA%liczbaB;
            Console.WriteLine("wynik to "+ wynik + " oraz reszta z dzielenia "+ resztaDzielenie);  
        }
    }
    }