using System;
using System.Data;
using Car;

namespace RegistruMasini
{
    class Program
    {
        
        static void Main()
        {
            while (true)
            {
                
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("{0 , -10} {1,35} {2,30}", "###", "RegistruMasini v1.0", "###");
                Console.WriteLine();
                Console.WriteLine("* A - Vizualizare registru masini");
                Console.WriteLine("* B - Adaugare masina in registru");
                Console.WriteLine("* C - Stergere masina din registru");
                Console.WriteLine("* D - Editare masina din registru ");
                Console.WriteLine("* E - Cea mai cautata masina intr-o anumita perioada ");
                Console.WriteLine("* F - Grafic pret pentru o masina din registru");
                Console.WriteLine("* G - Afisarea tranzactiilor intr-o zi ");
                Console.WriteLine("* X - Iesire aplicatie!");
                Console.WriteLine();
                Console.WriteLine("Introduceti optiunea dorita: ");
                var a = new Masina("MAZDA","3","NEAGRA",2000,2004);
                string titlu = string.Format("{0,0}{1,10}{2,15}{3,10}{4,10}\n", "Marca", "Model", "Culoare", "Pret", "An");
                var b = new Masina("Audi,A5,Gri,2450,2006");
                string OPT = Console.ReadLine();
                switch (OPT)
                {
                    case "A":
                    case "a":
                        string afisare = a.Info();
                        Console.WriteLine(titlu);
                        Console.WriteLine(afisare);
                        Console.WriteLine(b.Info());
                        Console.ReadKey();
                        break;
                    case "B":
                    case "b":
                        Console.ReadKey();
                        break;
                    case "C":
                    case "c":
                        Console.ReadKey();
                        break;
                    case "D":
                    case "d":
                        Console.ReadKey();
                        break;
                    case "E":
                    case "e":
                        Console.ReadKey();
                        break;
                    case "F":
                    case "f":
                        Console.ReadKey();
                        break;
                    case "G":
                    case "g":
                        Console.ReadKey();
                        break;
                    case "X":
                    case "x":
                        Console.WriteLine("Doriti sa salvati modificarile? :");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }


                Console.ReadKey();
            }
        }

    }
}
