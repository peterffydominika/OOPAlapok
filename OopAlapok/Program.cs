using System;

namespace OopAlapok
{
    public class Szemely
    {
        public string nev;
        private int kor;

        public Szemely(string nev, int kor)
        {
            this.nev = nev;
            this.Kor = kor; // Use the Kor property to enforce validation
        }

        public int Kor
        {
            get => kor;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Kor nem lehet negatív.");
                kor = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Szemely tanulo = new Szemely("Kiss Anna", 27);
                Console.WriteLine(tanulo.nev);
                Console.WriteLine(tanulo.Kor);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }
        }
    }
}