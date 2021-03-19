using System;
using Heritage_Batiments.Classes;

namespace Heritage_Batiments
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment batiment1 = new Batiment("96 Jacques-Cartier", 3500, 3);
            Console.WriteLine(batiment1);
            Maison maison1 = new Maison("14 Adams", 850, 2, 4, "brique");
            Console.WriteLine(maison1);
            Entrepot entrepot1 = new Entrepot("123 boul. Industriel", 15000, 1, 8);
            Console.WriteLine(entrepot1);
        }
    }
}
