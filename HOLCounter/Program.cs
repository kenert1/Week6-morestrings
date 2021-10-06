using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h','o'   
            //ja 'l' tähte on lauses "Hello, world!"

            string hworld = "Hello, World".ToLower();
            int counterH = 0;
            int counterO = 0;
            int counterL = 0;

            foreach (char character in hworld)
            {
                if (character == 'h')
                {
                    counterH++;
                }
                else if (character == '0')
                {
                    counterO++;
                }
                else if (character == 'l')
                {
                    counterL++;
                }



            }
            Console.WriteLine($"lauses {hworld} on {counterH} H-tähte {counterO} O-tähte{counterL} L-tähte.");
        }

    }
}
