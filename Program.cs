using System;

namespace confused
{
    class Program
    {
        static void Main(string[] args)
        {
            int password, ciones, citens, cithousands, fb1, fb2, fb3, nsa1, nsa2, nsa3;
            string orga;
            Console.Write("Enter your Organization:");
            orga = Console.ReadLine();

            Console.Write("Enter your password:");
            password = int.Parse(Console.ReadLine());

            if (orga == "CIA")
            {
                ciones = password % 10;
                if (ciones % 3 == 0)
                {
                    citens = password / 10;

                    if (citens % 10 != 1 && citens % 10 != 3 && citens % 10 != 5)
                    {
                        cithousands = password / 1000;
                        if (cithousands % 10 == 6 || cithousands % 10 == 7)
                        {
                            Console.WriteLine(true);
                        }
                        else
                            Console.WriteLine(false);

                    }
                    else
                        Console.WriteLine(false);

                }
                else
                    Console.WriteLine(false);
            }
    }
}
