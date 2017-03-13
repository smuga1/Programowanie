using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class AstonMartin : ISamochod
    {
        private string marka;
        private string salon;

        public AstonMartin(string marka, string salon)
        {
            this.marka = marka;
            this.salon = salon;
        }

        public string WypiszMarke() { return marka; }
        public string WypiszSalon() { return salon; }
    }

    class RangeRover : ISamochod
    {
        private string marka;
        private string salon;

        public RangeRover(string marka, string salon)
        {
            this.marka = marka;
            this.salon = salon;
        }
        public string WypiszMarke() { return marka; }
        public string WypiszSalon() { return salon; }
    }

    class RollsRoyce : ISamochod
    {
        private string marka;
        private string salon;

        public RollsRoyce(string marka, string salon)
        {
            this.marka = marka;
            this.salon = salon;
        }
        public string WypiszMarke() { return marka; }
        public string WypiszSalon() { return salon; }
    }


    public interface ISamochod
    {
        string WypiszMarke();
        string WypiszSalon();
    }

    class Program
    {
        static void Main(string[] args)
        {
            AstonMartin a1 = new AstonMartin("Aston Martin", "Salon1");
            RangeRover a2 = new RangeRover("Range Rover", "Salon2");
            RollsRoyce a3 = new RollsRoyce("Rolls Royce", "Salon 3");

            a1.WypiszMarke();
            a1.WypiszSalon();

            a2.WypiszMarke();
            a2.WypiszSalon();

            a3.WypiszMarke();
            a3.WypiszSalon();
        }
    }
}
