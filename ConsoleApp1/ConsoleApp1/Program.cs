using System;
using System.Collections.Generic;

using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> names = new List<string>();
            names.Add("Parm Dhillon");
            names.Add("Jas Brar");
            names.Add("Harisman Brar");
            names.Add("Jagdeep Singh");
            names.Add("Jayvin Sann");
            names.Add("Harp Rai");
            names.Sort();
            foreach (string s in names)
                Console.WriteLine(s);
            Console.WriteLine("------------UPPER CASE--------------");
            foreach (string s in names)
                if (s=="Harp Rai")
                {

                }
                else
                {
                    Console.WriteLine(s.ToUpper());
                }
            Console.WriteLine("------------BEFORE REPLACE--------------");
            string p = "Easiest way to reach Chaacha house is link state road.Chaacha is not coming to pick up the students.";
            Console.WriteLine(p);
            Console.WriteLine("------------AFTER REPLACE--------------");
            Console.WriteLine(p.Replace("Chaacha", "Chaachi"));
            Console.WriteLine("------------CHARGES--------------");
            int a = 50;
            double b = 2.50;
            double c = .25;
            double d,tc;
            d = a * (b * c);
            tc = (d * 6);
            Console.WriteLine(a+" miles");
            Console.WriteLine(b+ " charge per mile ");
            Console.WriteLine(c+ " fuel surcharge");
            Console.WriteLine("total charge! "+d);
            Console.WriteLine("total charge for all students " + tc);

            Console.WriteLine("------------IF ELSE --------------");
            if (d>=225)
            {
                Console.WriteLine("your chaacha loves money too much");
            }
            else
            {
                Console.WriteLine("chaacha is so loving and loves all his nieces and nephews");
            }


            Console.WriteLine("------------CHACHA'S FAV STUDENTS--------------");
            foreach (string s in names)
                if (s == "Parm Dhillon")
                {

                }
                else
                {
                    Console.WriteLine(s);
                }

            Console.WriteLine("------------HARP'S INDEX--------------");
            Console.WriteLine("Index of Harp's is "+ names.IndexOf("Harp Rai"));
            Console.ReadLine();
        }
    }
}