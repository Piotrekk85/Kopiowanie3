﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            Osoba o1 = new Osoba(30); //tworzy pierwszy obiekt i nadajemy mu wiek 30
            Osoba o2 = new Osoba(); //tworzymy drugi obiekt
            o2 = (Osoba)o1.Clone(); //kopiowanie za pomocą metody Clone(), potem rzutujemy na klasę Osoba

            //wartości po kopiowaniu
            Console.WriteLine("Wiek pierwszej osoby {0}", o1.PobierzWiek());
            Console.WriteLine("Wiek drugiej osoby {0}",o2.PobierzWiek());

            o1.UstawWiek(31); //zmiana wieku pierwszej osoby

            //wartości po zmianie
            Console.WriteLine("Po zmianie");
            Console.WriteLine("Wiek pierwszej osoby {0}", o1.PobierzWiek());
            Console.WriteLine("Wiek drugiej osoby {0}", o2.PobierzWiek());

            //sprawdzenie referencji
            if (Object.ReferenceEquals(o1, o2))
                Console.WriteLine("Referencje odwołują się do tego samego obiektu");
            else
                Console.WriteLine("Referencje nie odwołują się do tego samego obiektu");


            Console.ReadKey();

        }
    }
}
