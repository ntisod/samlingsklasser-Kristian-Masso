    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class Program   
    {
        static void Main()
        {
            List<double> övning2 = new List<double>();

            //Skapar en for metod som gör att programmet innanför den skall upprepas
            for (int i = 0; i < 1000000000; i++)
            {
                //Frågar om ett värde
                Console.Write("Skriv in ett tal: ");
                //Omvandlar svaret till double
                double tal = double.Parse(Console.ReadLine());
                //använder if för jag ska ange villkor
                if (tal == 0)
                {
                    //skriver in 0 = programmet stängs av
                    Environment.Exit(1);
                }
                //om man skriver nåt annat än 0 så blir det de här
                else
                {
                    //användares tal läggs in i listan
                    övning2.Add(tal);
                    //skriver ut svaret och medelvärdet på talen från listan
                    Console.WriteLine("Medelvärdet blir: " + övning2.Average());
                }
            }
        }
    }
}
