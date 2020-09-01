/* om Ålder >17 och location == "Krongen" OCH om leg == "J" OCH promille < 1.o JA
 * om ålder >19 och location == "Systemet" OCH om leg == "J" OCH promille <1.0 JA
 */
using System;
using System.Data.Common;

namespace CanIBuyBeer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" GIT");

            Console.WriteLine("Hur gammal är du:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("system eller krongen");
            string location = Console.ReadLine();
            location = location.ToLower();

            Console.WriteLine("Har du legg med dig (J/N):");
            string legg = Console.ReadLine();

            Console.Write("Vilken promillehat:");
            decimal promille = Convert.ToDecimal(Console.ReadLine());

           /* if (age > 17 && location == "krongen" && legg == "J" && promille < 1.0m)
                Console.WriteLine("Japp du får köppa öl");
            else if (age > 19 && location == "systemet" && legg == "J" && promille < 1.0m)
                Console.WriteLine("Jagåå du får köppa öl");
           */
            bool canIBuyBeer = false;
            if (legg == "J" && promille < 1.0m)
             {
                if (location == "Krongen" && age > 17)
                    // stoppa in True i lådan
                {
                CanIBuyBeer = true;
            // stopa in TRUE i lådan
                }
           
                else if (location == "systemet" && age > 19)
                {
                    CanIBuyBeer = true;
                }
                    {
                else
                 }
                  
                   //stoppa in FALSE i låda
                      }
        }
    }