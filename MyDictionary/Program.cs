using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {


            //Dictionary<int, string> dictionary = new Dictionary<int, string>();

            //dictionary.Add(1, "Adana");
            //dictionary.Add(2, "Adıyaman");
            //dictionary.Add(3, "Afyon");
            //dictionary.Add(4, "Ağrı");
            //dictionary.Add(5, "Amasya");
            //dictionary.Add(6, "Ankara");
            //Console.WriteLine(dictionary.Count);


            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Adana");
            myDictionary.Add(2, "Adıyaman");
            myDictionary.Add(3, "Afyon");
            myDictionary.Add(4, "Ağrı");
            myDictionary.Add(5, "Amasya");
            myDictionary.Add(6, "Ankara");

            Console.WriteLine(myDictionary.Count);




        }
    }
}
