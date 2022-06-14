using System;

namespace G2_Kamila_Kawiak
{
    public enum KategoriaMuzyki { rock, metal, jazz, soul, pop}
    public class Program
    {
        static void Main(string[] args)
        {
            PlytaAudia p1 = new PlytaAudia("The ", "Jogn", 30.00, "1930", KategoriaMuzyki.jazz);
            PlytaAudia p2 = new PlytaAudia("The Police", "Zenyatta Mondatta", 70.00, "1980", KategoriaMuzyki.rock);
            PlytaAudia p3 = new PlytaAudia("Te ", "ann", 80.00, "1930", KategoriaMuzyki.soul);
            PlytaAudia p4 = new PlytaAudia("koniec ", "Nikk", 23.00, "1930", KategoriaMuzyki.rock);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Plytoteka z = new Plytoteka("tak ", "900456123");
            Console.WriteLine(" ==== Plyty ====");
            z.DodajPlyte(p1);
            z.DodajPlyte(p2);
            z.DodajPlyte(p3);
            z.DodajPlyte(p4);           
            Console.WriteLine(z);
            Console.WriteLine(" ==== zapisz bin ====");
            z.ZapiszBin("plyty.bin");
            Console.WriteLine("==== koniec ====");
            Plytoteka l2 = new Plytoteka();
            l2 = (Plytoteka)z.OdczytajBin("plyty.bin");
            Console.WriteLine("=== po odczycie ===");
            Console.WriteLine(l2);

            Console.ReadKey();
        }
    }
}
