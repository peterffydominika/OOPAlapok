using System;

namespace OopAlapok{
    public class Szemely{
        private string nev;
        private int kor;

        public Szemely(string Nev){
            this.nev = Nev;
        }
        public int Kor{
            get => kor;
            set{
                if (value <= 0)   throw new ArgumentException("Kor nem lehet negatív.");
                else kor = value;
            }
        }
        public override string ToString(){
            return $"A tanuló neve: {nev}, életkora: {kor}";
        }
    }
    internal class Program{
        static void Main(string[] args){
            try{
                Szemely tanulo = new Szemely("Kiss Péter");
                tanulo.Kor = 32;
                Console.Write(tanulo);
            }
            catch (ArgumentException ex){
                Console.WriteLine($"Hiba: {ex.Message}");
            }
        }
    }
}