using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnii
{
    public enum Proizvodaci{Audi, Ford, Citroen, Renault }; 
    public enum DodatnaOprema {  aluFelge, navigacija, kamera};


    public struct Oglas
    {
        public string tip;
        public Proizvodaci Proizvodac;
        public int GodinaProizvodnje;
        public bool PrviVlasnik;
        public DodatnaOprema[] Oprema; 

    }

    class Program
    {
        
        private static List<Oglas> Oglasi = new List<Oglas>(); 
        static void Main(string[] args)
        {
            
            Oglas O;
           
            O.tip = "Fiesta";
            O.Proizvodac = Proizvodaci.Ford;
            O.GodinaProizvodnje = 2009;
            O.PrviVlasnik = true;
            O.Oprema = new DodatnaOprema[] { DodatnaOprema.aluFelge, DodatnaOprema.navigacija };

            Oglasi.Add(O);

            Oglasi.Add(new Oglas {
                tip = "Scenic",
                Proizvodac = Proizvodaci.Renault,
                GodinaProizvodnje = 2017,
                PrviVlasnik = false,
                Oprema = new DodatnaOprema[] { DodatnaOprema.navigacija, DodatnaOprema.kamera }
            });

           
            int koliko = 0;
            int ukupnoGodina = 0;
            foreach(Oglas og in Oglasi)
            {
                koliko++;
                ukupnoGodina += DateTime.Now.Year - og.GodinaProizvodnje;
                Console.WriteLine("{0} {1} {2} {3}", og.tip, og.Proizvodac, og.GodinaProizvodnje, og.PrviVlasnik );
            }
            Console.WriteLine("Prosjecna starost vozila: {0}", (double)ukupnoGodina/koliko);
        }
    }
}
