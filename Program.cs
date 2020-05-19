#define exercice1
//#define exercice2
using System;
using Evaluation1.Exercice1;
using Evaluation1.Exercice2;


namespace Evaluation1
{
    class Program
    {
        static void Main(string[] args)
        {

#if exercice1
            double c1 = SansOperateur.fahrenheitToCelsius(86);
            double f1 = SansOperateur.celsiusToFahrenheit(30);
            
            
            AvecOperateur.Celsius c2 = new AvecOperateur.Celsius() { Valeur = 30 };
            AvecOperateur.Fahrenheit f2 = (AvecOperateur.Fahrenheit)c2;
            Console.WriteLine("La valeur de c {0} est convertie en f {1}",c2,f2);
#endif


#if exercice2
            Matrice m1 = new Matrice(3, 3);
            Matrice m2 = new Matrice(3, 3);

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    m1[i, j] = new Random().Next(10, 20);
                }
            }
            Matrice resultat = ~m1;
            Console.WriteLine($"{resultat.affiche()}");

            Console.WriteLine("Hello World!");
#endif
        }
    }
}
