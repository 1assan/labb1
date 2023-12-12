// Program.cs
using System;

namespace labb_3_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar ett person och hårdkoda värden för egenskaperna
            Person person = new Person
            {
                Gender = Gender.Man,
                Hair = new Hair { HairLength = 7, HairColor = "Svart" },
                Birthday = new DateTime(2003, 10, 8),
                EyeColor = "Brun"
            };

            // Skriv ut personens information i punktform
            Console.WriteLine("Personens information:");
            Console.WriteLine($"- Kön: {person.Gender}");
            Console.WriteLine($"- Hårlängd: {person.Hair.HairLength} cm");
            Console.WriteLine($"- Hårfärg: {person.Hair.HairColor}");
            Console.WriteLine($"- Födelsedag: {person.Birthday.ToShortDateString()}");
            Console.WriteLine($"- Ögonfärg: {person.EyeColor}");
        }
    }

    // Enum för personens kön
    public enum Gender
    {
        Kvinna,
        Man,
        IckeBinar,
        Annan
    }

    // Struct för personens hår
    public struct Hair
    {
        public int HairLength; // hårlängd i centimeter
        public string HairColor;
    }

    // Klassen som innehåller data om en person
    public class Person
    {
        public Gender Gender { get; set; }
        public Hair Hair { get; set; }
        public DateTime Birthday { get; set; }
        public string EyeColor { get; set; }
    }
}

