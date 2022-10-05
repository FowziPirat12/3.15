using System;


namespace Uppgift_3._15
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar ska du hyra bilen?");
            Console.Write("Svara här: "); int timmar = int.Parse(Console.ReadLine());

            if( timmar  >11)
            {
                Console.WriteLine("Du får tyvär inte hyra bilen mer än 11 timmar");
            }
             
            if (timmar < 12)
            {
                Console.WriteLine("Det kommer att kosta dig" + timmar * 80 + "Koronor");
            }

        }
    }
}