using System;

namespace TehtavaB7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pyydetään käyttäjältä x ja y arvot
            Console.Write("Syötä x-arvo: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Syötä y-arvo: ");
            int y = int.Parse(Console.ReadLine());

            // Suoritetaan laskutoimitus x += y
            x += y;

            // Tulostetaan tulos
            Console.WriteLine("x = " + x);
        }
    }
}


