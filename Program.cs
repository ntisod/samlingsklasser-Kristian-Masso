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
            //Skapar en lista som heter "övning2" och som har värdet double
            List<double> övning2 = new List<double>();

            //Skapar en for metod som gör att programmet innanför den skall upprepas
            for (int i = 0; i < 1000000000; i++)
            {
                //Frågar användaren om värdet på talet som han/hon skall mata in
                Console.Write("Skriv in ett tal: ");
                //Omvandlar svaret från användaren, från string till double
                double tal = double.Parse(Console.ReadLine());
                //använder mig av if eftersom det skall finnas ett villkor om användaren trycker in talet 0
                if (tal == 0)
                {
                    //Denna rad gör att programmet stängs ner när man matar in 0
                    Environment.Exit(1);
                }
                //Annars, ifall man sätter in andra värden än 0 då skall programmet innanför else satsen köras
                else
                {
                    //Denna rad gör att talet som blev inmatad av användaren skall lägga till i listan som vi har skapat.
                    övning2.Add(tal);
                    //Denna rad skriver ut svaret av själva programmet. Programmet skall skriva ut medelvärdet av talen i listan. 
                    Console.WriteLine("Medelvärdet blir: " + övning2.Average());
                }
            }
        }
    }
}
