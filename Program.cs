using System;

namespace confused
{
    class Program
    {
        static void Main(string[] args)
        {
            int password, cinuai, cisib, ciroi, fbsan, fbroi, fbmuean, nsanuai, nsasib, nsaroi, nsapun, nsamuean, nsasan, nsalan;
            string orga;
            Console.Write("Enter your Organization:");
            orga = Console.ReadLine();


            Console.Write("Enter your password:");
            password = int.Parse(Console.ReadLine());

            if (orga == "CIA")
            {
                cinuai = password % 10;
                if (cinuai % 3 == 0)
                {
                    cisib = password / 10;

                    if (cisib % 10 != 1 && cisib % 10 != 3 && cisib % 10 != 5)
                    {
                        ciroi = password / 1000;
                        if (ciroi % 10 == 6 || ciroi % 10 == 7)
                        {
                            Console.WriteLine("Correct password");
                        }
                        else
                            Console.WriteLine("Login failed");
                    }
                    else
                        Console.WriteLine("Login failed");
                }
                else
                    Console.WriteLine("Login failed");
            }
            else Console.WriteLine("Login failed");

            if (orga == "FBI")
            {
                fbsan = password / 10000;
                fbsan = fbsan % 10;
                if (fbsan == 4 || fbsan == 5 || fbsan == 6 || fbsan == 7)
                {
                    fbroi = password / 100;
                    fbroi = fbroi % 10;
                    fbroi = fbroi / 2;
                    if (fbroi != 6)
                    {
                        fbmuean = password / 10000;
                        fbmuean = fbmuean % 10;
                        if (fbmuean == 1 && fbmuean == 3 && fbmuean == 5 && fbmuean == 7 && fbmuean == 9)
                        {
                            Console.WriteLine("Logged in");
                        }
                    }
                    else Console.WriteLine("Login failed");
                }
                else Console.WriteLine("Login failed");
            }
            else Console.WriteLine("Login failed");

            if (orga == "NSA")
            {
                nsanuai = password % 10;
                nsanuai = 30 / nsanuai;
                if (nsanuai == 30 || nsanuai == 15 || nsanuai == 10 || nsanuai == 6 || nsanuai == 5)
                {
                    nsaroi = password / 100;
                    nsaroi = nsaroi % 10;
                    if (nsaroi == 3 || nsaroi == 9)
                    {
                        nsasib = password
                            nsapun =
                            nsamuean =
                            nsasan =
                            nsalan =
                    }
                }
            }
        }
}
