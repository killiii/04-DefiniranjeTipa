﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
       public int broj = 5;

        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }

    
    struct MojaStruktura
    {

        public string tekst;// = "MojaStruktura";
        public MojaStruktura(string tekst)
        {
            this.tekst = "MojaStruktura";
        }

        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }

    public class ClassStruct
    {
        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            
            Console.WriteLine(mk1.broj);
            Console.WriteLine(mk2.broj);

            Console.WriteLine();
            
            mk2.broj = 2;
          
            Console.WriteLine(mk1.broj);
            Console.WriteLine(mk2.broj);

        }

        public static void IspišiStrukture()
        {
            
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
           
            Console.WriteLine(ms1.tekst);
            Console.WriteLine(ms2.tekst);

          
            // TODO: Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
            
            Console.WriteLine(ms1.tekst);
            Console.WriteLine(ms2.tekst);

          
            ms2.tekst = "MyStruct";
          


        }

        static void Main(string[] args)
        {
            IspišiKlase();

            Console.WriteLine();

            IspišiStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
