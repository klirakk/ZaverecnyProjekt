using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ZaverecnyProjekt
{
    private class Hra
    {
        public int SkoreHrac { get; set; } = 0;
        public int SkoreNepritel { get; set; } = 0;
    }
    public static void Main()
    {
        var random = new Random();
        var hra = new Hra();

        while (true)
        {
            if (hra.SkoreHrac == 5 || hra.SkoreNepritel == 5) break;

            Console.WriteLine("Pojď hrát kámen, nůžky, papír");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("vyber jednu z možností (K)ámen, (N)ůžky, (P)apír");
            string HracVolba = Console.ReadLine();
            int computerChoice = random.Next(0, 3);

            if ((HracVolba == "K" && computerChoice == 3) ||
                      (HracVolba == "P" && computerChoice == 1) ||
                      (HracVolba == "N" && computerChoice == 2))
            {
                Console.WriteLine("Vyhrál jsi!");
                hra.SkoreHrac++;
                Console.WriteLine($"Hráč skóre: {hra.SkoreHrac}\nHráč cpu: {hra.SkoreNepritel}");
            }
            else if ((HracVolba == "K" && computerChoice == 2) ||
                     (HracVolba == "P" && computerChoice == 3) ||
                     (HracVolba == "N" && computerChoice == 1))
            {
                Console.WriteLine("CPU Výhra!");
                hra.SkoreNepritel++;
                Console.WriteLine($"Hráč skóre: {hra.SkoreHrac}\nHráč cpu: {hra.SkoreNepritel}");

            }
            else
            {
                Console.WriteLine("Remíza!");
                hra.SkoreNepritel++;
                hra.SkoreHrac++;
                Console.WriteLine($"Hráč skóre: {hra.SkoreHrac}\nHráč cpu: {hra.SkoreNepritel}");
            }
            if (hra.SkoreHrac == 5)
            {
                Console.WriteLine("Vyhrál jsi!");
            }
            else if (hra.SkoreNepritel == 5)
            {
                Console.WriteLine("Prohrál jsi :C");
            }




        }
    }
      
}


