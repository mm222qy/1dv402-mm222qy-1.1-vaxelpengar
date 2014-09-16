using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Växelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = 0;
            int givenCsh = 0;
            double total = 0;
            double RoundingOffAmnt = 0;
            int amount = 0;
            Console.Write("Ange totalsumma       :  ");
            cost = double.Parse(Console.ReadLine());

            Console.Write("Ange erhållet belopp  :  ");
            givenCsh = int.Parse(Console.ReadLine());
            
            total = (uint)Math.Round(cost);
            RoundingOffAmnt = total - cost;

            Console.WriteLine("KVITTO");
            Console.WriteLine("_____________________________");
            Console.WriteLine("Totalt                :  {0} kr", cost);
            Console.WriteLine("Öresavundning         :   {0:f2} kr", RoundingOffAmnt);
            cost = (int)cost / 1;

            Console.WriteLine("Att betala            :     {0} kr", cost);
            Console.WriteLine("Kontant               :  {0:f1} kr", givenCsh);
            givenCsh -= (int)cost;
            Console.WriteLine("Tillbaka              :     {0} kr", givenCsh);
            Console.WriteLine("_____________________________");
            
            if (givenCsh >= 500)
            {
            Console.WriteLine("500-Lappar            :    {0}  ", (givenCsh/500));
            givenCsh %= 500;
            }

            if (givenCsh >= 100)
            {
                Console.WriteLine("100-Lappar            :    {0}  ", (givenCsh / 100));
                givenCsh %= 100;
            }
            if (givenCsh >= 50)
            {
                Console.WriteLine("50-Lappar             :    {0}  ", (givenCsh / 50));
                givenCsh %= 50;
            }
            if (givenCsh >= 20)
            {
                Console.WriteLine("20-Lappar             :    {0}  ", (givenCsh / 20));
                givenCsh %=20;
            }
            if (givenCsh >= 10)
            {
                Console.WriteLine("10-Kronor             :    {0}  ", (givenCsh / 10));
                givenCsh %= 10;
            }
            if (givenCsh >= 5)
            {
                Console.WriteLine("5-Kronor              :    {0}  ", (givenCsh / 5));
                givenCsh %= 5;
            }
            if (givenCsh >= 1)
            {
                Console.WriteLine("1-Kronor              :    {0}  ", (givenCsh / 1));
                
            }


        }
    }
}
