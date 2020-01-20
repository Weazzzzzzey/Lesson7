using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbaiStruct
{
        //Sukurti struktūrą Studentas.
    
        //Joje turi
    //būti 3 sąrašai su trimestrų
    //pažymiais.

        //Struktūra turi turėti
    //metodus trimestro vidurkiui ir
    //metiniam pažymiui suskaičiuoti.

    struct Studentas
    {
        List<int> PirmasT;
        List<int> AntrasT;
        List<int> TreciasT;


        public void Uzpildymas1()
        {
            PirmasT = new List<int>();
            PirmasT.Add(8);
            PirmasT.Add(6);
            PirmasT.Add(8);
            PirmasT.Add(6);
            //7
        }

        public void Uzpildymas2()
        {
            AntrasT = new List<int>();
            AntrasT.Add(10);
            AntrasT.Add(8);
            AntrasT.Add(10);
            AntrasT.Add(8);
            //9
        }

        public void Uzpildymas3()
        {
            TreciasT = new List<int>();
            TreciasT.Add(7);
            TreciasT.Add(7);
            TreciasT.Add(9);
            TreciasT.Add(9);
            //8
        }

        public double trimestroV1()
        {
            return PirmasT.Average();
        }

        public double trimestroV2()
        {
            return AntrasT.Average();
        }
        public double trimestroV3()
        {
            return TreciasT.Average();
        }

        public void Trimestrai()
        {
            Console.WriteLine("Pirmao trimestro vidurkis: {0}", trimestroV1());
            Console.WriteLine("Antro trimestro vidurkis: {0}", trimestroV2());
            Console.WriteLine("Trecio trimestro vidurkis: {0}", trimestroV3());
        }

        public void visuSUzpildymas()
        {
            Uzpildymas1();
            Uzpildymas2();
            Uzpildymas3();
        }

        public double MetinisV()
        {
            return  (trimestroV1() + trimestroV2() + trimestroV3()) / 3;
        }
    }

    public class RinkejuS
    {
        Random rnd = new Random();
        List<Rinkejas> Rinkejai = new List<Rinkejas>();
        bool balsavo = false;
            
        public void uzpildymas()
        {
            for (int i = 0; i < 10; i++)
            {
                if (rnd.Next(2) == 1)
                {
                    balsavo = true;
                }
                else
                {
                    balsavo = false;
                }
                Rinkejai.Add(new Rinkejas(i, balsavo));
            }
        }
        
        public void AlreadyVoted()
        {
            int voted = 0;
            foreach (var item in Rinkejai)
            {
                if (item.getBalsas() == true)
                {
                    voted++;
                }
            }
            Console.WriteLine("Jau prabalsavo is viso: {0} is 10", voted);
        }
    
    
    
    }
    
    
    struct Rinkejas
    {

        // Sukurti struktūrą Rinkėjas.
        //Rinkėjas turi ID ir požymį, kad prabalsavo.
        //Sukurti rinkėjų sąrašą. Atsitiktiniu
        //būdu į sąrašą pridėti 10 rinkėjų.
        //Parodyti balsavimo statistiką.

        private int RinkejoID;
        private bool Prabalsavo;

        public Rinkejas(int ID, bool Balsas)
        {
            this.RinkejoID = ID;
            this.Prabalsavo = Balsas;
        }

        public int getID()
        {
            return RinkejoID;
        }

        public bool getBalsas()
        {
            return Prabalsavo;
        }
    }


    public struct Gyvunas
    {
        private string Vardas;
        private string Rusis;

        public Gyvunas(string vardas, string rusis)
        {
            this.Vardas = vardas;
            this.Rusis = rusis;
        }

        public string getVardas()
        {
            return Vardas;
        }

        public string getRusis()
        {
            return Rusis;
        }

    }


    public struct ZooSodas
    {
        private string Pavadinimas;
        private string adresas;
        private List<Gyvunas> gyvunai;

        public ZooSodas(string pav, string adresas)
        {
            this.Pavadinimas = pav;
            this.adresas = adresas;
            gyvunai = new List<Gyvunas>();
        }

        public void gyvunuIpildymas()
        {
            gyvunai = new List<Gyvunas>();
            gyvunai.Add(new Gyvunas("Vilkas","Vilkiniai"));
            gyvunai.Add(new Gyvunas("Lusis","Vilkiniai"));
            gyvunai.Add(new Gyvunas("Kojotas","Vilkiniai"));
            gyvunai.Add(new Gyvunas("Strutis","Pauksciai"));
            gyvunai.Add(new Gyvunas("Erelis", "Pauksciai"));
            gyvunai.Add(new Gyvunas("Gandras", "Pauksciai"));
            gyvunai.Add(new Gyvunas("Povas", "Pauksciai"));
        }

        public void newAnimal(string vardasN,string rusisN)
        {
            gyvunai.Add(new Gyvunas(vardasN, rusisN));
        }

        public int getAnimalsCount()
        {
            return gyvunai.Count();
        }

        public void Glistas()
        {
            foreach (var item in gyvunai)
            {
                Console.WriteLine("Rusis: {0}, Vardas: {1}", item.getRusis(),item.getVardas());
            }
        }

    }

    struct Point
    {

        private double x;
        private double y;

        public Point(double x, double y)
        {
            
            this.x = x;
            this.y = y;
        }

        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }

    }

    public struct reqT
    {
        private Point TopLeft;
        private Point BottonRight;


        public reqT(int x1, int y1, int x2,int y2)
        {
            this.TopLeft = new Point(x1,y1);
            this.BottonRight = new Point(x2,y2);
        }

        public string CheckPoint(int X, int Y)
        {
            if ((TopLeft.getX() <= X) && (BottonRight.getX() >= X))
            {
                if ((TopLeft.getY() <= Y) && (BottonRight.getY() >= Y))
                {
                    return "Taskas yra kvadrate.";
                }else
                { return "Tasko nera kvadrate."; }

            }
            else { return "Tasko nera kvadrate."; }


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Studentas s = new Studentas();
            s.visuSUzpildymas();
            s.Trimestrai();
            Console.WriteLine("Metinis vidurkis yra: {0}", s.MetinisV()); */

            /*
            RinkejuS r = new RinkejuS();
            r.uzpildymas();
            r.AlreadyVoted(); */

            /*
            ZooSodas KaunoSodas = new ZooSodas();
            KaunoSodas.gyvunuIpildymas();
            Console.WriteLine(KaunoSodas.getAnimalsCount());
            KaunoSodas.Glistas();
            */

            /*
            reqT r1 = new reqT(0,0,3,3);
            reqT r2 = new reqT(0,0,10,10);
            Console.WriteLine(r2.CheckPoint(4, 4));
            */
            
            Console.ReadLine();
        
        }
    }
}
