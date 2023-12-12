using System;

class Program
{
    static void Main()
    {
        int MaxAntalMedlemmar;
        Console.WriteLine("Hur många familjer finns det?");
        MaxAntalMedlemmar = int.Parse(Console.ReadLine());
        string[] namnLista = new string[MaxAntalMedlemmar];
        int[] alderLista = new int[MaxAntalMedlemmar];
        int antalMedlemmar = 0;

        while (true)
        {
            // Visar huvudmenyn för användaren att välja
            VisaMeny();

            // Läs användarens val från input
            string val = Console.ReadLine();

            // Använd en switch-sats för att navigera baserat på användarens val
            switch (val)
            {
                case "1":
                    // Lägg till en familjemedlem
                    LäggTillFamiljemedlem(namnLista, alderLista, ref antalMedlemmar);
                    break;

                case "2":
                    // Skriv ut alla familjemedlemmar
                    SkrivUtFamiljemedlemmar(namnLista, alderLista, antalMedlemmar);
                    break;

                case "3":
                    // Skriv ut summan av åldrarna
                    SkrivUtSummaAvAldrar(alderLista, antalMedlemmar);
                    break;

                case "4":
                    // Skriv ut medelåldern
                    SkrivUtMedelaldern(alderLista, antalMedlemmar);
                    break;

                case "5":
                    // Avsluta programmet
                    Console.WriteLine("Programmet avslutas. Hej då!");
                    return;

                default:
                    // Visa felmeddelande vid ogiltigt val
                    Console.WriteLine("Ogiltigt val. Försök igen med ett val mellan 1-5.");
                    break;
            }
        }
    }

    static void VisaMeny()
    {
        // Visa huvudmenyn med alternativ för användaren
        Console.WriteLine("\nVälj ett alternativ:");
        Console.WriteLine("1. Lägg till familjemedlem");
        Console.WriteLine("2. Skriv ut alla familjemedlemmar");
        Console.WriteLine("3. Skriv ut summan av åldrarna");
        Console.WriteLine("4. Skriv ut medelåldern");
        Console.WriteLine("5. Avsluta programmet");
        Console.Write("Ange ditt val (1-5): ");
    }

    static void LäggTillFamiljemedlem(string[] namnLista, int[] alderLista, ref int antalMedlemmar)
    {
        // Läs in namn för familjemedlem
        Console.Write("Ange namn för familjemedlem: ");
        string namn = Console.ReadLine();

        // Läs in ålder för familjemedlem med felkontroll
        int alder;
        do
        {
            Console.Write($"Ange ålder för {namn}: ");
        } while (!int.TryParse(Console.ReadLine(), out alder) || alder <= 0);

        // Lägg till familjemedlem i listorna och öka räknaren
        namnLista[antalMedlemmar] = namn;
        alderLista[antalMedlemmar] = alder;
        antalMedlemmar++;
        Console.WriteLine("Familjemedlem har lagts till.");
    }

    static void SkrivUtFamiljemedlemmar(string[] namnLista, int[] alderLista, int antalMedlemmar)
    {
        // Skriv ut alla familjemedlemmar med deras namn och ålder
        Console.WriteLine("\nFamiljemedlemmar:");
        for (int i = 0; i < antalMedlemmar; i++)
        {
            Console.WriteLine($"{namnLista[i]} - {alderLista[i]} år");
        }
    }

    static void SkrivUtSummaAvAldrar(int[] alderLista, int antalMedlemmar)
    {
        // Beräkna och skriv ut summan av åldrarna
        int summaAlder = 0;
        for (int i = 0; i < antalMedlemmar; i++)
        {
            summaAlder += alderLista[i];
        }
        Console.WriteLine($"\nSumman av åldrarna är: {summaAlder} år");
    }

    static void SkrivUtMedelaldern(int[] alderLista, int antalMedlemmar)
    {
        // Beräkna och skriv ut medelåldern, hantera fall där inga medlemmar har lagts till ännu
        if (antalMedlemmar > 0)
        {
            double medelalder = (double)alderLista.Sum() / antalMedlemmar;
            Console.WriteLine($"\nMedelåldern är: {medelalder:F2} år");
        }
        else
        {
            Console.WriteLine("\nInga familjemedlemmar har lagts till ännu.");
        }
    }
}
