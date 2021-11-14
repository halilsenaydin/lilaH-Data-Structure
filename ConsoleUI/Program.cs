using DataStructures.Concretes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Lilah<object> list = new Lilah<object>();
            Console.WriteLine(list.array);
            list.Add("5");
            list.Add(5);
            list.Add(5);
            list.Add(5);
            list.Add(5);
            list.Add("5");
            list.Add("5");

            list.Add("Lilah");

            a sinif = new a();
            a h = new a();
            list.Add(sinif);
            list.Add(h);

            Console.WriteLine(list.Len);

            var result = list.Find(h);
            result.Show();


        }

        class a { };
    }
}
