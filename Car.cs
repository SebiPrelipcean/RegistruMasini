using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Masina
    {
        private string marca;
        private string culoare;
        private string model;
        private double pret;
        private double an;

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
            culoare = string.Empty;
            model = string.Empty;
            pret = 0;
            an = 0;
        }

        //Constructor cu parametri
        public Masina(string _Marca, string _model, string _culoare, double _pret, double _an)
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
            culoare = ch[2];
            pret = Convert.ToDouble(ch[3]);
            an = Convert.ToDouble(ch[4]);
        }

        public Masina CitireTastatura()
        {
            Console.WriteLine("Introduceti marca masini: ");
            string _Mm = Console.ReadLine();
            Console.WriteLine("Introduceti model: ");
            string _Md = Console.ReadLine();
            Console.WriteLine("Introduceti culoarea: ");
            string _Cc = Console.ReadLine();
            Console.WriteLine("Introduceti pretul");
            double _Pp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti anul: ");
            double _Aa = Convert.ToDouble(Console.ReadLine());
            Masina m = new Masina(_Mm, _Md, _Cc, _Pp, _Aa);
            return m;
        }
        //ConversieLaSir
        public string Info()
        {
            return string.Format("{0,0}{1,10}{2,15}{3,10}{4,10}", marca, model, culoare, pret, an);
        }
    }
}
