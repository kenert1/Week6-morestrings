using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu "n" tähte on
            //lauses "Don't panic"

            string dontpanic = "Don't panic";
            int counter = 0;
            foreach(char character in dontpanic)
            {
                if (character == 'n')
                {
                    counter++;
                }
                  
            }
            Console.WriteLine($"Lauses {dontpanic} on {counter} N-tähte.");

        }
    }
}
