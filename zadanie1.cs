using System;
using System.Collections.Generic;

namespace Samochod
{
    class Samochód
    {
        public string Marka { get; set; }
        public int LiczbaKol { get; set; }
        public double Predkosc { get; set; }
        public string Kolor { get; set; }
        public int Rocznik { get; set; }

        public Samochód(string marka, int liczba_kol, double predkosc, string kol, int rok )
        {
            this.Marka = marka;
            this.LiczbaKol = liczba_kol;
            this.Predkosc = predkosc;
            this.Rocznik = rok;
            this.Kolor = kol;
        }

        public Samochód(string kol, int rok)
        {
            this.Kolor = kol;
            this.Rocznik = rok;
        }

        public double Jedz(double aktualna_predkosc)
        {
            return Predkosc = aktualna_predkosc;
        }

        public double Hamuj()
        {
            return Predkosc = 0;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Samochód A = new Samochód("Opel" , 4, 54.2, "czarny", 1992);
            Samochód B = new Samochód();
            Samochód C = new Samochód("Fiat", 4, 102.2, "biały", 2014);
            A.Jedz(200.2);
            A.Hamuj();
            B.Jedz(23);
            B.Hamuj();
            C.Jedz(123);
            List<Samochód> lista_pojazdow = new List<Samochód>() {A,B,C };
            foreach(var samochod in lista_pojazdow)
            {
                Console.WriteLine("{0} samochód marki {1} jedzie z predkoscia {2}", samochod.Kolor.toString(), samochod.Marka.toString(), samochod.Predkosc.toString());
                Console.WriteLine("Domyslna ilosc kół używanych jednoczenie w samochodzie {0}", samochod.LiczbaKol.toString());
            }
            Console.ReadKey();
        }
    }
}
