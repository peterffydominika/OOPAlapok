using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAlapok
{
    public class Szemely
    {
        public string nev;
        public int kor;

        public Szemely(string nev, int kor) {
            this.nev = nev;
            this.kor = kor;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo = new Szemely("Kiss Anna",27);
            Console.WriteLine(tanulo.nev);
            Console.WriteLine(tanulo.kor);
            
        }
    }

}
