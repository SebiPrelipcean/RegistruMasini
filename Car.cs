using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    //public void chenar(Masina[] reg, int nr)
    //{
    //    int i;
    //    Console.BackgroundColor = ConsoleColor.Red;
    //    for (i = -1; i < nr + 1; i++)
    //        Console.Write("_");
    //    for (i = 0; i < nr; i++)
    //        Console.WriteLine("| " + reg[i].Info() + " |");
    //    for (i = -1; i < nr + 1; i++)
    //        Console.Write("_");



    //}
    class Masina
    {
        private string marca;
        //private string culoare;
        private string model;
        private double pret;
        private double an;
        private Culoare culoare { get; set; }



        //Proprietati auto-implemented
        public string MarcaMasina { get; set; }
        public string CuloaMasina { get; set; }
        public string ModelMasina { get; set; }
        public double PretMasina { get; set; }
        public double AnMasina { get; set; }


        //Constructor implicit masina
        public Masina()
        {
            marca = string.Empty;
            culoare = Culoare.Alb;
            model = string.Empty;
            pret = 0;
            an = 0;
        }

        //Constructor cu parametri
        public Masina(string _Marca, string _model, Culoare _culoare, double _pret, double _an)
        {
            marca = _Marca;
            culoare = _culoare;
            model = _model;
            pret = _pret;
            an = _an;
        }

        public Masina(string date)
        {
            string[] ch = date.Split(",");
            marca = ch[0];
            model = ch[1];
            int help = Convert.ToInt32(ch[2]);
            culoare = (Culoare)help;
            pret = Convert.ToDouble(ch[3]);
            an = Convert.ToDouble(ch[4]);
        }

        public Masina CitireTastatura()
        {
            Console.WriteLine("Introduceti marca masini: ");
            string _Mm = Console.ReadLine();
            Console.WriteLine("Introduceti model: ");
            string _Md = Console.ReadLine();
            Console.WriteLine("1 - Rosu \n" +
            "2 - Galben \n" +
            "3 - Albastru \n" +
            "4 - Verde \n" +
            "5 - Alb \n" +
            "6 - Negru \n");
            Console.WriteLine("Introduceti culoarea: ");
            int optt = Convert.ToInt32(Console.ReadLine());
            Culoare _Cc =  (Culoare)optt;
            Console.WriteLine("Introduceti pretul");
            double _Pp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti anul: ");
            double _Aa = Convert.ToDouble(Console.ReadLine());
            Masina m = new Masina(_Mm, _Md, _Cc, _Pp, _Aa);
            return m;
        }

        public bool ComparareMasini(Masina a2)
        {
            if (string.Equals(marca, a2.marca))
                return true;
            else return false;
        }

        public string Info()
        {
            return string.Format("{0,5}{1,10}{2,15}{3,10}{4,10}", marca, model, culoare, pret, an);
        }

        public  Masina Atribbuit (Masina x)
        {
            x.marca = marca;
            x.pret = pret;
            x.model = model;
            x.culoare = culoare;
            x.an = an;
            return x;
        }

        public void chenar(Masina[] reg, int nr)
        {
            int i;
            Console.BackgroundColor = ConsoleColor.Red;
            for (i = -1; i < nr + 1; i++)
                Console.Write("_");
            for (i = 0; i < nr; i++)
                Console.WriteLine("| " + reg[i].Info() + " |");
            for (i = -1; i < nr + 1; i++)
                Console.Write("_");



        }
    }
}
