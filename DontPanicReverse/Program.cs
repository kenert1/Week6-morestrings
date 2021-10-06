using System;

namespace DontPanicReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Don't panic"
            //läbiva suuretähega ja tagurpidi

            string dontpanic = "Don't panic".ToUpper();
            for (int i = dontpanic.Length - 1; i >= 0; i--)
                Console.Write(dontpanic [i]);

           


        }
    }
}
