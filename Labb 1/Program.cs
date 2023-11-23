using System.Reflection.Metadata;


namespace labb1
{
    
    internal class Program
    {
        // programmet börjar här
        static void Main(string[] args)
        {
            // Ber användaren att ange namnet på person 1
            Console.WriteLine("Skriv namnet på person 1:");
            // Läs inmatningen och lagra den i variabeln username1
            string username1 = Console.ReadLine();

            // Ber användaren att ange åldern på person 1
            Console.WriteLine("Skriv åldern på person 1:");
            // Läs inmatningen, konvertera den till ett heltal och lagra den i variabeln age1
            int age1 = Convert.ToInt32(Console.ReadLine());

            // Upprepar samma process för person 2
            Console.WriteLine("Skriv namnet på person 2:");
            string username2 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 2:");
            int age2 = Convert.ToInt32(Console.ReadLine());

            // Upprepar samma process för person 3
            Console.WriteLine("Skriv namnet på person 3");
            string username3 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 3:");
            int age3 = Convert.ToInt32(Console.ReadLine());

            // Upprepar samma process för person 4
            Console.WriteLine("Skriv namnet på person 4");
            string username4 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 4:");
            int age4 = Convert.ToInt32(Console.ReadLine());

            // Visa informationen för varje person
            Console.WriteLine(username1 + " är " + age1 + " år gammal");
            Console.WriteLine(username2 + " är " + age2 + " år gammal");
            Console.WriteLine(username3 + " är " + age3 + " år gammal");
            Console.WriteLine(username4 + " är " + age4 + " år gammal");

            // Beräkna den totala åldern
            int totalage = age1 + age2 + age3 + age4;
            // Visa den totala åldern
            Console.WriteLine("Sammanlagda åldern är: " + totalage);

            // Beräkna medelåldern som en double
            double average = (double)totalage / 4;
            // Formatera medelåldern för att visa två decimaler
            string deci = average.ToString("0.00");
            // Visa medelåldern
            Console.WriteLine("Medelåldern är: " + deci);
        }
    }
}
