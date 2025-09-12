using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
        public virtual void KiIr()
        {
            Console.WriteLine("Én egy hallgató vagyok.");
        }
    }
    //5.Feladat
    class Bankszamla{
        private uint egyenleg;
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
    public class Dolgozo : Szemely{
        private int Ber;
        public override void KiIr(){
            Console.WriteLine("Én egy dolgozó vagyok.");
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
            Hallgato h2 = new Hallgato();
            h2.KiIr();
            Dolgozo d1 = new Dolgozo();
            d1.KiIr();
        }
    }
}