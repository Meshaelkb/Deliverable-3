// Programmer: Meshael Albulaihed
// assignement: Deliverable 3
// date: 09/08/2022



using System.Linq.Expressions;

namespace Deliverable_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Enter an integar number between 0 and 100");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose odd or even number:");
                string series_name = Console.ReadLine();

                if ((x > 0) && (x <= 100))
                {
                    if (series_name == "even")
                    {
                        int i = 1;
                        int even = 0;
                        do
                        {

                            Console.WriteLine(even.ToString() + " is an even number");
                            even = 2 * i;
                            i++;
                        }
                        while (even < x);
                    }

                    else if (series_name == "odd")
                    {
                        int i = 1;
                        int odd = 0;
                        do
                        {

                            Console.WriteLine(odd.ToString() + " is an odd number");
                            odd = 2 * i + 1;
                            i++;
                        }
                        while (odd < x);

                    }
                    else
                    {
                        Console.WriteLine("Select an option between even and odd");
                    }
                }
                else
                {
                    Console.WriteLine("Try an integer number between 1 and 100");
                }
            }
            catch
            {
                Console.WriteLine("please try again");
                Console.ReadKey(true);

            }


        }
    }
}
