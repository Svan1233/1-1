using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuric1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcijonalni z = new Funkcijonalni();

            Console.WriteLine("Upisite vrijednost postotka za x objekt: ");
            x.Postotak = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upisite vrijednost postotka za y objekt: ");
            y.Postotak = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upisite vrijednost postotka za z objekt: ");
            z.Postotak = Convert.ToInt32(Console.ReadLine());

            if ((z.Postotak + y.Postotak + x.Postotak) != 100)
            {
                Console.WriteLine("Pogresan unos!");
            }
            else
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najvise se koristi Proceduralni programski jezik.");
                }
                else if (y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najvise se koristi Objektni programski jezik.");
                }
                else 
                {
                    Console.WriteLine("Najvise se koristi Funkcijonalni programski jezik.");
                }
            }


            Console.ReadKey();
        }
    }
}
