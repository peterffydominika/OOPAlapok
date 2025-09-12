using System;

namespace OopAlapok{
    public class Szemely{
        private string nev;
        private int kor;

        public Szemely(string Nev, int Kor){
            this.nev = Nev;
            this.kor = Kor;
        }

        public string Kiir(){
            return $"A tanulo neve: {nev}, életkora: {kor}";
        }
        //public int Kor{
        //    get => kor;
        //    set{
        //        if (value <= 0)
        //            throw new ArgumentException("Kor nem lehet negatív.");
        //        kor = value;
        //    }
        //}
    }
    internal class Program{
        static void Main(string[] args){
            try{
                Szemely tanulo = new Szemely("Kiss Péter", 35);
                Console.WriteLine(tanulo.Kiir());
                //Console.WriteLine(tanulo.nev);
                //Console.WriteLine(tanulo.Kor);
            }
            catch (ArgumentException ex){
                Console.WriteLine($"Hiba: {ex.Message}");
            }
        }
    }
}