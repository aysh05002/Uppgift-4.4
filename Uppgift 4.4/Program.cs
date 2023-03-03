using System;

class program
{
    static void Main(string[] args)
    {
        string x = "";
        do
        {
            Console.WriteLine("Välj ett följande alternativ. \n1. Subtrahera ett tal med ett annat" +
                "\n2. Dividera ett tal med ett annat \n3. Avsluta programmet");
            x = Console.ReadLine();
            switch (x)
            {
                case "1":
                    Console.WriteLine("Tal 1");
                    int tal1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tal 2");
                    int tal2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}\n");
                    break;
                case "2":
                    Console.WriteLine("Tal 1");
                    double tal3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Tal 2");
                    double tal4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{tal3} / {tal4} = {tal3 / tal4}\n");
                    break;
                case "3":
                    Console.WriteLine("Programmet avslutas");
                    break;
            }
        } while (x != "3");
    }
}
