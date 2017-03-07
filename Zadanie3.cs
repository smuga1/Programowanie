using System;



namespace Samochod
{
    class StandardowyCzlowiek
    {
        private int wiek;
        private string imie;
        private string miejscePochodzenia;
        private static int iloscKosci = 206;
        private static int iloscChromosomow = 46;

        public StandardowyCzlowiek(int wiek, string imie, string miejscePochodzenia)
        {
            this.wiek = wiek;
            this.imie = imie;
            this.miejscePochodzenia = miejscePochodzenia;
            
        }    
        public int sredniaWieku(List<StandardowyCzlowiek> lista)
        {
            int suma = 0;
            foreach (var ob in lista)
            {   
                suma += ob.wiek;
                Console.WriteLine(ob.imie);
            }
            return suma / lista.Count();
        }

        public static void miejscaPochodzenia(List<StandardowyCzlowiek> lista)
        {
            Dictionary<string, int> slownik = new Dictionary<string, int>();

            foreach (var ob in lista)
            {
                if (!slownik.ContainsKey(ob.miejscePochodzenia)) slownik.Add(ob.miejscePochodzenia, new int());
                slownik[ob.miejscePochodzenia]++;
            }

        }

        public void daneStandardowe()
        {
            Console.WriteLine("Ilosc Kosci: " + iloscKosci);
            Console.WriteLine("Ilosc Chromosomow: " + iloscChromosomow);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            StandardowyCzlowiek czlowiek1 = new StandardowyCzlowiek(24, "Jan", "Olsztyn");
            StandardowyCzlowiek czlowiek2 = new StandardowyCzlowiek(25, "Ania", "Warszawa");
            StandardowyCzlowiek czlowiek3 = new StandardowyCzlowiek(25, "Basia", "Warszawa");
            StandardowyCzlowiek czlowiek4 = new StandardowyCzlowiek(26, "Ania", "Warszawa");

            List<StandardowyCzlowiek> lista = new List <StandardowyCzlowiek>();
            lista.Add(czlowiek1);
            lista.Add(czlowiek2);
            lista.Add(czlowiek3);
            lista.Add(czlowiek4);
            

        }
    }
}
