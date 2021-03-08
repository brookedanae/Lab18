using System;
using System.Collections.Generic;

namespace Lab18
{
    class Program
    {

        static void Main(string[] args)
        {

            var list = new List(10);
            list.Insert("one");
            list.Insert("two");
            list.Insert("three");
            list.Insert("four");
            list.Insert("five");
            list.Insert("six");
            list.Insert("seven");
            list.Insert("eight");
            list.Insert("nine");

            Console.WriteLine(list.RemoveAt(1));
            Console.WriteLine(list.RemoveAt(11));

            list.PrintReverse();

            //var list2 = new List(10);
            //list2.Insert("hello");
            //list2.Insert("world");
            //list2.Insert("whats");
            //list2.Insert("up?");
            Object myObj = new Object();
            myObj = "testing";
            Console.WriteLine(list.InsertAt(11, myObj));
            Console.WriteLine(list.InsertAt(3, myObj));

        }
    }
}
