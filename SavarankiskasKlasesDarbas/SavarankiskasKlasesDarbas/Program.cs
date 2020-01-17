using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavarankiskasKlasesDarbas
{
    
    struct Mokinys
    {
        private string vardas;
        private string pavarde;
        private DateTime kursoPradzia;
        private DateTime kursoPabaiga;

        public Mokinys(string Vardas, string Pavarde, DateTime kp, DateTime kpab )
        {
            this.vardas = Vardas;
            this.pavarde = Pavarde;
            this.kursoPradzia = kp;
            this.kursoPabaiga = kpab;
        }

        public string getVardas()
        {
            return vardas;
        }

        public string getPavarde()
        {
            return pavarde;
        }

        public DateTime getKursoPradzia()
        {
            return kursoPradzia;
        }

        public DateTime getKursoPab()
        {
            return kursoPabaiga;
        }

    }

    struct BibliotekosKnyga
    {
        private int knygosID;
        private string pavadinimas;
        private string skaitytojoVardas;
        private DateTime paemimoData;

        public BibliotekosKnyga(int ID, string Pavadinimas, string SKVardas, DateTime Paemimas)
        {
            this.knygosID = ID;
            this.pavadinimas = Pavadinimas;
            this.skaitytojoVardas = SKVardas;
            this.paemimoData = Paemimas;
        }

        public TimeSpan getDurationnTime()
        {
            return DateTime.Now.Subtract(paemimoData);
        }

    }

    struct staciakampis
    {
        private int ilgis;
        private int plotis;
        public staciakampis(int Ilgis, int Plotas)
        {
            this.ilgis = Ilgis;
            this.plotis = Plotas;
        }

        public int plotas()
        {
            return ilgis * plotis;
        }

    }

    public struct Studentas
    {
        private int studentoID;
        private bool iskaita;

        public Studentas(int ID,bool rez)
        {
            this.studentoID = ID;
            this.iskaita = rez;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Mokinys n1 = new Mokinys("Robertas","Javtokas", new DateTime(2019, 11, 12), new DateTime(2022, 02, 17));

            Console.WriteLine(n1.getVardas());
            Console.WriteLine(n1.getPavarde());
            Console.WriteLine(n1.getKursoPradzia());
            Console.WriteLine(n1.getKursoPab()); 

            BibliotekosKnyga b1 = new BibliotekosKnyga(1,"Stepiu Vilkas","Domantas",new DateTime(2020,01,12));
            Console.WriteLine("Skaitytojas turi knyga jau: {0}", b1.getDurationnTime().Days); 

            staciakampis s1 = new staciakampis(5,10);
            staciakampis s2 = new staciakampis(6,10);
            staciakampis s3 = new staciakampis(7,10);

            Console.WriteLine(s1.plotas());
            Console.WriteLine(s2.plotas());
            Console.WriteLine(s3.plotas()); */

            List<Studentas> listas = new List<Studentas>();
            Studentas s = new Studentas(10, true);
            listas.Add(s);
            listas.Add(new Studentas(20,true));
            listas.Add(new Studentas(30,true));
            listas.Add(new Studentas(40,true));

            foreach (var item in listas)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
