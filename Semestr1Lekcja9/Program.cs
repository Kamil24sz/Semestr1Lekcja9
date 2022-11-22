using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1Lekcja9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SKŁADNIA PĘTLI FOR
            //1 - tworzymy zmienną sterującą
            //2 - wyreżenie logiczne - do kiedy pętla ma się wykonywać
            //3 - o ile ma się zwiększać zmienna przy każdym obrocie

            //Ćwiczenie 1
            //wypisz liczby od 1 do 5000 ale podzielne przez 17
            // x++   to to samo co x = x + 1
            Console.WriteLine("Ćwiczenie 1");
            for(int x = 1 ; x <= 5000 ; x++)
            {
                if(x % 17 == 0)   // 3 % 17  r14        19 % 17  r2     17 % 17   r0
                    Console.WriteLine(x);
            }

            Console.WriteLine("Ćwiczenie 2");
            //Ćwiczenie 2
            //Napisz program, który ma obliczać kolejne potęgi liczby 2  (2 do 2 = 4,  2 do 3 = 8)  2^2=4  2^3=8  2^4=16
            Console.WriteLine("Podaj do jakiej potęgi maksymalnie zwiększyć liczbę 2");
            //try catch przechwytuje błędy, jeśli w try wystąpi błąd to wykona się instrukcja z catch
            try
            {
                int maxPotega = int.Parse(Console.ReadLine());
                for (int x = 1; x <= maxPotega; x++)
                {
                    Console.WriteLine($"2 do {x} = {Math.Pow(2, x)} ");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Nie wprowadziłeś poprawnej liczby");
            }

            Console.WriteLine("Ćwiczenie 3");
            //Ćwiczenie 3
            //Piszemy program który wypisze uzupełnioną tabliczkę mnożenia od 1*1 do 9*9
            for(int x = 0; x < 10; x++)
            {
                Console.Write(x + "\t");
                for(int y = 1; y < 10; y++)
                {
                    if(x == 0)
                        Console.Write(y + "\t");
                    else
                        Console.Write(x * y + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
