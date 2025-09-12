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
        public string Kiir(){
            return $"A tanuló neve: {nev}, életkora: ";
        }
    }
    internal class Program{
        static void Main(string[] args){
            try{
                Szemely tanulo = new Szemely("Kiss Péter");
                Console.Write(tanulo.Kiir());
                tanulo.Kor = 32;
                Console.WriteLine(tanulo.Kor);
                //Console.WriteLine(tanulo.nev);
                //Console.WriteLine(tanulo.Kor);
            }
            catch (ArgumentException ex){
                Console.WriteLine($"Hiba: {ex.Message}");
            }
        }
    }
}