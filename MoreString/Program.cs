using System;

namespace MoreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            //initsiaalid lõppevad punktiga
            //--> Harry Potter --> H.P.

            Console.WriteLine("Palun sisestada enda eesnimi");
            string userfirstname = Console.ReadLine();
            Console.WriteLine("Palun sisestada enda teinenimi");
            string userlastname = Console.ReadLine();

            Console.WriteLine($"Tere, {userfirstname[0]}. {userlastname[0]}. ");
                            














        }
    }
}
