using System;

namespace GunDortOdev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(34,"İstanbul");
            myDictionary.Add(06,"Ankara");

            Console.WriteLine(myDictionary.Count);
           

        }
    }
}
