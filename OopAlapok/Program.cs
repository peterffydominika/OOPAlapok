using System;
using System.Collections.Generic;

namespace OopAlapok{
    public class Szemely{
        protected string nev;
        private int kor;

        public int Kor{
            get => kor;
            set{
                if (value <= 0)   throw new ArgumentException("Kor nem lehet negatív.");
                else kor = value;
            }
        }
        public string Nev
        {
            get { return nev; }
            set { nev = value;}
        }
        public override string ToString(){
            return $"A tanuló neve: {nev}, életkora: {kor}";
        }
    }
    //5.Feladat
    class Bankszamla{
        private int egyenleg;
        public void Betesz()
        {

        }
        public void Kivesz()
        {

        }
    }
    public class Hallgato : Szemely{
        private string neptunKod;
        public string NeptunKod{
            get { return neptunKod; }
            set
            {
                if (value.Length <= 6)
                {
                    neptunKod = value;
                }
            }
        }

    }
    internal class Program{
        static void Main(string[] args){
            Szemely tanulo = new Szemely();
            tanulo.Kor = 32;
            tanulo.Nev = "Kiss Péter";
            Console.WriteLine(tanulo);

            List<Hallgato> nevsor = new List<Hallgato>();
            for (int i = 0; i < 3; i++)
            {
                Hallgato h1 = new Hallgato();
                Console.Write($"Kérem {i + 1}. nevet:");
                h1.Nev = Console.ReadLine();
                Console.Write($"Kérem {i + 1}. életkort:");
                h1.Kor = int.Parse(Console.ReadLine());
                nevsor.Add(h1);

            }
            foreach (var item in nevsor)
            {
                Console.WriteLine(item.Nev);
            }
        }
    }
}