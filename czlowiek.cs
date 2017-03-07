using System;



namespace Samochod
{
    class StandardowyCzlowiek
    {
        private int _wiek;
        private string _imie;
        private string _miejscePochodzenia;
        private int _iloscKosci;
        private int iloscChromosomow;

        public StandardowyCzlowiek()
        {
            this._wiek = wiek;
            this._imie = imie;
            this._miejscePochodzenia = miejscePochodzenia;
            this._iloscKosci = 206;
            this._iloscChromosomow = 46;
        }


        

        public int sredniaWieku(int wiek) {

            int srednia = 0;
            srednia = srednia + wiek;

            return srednia;
        }

        public void wypiszImiona(int imie) { }

        public void miejscaPochodzenia(string miejscePochodzenia) { }

        public void daneStandardowe(int iloscKosci, int iloscChromosomow) { }


    }
   

    class Program
    {
        static void Main(string[] args)
        {

            StandardowyCzlowiek czlowiek1 = new StandardowyCzlowiek(24, "Jan", Olsztyn);
            StandardowyCzlowiek czlowiek2 = new StandardowyCzlowiek(25, "Ania", Warszawa);


            Console.ReadKey();
        }
    }
}