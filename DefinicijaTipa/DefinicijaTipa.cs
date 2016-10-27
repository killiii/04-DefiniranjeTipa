using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        int broj = 5;

        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {
        
        private string tekst;// = "MojaStruktura";
        public MojaStruktura(string tekst)
        {
            this.tekst = "MojaStruktura";
        }
       
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }


    public class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa mk = new MojaKlasa();
            mk.IspišiČlan();
        }

        public static void IspišiČlanStrukture()
        {
            
            MojaStruktura ms = new MojaStruktura("MojaStruktura");
            ms.IspišiČlan();

            MojaStruktura ms2 = new MojaStruktura("MojaStruktura");
            ms2.IspišiČlan();
        }

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
