using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ionescu");
            //s.SetNote("");
            //eXERCITIUL 2

            string[] A =new string[args.Length];
            string X;
            string alf = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,X,Z";
            string[] Alfabet = alf.Split(',');
           for (int j = 0; j < args.Length; j++)
                A[j] = args[j];
            Console.WriteLine("ARGUMENTELE: ");
            for (int o = 0; o < A.Length; o++)
                Console.WriteLine(A[o]);
            Console.WriteLine();
           for(int i = 0;i<Alfabet.Length;i++)
            {
                Console.Write(Alfabet[i] + ":");
                for (int k = 0; k < A.Length; k++)
                    if (Alfabet[i] == A[k].Substring(0, 1))
                        Console.Write(A[k]);
                Console.WriteLine();
                
            }

            Console.WriteLine(s.ConversieLaSir());
            Console.ReadKey();
        }
    }
}
