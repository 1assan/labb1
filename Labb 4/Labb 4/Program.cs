using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        bool fortsättProgram = true;

        while (fortsättProgram)
        {
            VisaMeny();
            int val = HämtaMenyVal();

            switch (val)
            {
                case 1:
                    LäggTillPerson(persons);
                    break;
                case 2:
                    ListaPersoner(persons);
                    break;
                case 3:
                    fortsättProgram = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }

    static void VisaMeny()
    {
        Console.WriteLine("1. Lägg till person");
        Console.WriteLine("2. Lista personer");
        Console.WriteLine("3. Avsluta programmet");
    }

    static int HämtaMenyVal()
    {
        Console.Write("Vänligen välj ett alternativ (1-3): ");
        int val;

        while (!int.TryParse(Console.ReadLine(), out val) || val < 1 || val > 3)
        {
            Console.WriteLine("Ogiltig inmatning. Försök igen.");
            Console.Write("Vänligen välj ett alternativ (1-3): ");
        }

        return val;
    }

    static void LäggTillPerson(List<Person> persons)
    {
        Console.WriteLine("\nVälj kön:");
        Console.WriteLine("1. Kvinna");
        Console.WriteLine("2. Man");
        Console.WriteLine("3. Icke-binär");
        Console.WriteLine("4. Annat");

        Console.Write("Vänligen ange könet (1-4): ");
        if (!int.TryParse(Console.ReadLine(), out int könVal) || könVal < 1 || könVal > 4)
        {
            Console.WriteLine("Ogiltigt könsval. Försök igen...");
            return;
        }

        Gender kön = (Gender)(könVal - 1);

        Console.Write("\nAnge hårfärg: ");
        string hårfärg = Console.ReadLine();

        Console.Write("Ange hårlängd (i cm): ");
        if (!int.TryParse(Console.ReadLine(), out int hårlängd))
        {
            Console.WriteLine("Ogiltig hårlängd. Avslutar...");
            return;
        }

        Console.Write("Ange födelsedatum (ÅÅÅÅ-MM-DD): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime födelsedatum))
        {
            Console.WriteLine("Ogiltigt födelsedatum. Avslutar...");
            return;
        }

        Console.Write("Ange ögonfärg: ");
        string ögonfärg = Console.ReadLine();

        Person nyPerson = new Person
        {
            Gender = kön,
            Hair = new Hair { HairColor = hårfärg, HairLength = hårlängd },
            Birthday = födelsedatum,
            EyeColor = ögonfärg
        };

        persons.Add(nyPerson);

        Console.WriteLine("\nPerson tillagd!\n");
    }

    static void ListaPersoner(List<Person> persons)
    {
        Console.WriteLine("\nLista över personer:");

        if (persons.Count == 0)
        {
            Console.WriteLine("Inga personer tillgängliga ännu.\n");
        }
        else
        {
            foreach (var person in persons)
            {
                Console.WriteLine($"- Kön: {person.Gender}");
                Console.WriteLine($"- Hårfärg: {person.Hair.HairColor}");
                Console.WriteLine($"- Hårlängd: {person.Hair.HairLength} cm");
                Console.WriteLine($"- Födelsedatum: {person.Birthday.ToShortDateString()}");
                Console.WriteLine($"- Ögonfärg: {person.EyeColor}\n");
            }
        }
    }
}