using System;



namespace Samochod
{
    class KontoBankowe
    {
        private string _imieNazwisko;
        private int[] _numerKonta;
        private double _fundusze;
        private int _idKonta;
        private bool _doUsuniecia;


        public KontoBankowe()
        {
            this._imieNazwisko = "TEST";
            this._numerKonta = null;
            this._fundusze = 0;
            this._idKonta = 0;
            this._doUsuniecia = true;
        }

        public KontoBankowe(string imieNazwisko, double fundusze)
        {
            this._imieNazwisko = imieNazwisko;
            this._numerKonta = GenerujNrKonta();
            this._fundusze = fundusze;
            this._idKonta = GenerujIdKonta();
            this._doUsuniecia = false;
        }
        public KontoBankowe(string imieNazwisko)
        {
            this._imieNazwisko = imieNazwisko;
            this._numerKonta = GenerujNrKonta();
            this._idKonta = GenerujIdKonta();
            this._fundusze = 0;
            this._doUsuniecia = false;
        }
        public void WplacPieniadze(double ilosc)
        {
            this._fundusze += ilosc;
        }
        public void WyplacPieniadze(double ilosc)
        {
            if (ilosc <= _fundusze)
                this._fundusze -= ilosc;
            else
                Console.WriteLine("Brak funduszy, możesz wypłacić maksymalnie {0:C2}", Convert.ToDecimal(_fundusze));
        }
        public void StanKonta()
        {
            Console.WriteLine("Stan konta {0:C2}", Convert.ToDecimal(_fundusze));
        }

        private int[] GenerujNrKonta()
        {
            int[] nrKonta = new int[26];
            Random r = new Random();
            for (int i = 0; i < nrKonta.Length; i++)
                nrKonta[i] = r.Next(0, 10);
            return nrKonta;
        }

        private int GenerujIdKonta()
        {
            int idKonta;
            Random r = new Random();
            idKonta = r.Next(100000, 99999999);
            return idKonta;
        }

        public void UsunKonto()
        {
            this._doUsuniecia = true;
        }

        public void ZmienFunduszeKonta(double odsetki)
        {
            this._fundusze += odsetki / 100 * _fundusze;
        }



    }
   

    class Program
    {
        static void Main(string[] args)
        {
      
            KontoBankowe A = new KontoBankowe("Jan Kowalski", 1200);
            A.WplacPieniadze(10000);
            A.ZmienFunduszeKonta(5);
            A.UsunKonto();
             
            Console.ReadKey();
        }
    }
}