using System;
using System.Collections.Generic;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = new List(10);
            list.Insert("one");
            list.Insert("two");
            list.Insert("three");
            list.Insert("four");

            list.RemoveAt(11);

            list.PrintReverse();

            list.InsertAt(4, object);
        }
    }
}
