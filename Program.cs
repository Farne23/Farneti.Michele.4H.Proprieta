using System;

namespace Farneti.Michele._4H.Proprieta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma \"Proprieta\" scritto da Michele Farneti 4H");

            Quadrato q = new Quadrato(-10);

            Console.WriteLine($"Lato del quadrato {q.Lato}");
            Console.WriteLine($"Area del quadrato {q.Area}");

            q.Lato = 20;

            Console.WriteLine($"Lato del quadrato {q.Lato}");
            Console.WriteLine($"Area del quadrato {q.Area}");

            q.Area = 144;
            Console.WriteLine($"Lato del quadrato {q.Lato}");
            Console.WriteLine($"Area del quadrato {q.Area}");

            for(int val=2;val<10;val++)
            {
                q.Lato++;
                Console.WriteLine($"Lato del quadrato {q.Lato},Area:{q.Area}");
            }

            q.Lato = -35;
            Console.WriteLine(q); //Chiama da solo il ToString


        }
    }

    public class Quadrato
    {
        //field lato
        private double _lato;

        //property lato
        public double Lato
        {
            //Il get si occupa della lettura
            get
            {
                return _lato;
            }
            //Il set si occupa della scrittura
            set
            {
                if (value >= 0)
                {
                    _lato = value;
                    _area = _lato * _lato;
                }
                else
                {
                    _lato = -value;
                    _area = _lato * _lato;
                }
                //_area = _lato * _lato; //viola il principio di singola responsabilità
            }
        }
        //field area
        private double _area;//Questo field è ridondante e progettato male
                             // e sufficiente lato per esprimere lo stato di un quadrato

        //property lato
        public double Area
        {
            get
            {
                return _lato*_lato;
            }

            set
            {
               _lato = Math.Sqrt(value);
            }
        }

        //Costruttore di default(viene chiamato senza parametri)
        public Quadrato() { }
        //Costruttore a partire dal lato
        public Quadrato(double lato)
        {
            Lato = lato;
        }

        //Permette di decidere cosa dare in output
        public override string ToString()
        {
            return $"Lato: {Lato}, Area: {Area}";
        }
    }
}
