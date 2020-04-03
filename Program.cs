using System;
using System.Data;
using System.Collections;
using System.IO;
using Car;

namespace RegistruMasini
{
    class Program
    {
        const int MAX = 100;
        static void Main()
        {
            

            Masina[] RegM = new Masina[MAX];
            int NRM = 0;
            try
            {
                using (StreamReader sr = new StreamReader("Masini.txt"))
                {
                    string linie;
                    while ((linie = sr.ReadLine()) != null)
                    {
                        RegM[NRM++] = new Masina(linie);
                        if (NRM == MAX)
                        { Array.Resize(ref RegM, NRM + 20); }
                    }


                }

            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului : " + eIO.Message);

            }
            while (true)
            {

                    Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0 , -10} {1,35} {2,30}", "###", "RegistruMasini v1.0", "###");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("* A - Vizualizare registru masini");
                Console.WriteLine("* B - Adaugare masina in registru");
                Console.WriteLine("* C - Stergere masina din registru");
                Console.WriteLine("* D - Editare masina din registru ");
                Console.WriteLine("* E - Compara doua masini ");
                Console.WriteLine("* F - Cautare masina in registru");
                Console.WriteLine("* X - Iesire aplicatie!");
                Console.WriteLine();
                Console.Write("Introduceti optiunea dorita: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;

                string titlu = string.Format("{0,0}{1,10}{2,10}{3,15}{4,10}{5,10}\n", "NrC|", "Marca|", "Model|", "Culoare|", "Pret|", "An");

                string OPT = Console.ReadLine();
                switch (OPT)
                {
                    case "A":
                    case "a":
                        Console.WriteLine();
                        Console.WriteLine(titlu);
                        Console.ResetColor();
                        //for (int i = 0; i < NRM; i++)
                        //    Console.WriteLine(i +"\t"+ (RegM[i].Info()));
                        RegM[0].chenar(RegM, NRM);

                        
                        Console.ReadKey();
                        break;
                    case "B":
                    case "b":
                        var x = new Masina().CitireTastatura();
                        RegM[NRM++] = x;
                        //if (RegM[NRM]!= Null)
                        //    Console.WriteLine("Adaugat cu succes! ");
                        //else
                        //    Console.WriteLine("Adaugare esuata! :(");
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
                        Console.WriteLine(titlu);
                        for (int i = 0; i < NRM; i++)
                            Console.WriteLine(i + "\t" + RegM[i].Info());
                        Console.WriteLine("Care masini doriti sa le comparati?(numarul) : ");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        if (RegM[x1].ComparareMasini(RegM[x2]) == true)
                            Console.WriteLine("Numarul " + x1 + " si numarul " + x2 + " sunt lafel");
                        else
                            Console.WriteLine("Numarul " + x1 + " si numarul " + x2 + " nu sunt lafel");
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
