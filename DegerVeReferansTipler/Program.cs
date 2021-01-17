using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //int, float, decimal, double and bool create a value in "stack" so when we put an equality, first variable only copies the value and nothing else.
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //arrays, classes and interfaces are referance values and new creates an adress in "heap". So when we put an equality between two arrays, first array will shift its adress value to the second one's.
            //Hence when we change the values inside the second array, it will reflect into the first one due to their adresses being same. 
            //After that the first adress becomes redundant and it will be gathered by the garbage collector and thrown out. 
            Console.WriteLine(sayilar1[0]);
        }
    }
}