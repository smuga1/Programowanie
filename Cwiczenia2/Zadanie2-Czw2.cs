using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruzynaPierscieniaCNSL
{
    public enum Rasa { Elf, Ork, Krasnolud, Człowiek, Troll, Hobbit, Ent }
    interface IBohater
    {
        void BijWroga(Bohater r);
        void SprawdzHp();
    }

    public abstract class Bohater : IBohater
    {
        private Rasa rasa;
        public string imie;
        private int hp;
        private int atak;
        private int obrona;

        public Bohater(Rasa r, string im, int zycie, int obrazenia, int def)
        {
            this.rasa = r;
            this.imie = im;
            this.hp = zycie;
            this.atak = obrazenia;
            this.obrona = def;
        }

        public void BijWroga(Bohater x)
        {
            if(!CzyMartwi(x))
            {
                x.Hp -= this.Atak;
                Console.WriteLine(this.Rasa.ToString() + " " + this.Imie + " zadaje " + this.Atak + " punktow obrazen " + x.Rasa + "owi " + x.Imie);
            }
               
        }
        public void SprawdzHp()
        {
            Console.WriteLine(this.Rasa.ToString() + " " + this.Imie + " posiada " +  this.Hp + " punktow hp");
        }

        bool CzyMartwi(Bohater x)
        {
            if (this.Hp <= 0)
            {
                Console.WriteLine("Twoj bohater jest martwy");
                return true;
            }
            else if (x.Hp <= 0)
            {
                Console.WriteLine("Twoj przeciwnik jest martwy");
                return true;
            }
            return false;
        }
    }

    class Mag : Bohater
    {
        private int mana;

        public void RzucCzar(Bohater r) {
            Console.WriteLine(this.rasa.ToString() + " " + imie + " rzuca czar!");
            mana = mana - 10;
            Console.WriteLine("Mana: " + mana);
            BijWroga(r);
        }

        public Mag(Rasa r, string im, int zycie, int obrazenia, int def, int mana) : base(r, im, zycie, obrazenia, def)
        {
            this.mana = mana;
        }
    }

    class Wojownik : Bohater
    {
        public void RzucToporem(Bohater r)
        {
            Console.WriteLine(this.rasa.ToString() + " " + imie + " rzuca toporem!");
            BijWroga(r);
        }

        public Wojownik(Rasa r, string im, int zycie, int obrazenia, int def) : base(r, im, zycie, obrazenia, def)
        {
        }
    }
    class Rzezimieszek : Bohater
    {
        private int energia;

        public void Walcz(Bohater r)
        {
            energia = energia - 5;
            Console.WriteLine("Energia: " + energia);
            BijWroga(r);
        }

        public Rzezimieszek(Rasa r, string im, int zycie, int obrazenia, int def, int energia) : base(r, im, zycie, obrazenia, def)
        {
            this.energia = energia;
        }
    }
    class Ork : Bohater
    {
        public Ork(Rasa r, string im, int zycie, int obrazenia, int def) : base(r, im, zycie, obrazenia, def)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mag MAG = new Mag(Rasa.Elf, "Gandalf", 100, 20, 10, 160);
            Wojownik WOJ = new Wojownik(Rasa.Człowiek, "Janusz", 200, 10, 50);
            Rzezimieszek RZEZ = new Rzezimieszek(Rasa.Krasnolud, "Zbój", 150, 10, 40, 120);
            Ork ORK = new Ork(Rasa.Ork, "Uruk-Hai", 300, 30, 60);
            WOJ.SprawdzHp();
            MAG.SprawdzHp();
            RZEZ.SprawdzHp();
            ORK.SprawdzHp();

            MAG.RzucCzar(ORK);
            ORK.SprawdzHp();

            ORK.BijWroga(MAG);
            MAG.SprawdzHp();

            WOJ.RzucToporem(ORK);
            ORK.SprawdzHp();

            MAG.RzucCzar(ORK);
            ORK.SprawdzHp();

            ORK.BijWroga(WOJ);
            WOJ.SprawdzHp();

            MAG.BijWroga(ORK);
            ORK.SprawdzHp();

            RZEZ.Walcz(ORK);
            ORK.SprawdzHp();

            ORK.BijWroga(RZEZ);
            RZEZ.SprawdzHp();
            Console.ReadKey();
        }
    }
}
